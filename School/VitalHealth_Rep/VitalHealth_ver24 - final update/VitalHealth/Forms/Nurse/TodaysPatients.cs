using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VitalHealth.CustomControls;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;
using MySql.Data.MySqlClient;
using System.Speech.Synthesis;

namespace VitalHealth.Forms.Nurse
{
    public partial class TodaysPatients : Form
    {
        private const int PageSize = 10;

        private readonly List<TodaysPatientRow> _allPatients = new List<TodaysPatientRow>();
        private List<TodaysPatientRow> _filteredPatients = new List<TodaysPatientRow>();

        private int _currentPage = 1;
        private int _totalPages = 1;
        private bool _patientHistoryExpanded = false;

        public TodaysPatients()
        {
            InitializeComponent();

            backArrowDG.Click += backArrowDG_Click;
            nextArrowDG.Click += nextArrowDG_Click;
        }

        private void TodaysPatients_Load(object sender, EventArgs e)
        {
            lbl_nurseLastName.Text = MainForm.loggedInUserLastname;

            if (cmbB_filterSpecialty.Items.Count > 0)
            {
                cmbB_filterSpecialty.SelectedIndex = 0; // first specialization
                string firstSpec = cmbB_filterSpecialty.SelectedItem.ToString();

                LoadTodaysPatients(firstSpec, "", cmbB_filterStatus.SelectedItem?.ToString());
                UpdatePatientCount(firstSpec);
            }

            foreach (Control c in txtB_searchBar.Controls)
            {
                if (c is TextBox internalTextBox)
                {
                    internalTextBox.TextChanged += (s, ev) =>
                    {
                        _currentPage = 1;
                        PerformSearchAndFilter();
                    };
                }
            }

            dtgView_todaysPatients.Grid.SelectionChanged += dtgView_todaysPatients_SelectionChanged;

            btn_pastRecords.Visible = false;
            btn_missedCheckups.Visible = false;
            btn_patientHistory.Text = "Patient History  ▼"; // ✅ default state

            if (cmbB_filterStatus.Items.Count > 0)
            {
                cmbB_filterStatus.SelectedIndex = cmbB_filterStatus.FindStringExact("Waiting");
            }

            _currentPage = 1;
            PerformSearchAndFilter();
        }

        // Added parameter 'specialtyFilter' so the method knows what to filter
        private void LoadTodaysPatients(string specialtyFilter = "All", string searchTerm = "", string selectedStatus = "")
        {
            _allPatients.Clear();

            var db = new VitalHealth.Data.DBConnection();
            using var conn = db.GetConnection();

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // PART A: AUTO-UPDATE STATUS FOR DR. TAN
                string updateSql = @"UPDATE patient_queue SET queue_status_id = 3 
                             WHERE doctor_id = 11 AND queue_status_id = 1 
                             AND DATE(queued_at) = CURDATE() AND CURRENT_TIME() > '12:00:00'";

                using (MySqlCommand updateCmd = new MySqlCommand(updateSql, conn))
                {
                    updateCmd.ExecuteNonQuery();
                }

                // PART B: FETCH DATA (Excluding status 3 - On-Hold/Missed)
                string sql = @"
                SELECT 
                    pq.queue_id, 
                    pq.patient_id, 
                    pq.queue_number, 
                    pd.first_name, 
                    pd.last_name, 
                    DATE(pq.queued_at) AS QueueDate,
                    DATE_FORMAT(pq.queued_at, '%h:%i %p') AS ArrivalTime, 
                    CONCAT('Dr. ', up.first_name, ' ', up.last_name) AS DoctorName, 
                    ds.specialty_name, 
                    ds.checkup_fee AS payment_fee,
                    qs.status_name, 
                    IFNULL(ra.room_id, 'TBA') AS current_room
                FROM patient_queue pq 
                JOIN patient_data pd ON pq.patient_id = pd.patient_id 
                JOIN user_profile up ON pq.doctor_id = up.user_id 
                JOIN doctor_specialty dsl ON up.user_id = dsl.user_id 
                JOIN doctor_specialties ds ON dsl.specialty_id = ds.specialty_id 
                JOIN queue_status qs ON pq.queue_status_id = qs.queue_status_id 
                LEFT JOIN room_assignment ra ON pq.doctor_id = ra.doctor_id 
                LEFT JOIN patient_payment_data pp ON pq.queue_id = pp.queue_id
                WHERE pq.queue_status_id != 3";

                // ✅ Only show TODAY unless status is "To Pay"
                if (!string.Equals(selectedStatus, "To Pay", StringComparison.OrdinalIgnoreCase))
                {
                    sql += " AND DATE(pq.queued_at) = CURDATE()";
                }

                sql += " AND ds.specialty_name = @spec";

                // FIX: Use CONCAT to join first and last name so the search sees the "Full Name"
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    sql += " AND CONCAT(pd.first_name, ' ', pd.last_name) LIKE @search";
                }

                sql += " ORDER BY pq.queued_at ASC";

                using MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@spec", specialtyFilter);

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm.Trim() + "%");
                }

                using MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _allPatients.Add(new TodaysPatientRow
                    {
                        QueueID = Convert.ToInt32(reader["queue_id"]),
                        PatientID = Convert.ToInt32(reader["patient_id"]),
                        QueueNumber = reader["queue_number"]?.ToString() ?? "",
                        PatientName = $"{reader["first_name"]} {reader["last_name"]}",
                        Date = Convert.ToDateTime(reader["QueueDate"]).ToString("yyyy-MM-dd"),
                        ArrivalTime = reader["ArrivalTime"]?.ToString() ?? "",
                        AssignedDoctor = reader["DoctorName"]?.ToString() ?? "",
                        Specialty = reader["specialty_name"]?.ToString() ?? "",
                        RoomNumber = reader["current_room"]?.ToString() ?? "",
                        Status = reader["status_name"]?.ToString() ?? "",
                        PaymentFee = reader["payment_fee"] != DBNull.Value
                        ? Convert.ToDecimal(reader["payment_fee"])
                        : 0
                    });
                }

                //ApplySearchAndPagination();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ApplySearchAndPagination()
        {
            //_filteredPatients = new List<TodaysPatientRow>(_allPatients);

            _totalPages = Math.Max(1, (int)Math.Ceiling(_filteredPatients.Count / (double)PageSize));

            if (_currentPage > _totalPages)
                _currentPage = _totalPages;

            if (_currentPage < 1)
                _currentPage = 1;

            LoadCurrentPageToGrid();
            UpdatePaginationUI();
            UpdateCountDisplay();

            bttn_markIn.Enabled = false;
            bttn_callQueuingNumber.Enabled = false;
            bttn_cancel.Enabled = false;
            bttn_paid.Enabled = false;
        }

        private void LoadCurrentPageToGrid()
        {
            dtgView_todaysPatients.Grid.Rows.Clear();

            var pageItems = _filteredPatients
                .Skip((_currentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            foreach (var item in pageItems)
            {
                int rowIndex = dtgView_todaysPatients.Grid.Rows.Add(
                    item.QueueID,
                    item.PatientID,
                    item.QueueNumber,
                    item.PatientName,
                    item.Date,
                    item.ArrivalTime,
                    item.AssignedDoctor,
                    item.Specialty,
                    item.RoomNumber,
                    item.Status,
                    item.PaymentFee
                );

                dtgView_todaysPatients.Grid.Rows[rowIndex].DefaultCellStyle.ForeColor = item.Status.ToLower() switch
                {
                    "waiting" => Color.Black,
                    "on-hold" => Color.Red,
                    "on-going" => Color.Blue,
                    "to pay" => Color.Orange,
                    "done" => Color.Green,
                    _ => Color.Black
                };
            }

            dtgView_todaysPatients.Grid.ClearSelection();
            dtgView_todaysPatients.Grid.CurrentCell = null;
        }

        private void UpdatePaginationUI()
        {
            var pageLabels = new List<Label> { page1DG, page2DG, page3DG, page4DG, page5DG };

            int groupStart = ((_currentPage - 1) / 5) * 5 + 1;

            for (int i = 0; i < pageLabels.Count; i++)
            {
                int pageNumber = groupStart + i;

                pageLabels[i].Visible = true;
                pageLabels[i].Text = pageNumber.ToString();
                pageLabels[i].Cursor = Cursors.Default;

                if (pageNumber == _currentPage)
                {
                    pageLabels[i].ForeColor = Color.FromArgb(74, 214, 109);
                }
                else
                {
                    pageLabels[i].ForeColor = Color.Black;
                }
            }

            backArrowDG.Enabled = _currentPage > 1;
            nextArrowDG.Enabled = _currentPage < _totalPages;

            backArrowDG.Cursor = backArrowDG.Enabled ? Cursors.Hand : Cursors.Default;
            nextArrowDG.Cursor = nextArrowDG.Enabled ? Cursors.Hand : Cursors.Default;
        }

        private void backArrowDG_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadCurrentPageToGrid();
                UpdatePaginationUI();

                bttn_markIn.Enabled = false;
                bttn_callQueuingNumber.Enabled = false;
                bttn_cancel.Enabled = false;
                bttn_paid.Enabled = false;
            }
        }

        private void nextArrowDG_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                LoadCurrentPageToGrid();
                UpdatePaginationUI();

                bttn_markIn.Enabled = false;
                bttn_callQueuingNumber.Enabled = false;
                bttn_cancel.Enabled = false;
                bttn_paid.Enabled = false;
            }
        }

        private void UpdatePatientCount(string specialty = "All")
        {
            var db = new VitalHealth.Data.DBConnection();
            using var conn = db.GetConnection();

            string sql = @"
            SELECT COUNT(*) 
            FROM patient_queue pq
            JOIN user_profile up ON pq.doctor_id = up.user_id
            JOIN doctor_specialty dsl ON up.user_id = dsl.user_id
            JOIN doctor_specialties ds ON dsl.specialty_id = ds.specialty_id
            WHERE DATE(pq.queued_at) = CURDATE() 
            AND pq.queue_status_id = 1";

            sql += " AND ds.specialty_name = @spec";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@spec", specialty);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                lbl_patientsInLine.Text = count.ToString();

                // Red Alert logic: Over 10 patients
                lbl_patientsInLine.ForeColor = (count > 10) ? Color.Red : Color.Black;
            }
            catch (Exception)
            {
                lbl_patientsInLine.Text = "0";
            }
        }

        private void cmbB_filterSpecialty_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            PerformSearchAndFilter();
        }

        private void PerformSearchAndFilter()
        {
            string selectedSpecialty = cmbB_filterSpecialty.SelectedItem?.ToString() ?? cmbB_filterSpecialty.Text;
            string selectedStatus = cmbB_filterStatus.SelectedItem?.ToString();
            string selectedDay = cmbB_filterDay.SelectedItem?.ToString(); // ✅ NEW
            string searchTerm = txtB_searchBar.Text;

            if (string.IsNullOrEmpty(selectedSpecialty)) return;

            LoadTodaysPatients(selectedSpecialty, searchTerm, selectedStatus);

            // ✅ Start from ALL patients
            _filteredPatients = new List<TodaysPatientRow>(_allPatients);

            // ✅ Apply STATUS filter
            if (!string.IsNullOrWhiteSpace(selectedStatus) && selectedStatus != "All")
            {
                _filteredPatients = _filteredPatients
                    .Where(p => p.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // ✅ Apply DAY filter ONLY when status = "To Pay"
            if (!string.IsNullOrWhiteSpace(selectedStatus) &&
                selectedStatus.Equals("To Pay", StringComparison.OrdinalIgnoreCase) &&
                !string.IsNullOrWhiteSpace(selectedDay))
            {
                DateTime today = DateTime.Today;

                _filteredPatients = selectedDay.ToLower() switch
                {
                    "today" => _filteredPatients
                        .Where(p => DateTime.Parse(p.Date).Date == today)
                        .ToList(),

                    "past" => _filteredPatients
                        .Where(p => DateTime.Parse(p.Date).Date < today)
                        .ToList(),

                    _ => _filteredPatients
                };
            }

            ApplySearchAndPagination();
        }

        private void UpdateCountDisplay()
        {
            int waitingCount = _filteredPatients.Count(p =>
                p.Status.Equals("Waiting", StringComparison.OrdinalIgnoreCase));

            lbl_patientsInLine.Text = waitingCount.ToString();
            lbl_patientsInLine.ForeColor = (waitingCount > 10) ? Color.Red : Color.Black;
        }

        private void roundedDataGridView_Load(object sender, EventArgs e)
        {
            dtgView_todaysPatients.Grid.Columns.Clear();

            var idCol = new DataGridViewTextBoxColumn();
            idCol.Name = "QueueID";
            idCol.Visible = false;
            dtgView_todaysPatients.Grid.Columns.Add(idCol);

            var pIdCol = new DataGridViewTextBoxColumn();
            pIdCol.Name = "PatientID";
            pIdCol.Visible = false;
            dtgView_todaysPatients.Grid.Columns.Add(pIdCol);

            dtgView_todaysPatients.Grid.Columns.Add("QueueNumber", "Queue Number");
            dtgView_todaysPatients.Grid.Columns.Add("PatientName", "Patient Name");
            dtgView_todaysPatients.Grid.Columns.Add("Date", "Date");
            dtgView_todaysPatients.Grid.Columns.Add("ArrivalTime", "Arrival Time");
            dtgView_todaysPatients.Grid.Columns.Add("AssignedDoctor", "Assigned Doctor");
            dtgView_todaysPatients.Grid.Columns.Add("Specialty", "Specialty");
            dtgView_todaysPatients.Grid.Columns.Add("RoomNumber", "Room Number");
            dtgView_todaysPatients.Grid.Columns.Add("Status", "Status");
            dtgView_todaysPatients.Grid.Columns.Add("PaymentFee", "Payment Fee");
            dtgView_todaysPatients.Grid.Columns["PaymentFee"].Visible = false;

            if (cmbB_filterSpecialty.Items.Count > 0)
            {
                string firstSpec = cmbB_filterSpecialty.Items[0].ToString();
                LoadTodaysPatients(firstSpec, "", cmbB_filterStatus.SelectedItem?.ToString());
            }
        }

        private string GetPrefix(string specialty)
        {
            return specialty switch
            {
                "General Medicine" => "GC",
                "Pediatrics" => "PD",
                "OB-Gyne" => "OBG",
                "Internal Medicine" => "IM",
                "Dermatology" => "DM",
                "Orthopedics" => "ORT",
                _ => "QT"
            };
        }

        private void btn_checkupForm_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new PatientsCheckUpForm());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ConfirmActionDialog dialog = new ConfirmActionDialog();
            dialog.setResult("Are you sure you want to Logout?");
            DialogResult result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                MainForm.Instance.OpenChildForm(new LoginForm());
            }
        }

        private void dtgView_todaysPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgView_todaysPatients.Grid.SelectedRows.Count > 0)
            {
                var row = dtgView_todaysPatients.Grid.SelectedRows[0];
                string status = row.Cells["Status"].Value?.ToString() ?? "";

                bool isWaiting = status.Equals("Waiting", StringComparison.OrdinalIgnoreCase);
                bool isToPay = status.Equals("To Pay", StringComparison.OrdinalIgnoreCase);

                bttn_markIn.Enabled = isWaiting;
                bttn_callQueuingNumber.Enabled = isWaiting;
                bttn_cancel.Enabled = isWaiting;

                bttn_paid.Enabled = isToPay;
            }
            else
            {
                bttn_markIn.Enabled = false;
                bttn_callQueuingNumber.Enabled = false;
                bttn_cancel.Enabled = false;
                bttn_paid.Enabled = false;
            }
        }

        private void btn_missedCheckups_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new MissedCheckups());
        }

        private void btn_pastRecords_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        }

        private void btn_schedAndFee_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new SchedAndFee());
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new EditNurseProfile());
        }

        private void txtB_searchBar_Load(object sender, EventArgs e)
        {
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            txtB_searchBar.Text = "";

            if (cmbB_filterSpecialty.Items.Count > 0)
                cmbB_filterSpecialty.SelectedIndex = 0;

            _currentPage = 1;
            PerformSearchAndFilter();
        }

        private SpeechSynthesizer clinicVoice = new SpeechSynthesizer();

        private void bttn_callQueuingNumber_Click(object sender, EventArgs e)
        {
            if (dtgView_todaysPatients.Grid.SelectedRows.Count > 0)
            {
                var selectedRow = dtgView_todaysPatients.Grid.SelectedRows[0];
                string status = selectedRow.Cells["Status"].Value.ToString();

                if (!status.Equals("Waiting", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Cannot call this patient. Current status is '{status}'.", "Action Denied");
                    return;
                }

                string queueNumber = dtgView_todaysPatients.Grid.SelectedRows[0].Cells[2].Value.ToString();
                string patientName = dtgView_todaysPatients.Grid.SelectedRows[0].Cells[3].Value.ToString();
                try
                {
                    clinicVoice.SpeakAsyncCancelAll();
                    clinicVoice.SelectVoiceByHints(VoiceGender.Female);
                    clinicVoice.Volume = 100;
                    clinicVoice.Rate = -2;

                    string announcement = $"Now calling, ticket number, {queueNumber.Replace("-", " ")}, {patientName}, please proceed to the front desk.";

                    clinicVoice.SpeakAsync(announcement);

                    MessageBox.Show($"Currently Calling: {queueNumber}\nPatient: {patientName}", "VitalHealth Calling");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Speech Error: " + ex.Message);
                }
            }
        }

        private void bttn_markIn_Click(object sender, EventArgs e)
        {
            if (dtgView_todaysPatients.Grid.SelectedRows.Count > 0)
            {
                var selectedRow = dtgView_todaysPatients.Grid.SelectedRows[0];
                string status = selectedRow.Cells["Status"].Value.ToString();

                if (!status.Equals("Waiting", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Only patients with 'Waiting' status can be marked as Ongoing.", "Invalid Action");
                    return;
                }

                string qId = selectedRow.Cells["QueueID"].Value.ToString();
                string patientName = selectedRow.Cells["PatientName"].Value.ToString();

                var db = new VitalHealth.Data.DBConnection();
                using var conn = db.GetConnection();

                try
                {
                    conn.Open();

                    // ✅ STEP 1: Get the doctor assigned to this queue entry
                    string getDoctorSql = @"
                SELECT pq.doctor_id, 
                       CONCAT('Dr. ', up.first_name, ' ', up.last_name) AS DoctorName
                FROM patient_queue pq
                JOIN user_profile up ON pq.doctor_id = up.user_id
                WHERE pq.queue_id = @qid";

                    int doctorId = 0;
                    string doctorName = "";

                    using (var getDocCmd = new MySqlCommand(getDoctorSql, conn))
                    {
                        getDocCmd.Parameters.AddWithValue("@qid", qId);
                        using var reader = getDocCmd.ExecuteReader();
                        if (reader.Read())
                        {
                            doctorId = Convert.ToInt32(reader["doctor_id"]);
                            doctorName = reader["DoctorName"].ToString();
                        }
                    }

                    // ✅ STEP 2: Check if that doctor already has an on-going patient TODAY
                    string checkOngoingSql = @"
                SELECT COUNT(*) 
                FROM patient_queue 
                WHERE doctor_id = @docId 
                  AND queue_status_id = 2 
                  AND DATE(queued_at) = CURDATE()";

                    using (var checkCmd = new MySqlCommand(checkOngoingSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@docId", doctorId);
                        int ongoingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (ongoingCount > 0)
                        {
                            MessageBox.Show(
                                $"{doctorName} already has a patient currently on-going.\n\n" +
                                $"Please wait until the current session is finished before marking in another patient.",
                                "Doctor Unavailable",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return; // ❌ Block the mark-in
                        }
                    }

                    // ✅ STEP 3: Safe to proceed — no on-going patient for this doctor
                    string sql = "UPDATE patient_queue SET queue_status_id = 2 WHERE queue_id = @qid";
                    using var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@qid", qId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"{patientName} is now checked in.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PerformSearchAndFilter();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateQueueStatus(string queueId, int newStatusId)
        {
            var db = new VitalHealth.Data.DBConnection();
            using var conn = db.GetConnection();

            string sql = "UPDATE patient_queue SET queue_status_id = @status WHERE queue_id = @qid";

            try
            {
                conn.Open();
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", newStatusId);
                cmd.Parameters.AddWithValue("@qid", queueId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void bttn_cancel_Click(object sender, EventArgs e)
        {
            if (dtgView_todaysPatients.Grid.SelectedRows.Count > 0)
            {
                var selectedRow = dtgView_todaysPatients.Grid.SelectedRows[0];
                string status = selectedRow.Cells["Status"].Value.ToString();

                if (!status.Equals("Waiting", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("You can only cancel/hold patients who are currently 'Waiting'.", "Action Denied");
                    return;
                }

                string qId = selectedRow.Cells["QueueID"].Value.ToString();
                string patientName = selectedRow.Cells["PatientName"].Value.ToString();

                DialogResult confirm = MessageBox.Show($"Are you sure you want to put {patientName} on hold?",
                    "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    var db = new VitalHealth.Data.DBConnection();
                    using var conn = db.GetConnection();

                    try
                    {
                        conn.Open();
                        string sql = "UPDATE patient_queue SET queue_status_id = 3 WHERE queue_id = @qid";

                        using var cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@qid", qId);
                        cmd.ExecuteNonQuery();

                        PerformSearchAndFilter();
                        MessageBox.Show($"{patientName} has been moved to On-hold.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating status: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a patient to cancel/put on-hold.");
            }
        }

        private void bttn_edit_Click(object sender, EventArgs e)
        {
            if (dtgView_todaysPatients.Grid.SelectedRows.Count > 0)
            {
                var row = dtgView_todaysPatients.Grid.SelectedRows[0];

                int qId = Convert.ToInt32(row.Cells["QueueID"].Value);
                int pId = Convert.ToInt32(row.Cells["PatientID"].Value);

                MainForm.Instance.OpenChildForm(new EditPatientsRecord(pId, qId));
            }
            else
            {
                MessageBox.Show("Please select a patient to edit.");
            }
        }

        private void bttn_paid_Click(object sender, EventArgs e)
        {
            if (dtgView_todaysPatients.Grid.SelectedRows.Count > 0)
            {
                var selectedRow = dtgView_todaysPatients.Grid.SelectedRows[0];
                string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";

                if (!status.Equals("To Pay", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This action is only available for patients with a 'To Pay' status.", "Action Denied");
                    return;
                }

                string qId = selectedRow.Cells["QueueID"].Value.ToString();
                string patientName = selectedRow.Cells["PatientName"].Value.ToString();

                // ⚠️ Adjust this column name if yours is different
                decimal paymentFee = Convert.ToDecimal(selectedRow.Cells["PaymentFee"].Value);

                var db = new VitalHealth.Data.DBConnection();
                using var conn = db.GetConnection();

                try
                {
                    conn.Open();

                    using var transaction = conn.BeginTransaction();

                    // 1. Update queue status
                    string updateSql = "UPDATE patient_queue SET queue_status_id = 5 WHERE queue_id = @qid";

                    using (var cmd = new MySqlCommand(updateSql, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@qid", qId);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Insert payment record
                    string insertSql = @"
                    INSERT INTO patient_payment_data (queue_id, payment_fee, payment_at)
                    VALUES (@qid, @fee, NOW())";

                    using (var cmd = new MySqlCommand(insertSql, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@qid", qId);
                        cmd.Parameters.AddWithValue("@fee", paymentFee);
                        cmd.Parameters.AddWithValue("@time", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show($"Payment confirmed for {patientName}.", "Success");
                    PerformSearchAndFilter();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing payment: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a patient first.");
            }
        }



        private void bttn_pastRecords_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        }

        private void bttn_missedCheckups_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new MissedCheckups());
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private class TodaysPatientRow
        {
            public int QueueID { get; set; }
            public int PatientID { get; set; }
            public string QueueNumber { get; set; } = "";
            public string PatientName { get; set; } = "";
            public string Date { get; set; } = "";
            public string ArrivalTime { get; set; } = "";
            public string AssignedDoctor { get; set; } = "";
            public string Specialty { get; set; } = "";
            public string RoomNumber { get; set; } = "";
            public string Status { get; set; } = "";

            public decimal PaymentFee { get; set; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _patientHistoryExpanded = !_patientHistoryExpanded;

            btn_patientHistory.Text = _patientHistoryExpanded
                ? "Patient History  ▲"
                : "Patient History  ▼";

            btn_pastRecords.Visible = _patientHistoryExpanded;
            btn_missedCheckups.Visible = _patientHistoryExpanded;

            btn_pastRecords.BringToFront();
            btn_missedCheckups.BringToFront();
        }

        private void cmbB_filterSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            PerformSearchAndFilter();
        }

        private void cmbB_filterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;

            string selectedStatus = cmbB_filterStatus.SelectedItem?.ToString();

            bool isToPay = selectedStatus == "To Pay";

            cmbB_filterDay.Visible = isToPay;

            // ✅ AUTO SELECT "Today" when shown
            if (isToPay)
            {
                if (cmbB_filterDay.Items.Count > 0)
                    cmbB_filterDay.SelectedIndex = 0; // assumes "Today" is first
            }

            PerformSearchAndFilter();
        }

        private void cmbB_filterDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            PerformSearchAndFilter();
        }
    }
}