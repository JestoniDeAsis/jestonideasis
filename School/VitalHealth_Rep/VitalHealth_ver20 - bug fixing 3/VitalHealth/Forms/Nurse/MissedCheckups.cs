using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Data;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;
using VitalHealth.Shared;

namespace VitalHealth.Forms.Nurse
{
    public partial class MissedCheckups : Form
    {
        private const int PageSize = 10;

        private DataTable _allMissedPatients = new DataTable();
        private DataTable _filteredMissedPatients = new DataTable();

        private int _currentPage = 1;
        private int _totalPages = 1;

        private int _selectedQueueId = 0;
        private int _selectedPatientId = 0;

        private bool _patientHistoryExpanded = false;



        public MissedCheckups()
        {
            InitializeComponent();

            btn_pastRecords.Visible = false;
            btn_missedCheckups.Visible = false;
            button3.Text = "Patient History  ▼"; // ✅ default state

            this.Shown += MissedCheckups_Shown;
            WireUpCustomEvents();
        }

        private void WireUpCustomEvents()
        {
            bttn_viewRecord.Click += bttn_viewRecord_Click;

            backArrowDG.Click += backArrowDG_Click;
            nextArrowDG.Click += nextArrowDG_Click;

            page1DG.Click += PageLabel_Click;
            page2DG.Click += PageLabel_Click;
            page3DG.Click += PageLabel_Click;
            page4DG.Click += PageLabel_Click;
            page5DG.Click += PageLabel_Click;
        }

        private void MissedCheckups_Shown(object sender, EventArgs e)
        {
            lbl_nurseLastName.Text = MainForm.loggedInUserLastname;

            if (!cmbB_filterSpecialty.Items.Contains("All"))
            {
                cmbB_filterSpecialty.Items.Insert(0, "All");
            }

            AttachLiveSearch(txtB_searchBar);
            ConfigureMissedCheckupsGrid();

            cmbB_filterSpecialty.SelectedIndex = 0;
            PerformSearchAndFilter();
        }

        private void ConfigureMissedCheckupsGrid()
        {
            var grid = dgv_missedCheckups.Grid;

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;

            grid.SelectionChanged -= MissedCheckupsGrid_SelectionChanged;
            grid.CellClick -= MissedCheckupsGrid_CellClick;
            grid.CellMouseUp -= MissedCheckupsGrid_CellMouseUp;
            grid.CurrentCellChanged -= MissedCheckupsGrid_CurrentCellChanged;

            grid.SelectionChanged += MissedCheckupsGrid_SelectionChanged;
            grid.CellClick += MissedCheckupsGrid_CellClick;
            grid.CellMouseUp += MissedCheckupsGrid_CellMouseUp;
            grid.CurrentCellChanged += MissedCheckupsGrid_CurrentCellChanged;
        }

        private void AttachLiveSearch(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                {
                    tb.TextChanged -= SearchTextBox_TextChanged;
                    tb.TextChanged += SearchTextBox_TextChanged;
                }

                if (c.HasChildren)
                    AttachLiveSearch(c);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            PerformSearchAndFilter();
        }

        private void PerformSearchAndFilter()
        {
            string searchTerm = GetTextRecursively(txtB_searchBar);
            string specialty = cmbB_filterSpecialty.SelectedItem?.ToString() ?? "All";

            LoadMissedPatients(searchTerm, specialty);
            ApplyPagination();
        }

        private string GetTextRecursively(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox tb)
                    return tb.Text.Trim();

                if (c.HasChildren)
                {
                    string res = GetTextRecursively(c);
                    if (!string.IsNullOrEmpty(res))
                        return res;
                }
            }

            return "";
        }

        private void LoadMissedPatients(string searchTerm = "", string specialtyFilter = "All")
        {
            var db = new DBConnection();
            using var conn = db.GetConnection();

            string sql = @"
                SELECT 
                    pq.queue_id, 
                    pq.patient_id, 
                    pq.doctor_id, 
                    pq.queue_number AS 'Queue Number', 
                    TRIM(
                        CONCAT(
                            IFNULL(pd.first_name, ''),
                            CASE
                                WHEN pd.middle_name IS NULL OR pd.middle_name = '' OR pd.middle_name = 'N/A' THEN ''
                                ELSE CONCAT(' ', pd.middle_name)
                            END,
                            CASE
                                WHEN pd.last_name IS NULL OR pd.last_name = '' OR pd.last_name = 'N/A' THEN ''
                                ELSE CONCAT(' ', pd.last_name)
                            END,
                            CASE
                                WHEN pd.name_suffix IS NULL OR pd.name_suffix = '' OR pd.name_suffix = 'N/A' THEN ''
                                ELSE CONCAT(' ', pd.name_suffix)
                            END
                        )
                    ) AS 'Patient Name',
                    pd.sex AS 'Sex',
                    TIMESTAMPDIFF(YEAR, pd.birthdate, CURDATE()) AS 'Age',
                    pq.queued_at AS 'QueuedAtRaw',
                    DATE_FORMAT(pq.queued_at, '%Y-%m-%d %h:%i %p') AS 'Checkup Date',
                    CONCAT('Dr. ', up.first_name, ' ', up.last_name) AS 'Doctor Name', 
                    ds.specialty_name AS 'Specialty', 
                    qs.status_name AS 'Status', 
                    IFNULL(CAST(ra.room_id AS CHAR), 'TBA') AS 'Room' 
                FROM patient_queue pq 
                JOIN patient_data pd ON pq.patient_id = pd.patient_id 
                JOIN user_profile up ON pq.doctor_id = up.user_id 
                JOIN doctor_specialty dsl ON up.user_id = dsl.user_id 
                JOIN doctor_specialties ds ON dsl.specialty_id = ds.specialty_id 
                JOIN queue_status qs ON pq.queue_status_id = qs.queue_status_id 
                LEFT JOIN room_assignment ra ON pq.doctor_id = ra.doctor_id 
                WHERE pq.queue_status_id = 3";

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                sql += @" AND (
                            pd.first_name LIKE @search OR 
                            pd.middle_name LIKE @search OR
                            pd.last_name LIKE @search OR
                            pd.name_suffix LIKE @search OR
                            CONCAT_WS(' ', pd.first_name, pd.middle_name, pd.last_name, pd.name_suffix) LIKE @search OR
                            pq.queue_number LIKE @search
                         )";
            }

            if (specialtyFilter != "All")
            {
                sql += " AND ds.specialty_name = @spec";
            }

            sql += " ORDER BY pq.queued_at DESC";

            try
            {
                conn.Open();
                using MySqlCommand cmd = new MySqlCommand(sql, conn);

                if (!string.IsNullOrWhiteSpace(searchTerm))
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                if (specialtyFilter != "All")
                    cmd.Parameters.AddWithValue("@spec", specialtyFilter);

                using MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                _allMissedPatients = new DataTable();
                adapter.Fill(_allMissedPatients);

                _filteredMissedPatients = _allMissedPatients.Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading missed patients: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _allMissedPatients = new DataTable();
                _filteredMissedPatients = new DataTable();
            }
        }

        private void ApplyPagination()
        {
            int rowCount = _filteredMissedPatients.Rows.Count;
            _totalPages = Math.Max(1, (int)Math.Ceiling(rowCount / (double)PageSize));

            if (_currentPage > _totalPages)
                _currentPage = _totalPages;

            if (_currentPage < 1)
                _currentPage = 1;

            LoadCurrentPageToGrid();
            UpdatePaginationUI();
            ClearSelectedPatient();
        }

        private void LoadCurrentPageToGrid()
        {
            var grid = dgv_missedCheckups.Grid;

            DataTable pageTable = _filteredMissedPatients.Clone();

            var pageRows = _filteredMissedPatients.AsEnumerable()
                .Skip((_currentPage - 1) * PageSize)
                .Take(PageSize);

            foreach (var row in pageRows)
            {
                pageTable.ImportRow(row);
            }

            grid.DataSource = null;
            grid.DataSource = pageTable;

            string[] columnsToHide = { "queue_id", "patient_id", "doctor_id", "QueuedAtRaw" };
            foreach (string colName in columnsToHide)
            {
                if (grid.Columns.Contains(colName))
                    grid.Columns[colName].Visible = false;
            }

            grid.ClearSelection();
            grid.CurrentCell = null;
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

        private void ClearSelectedPatient()
        {
            _selectedQueueId = 0;
            _selectedPatientId = 0;

            if (bttn_viewRecord != null)
                bttn_viewRecord.Enabled = false;
        }

        private void UpdateSelectedPatientFromGrid()
        {
            var grid = dgv_missedCheckups.Grid;

            if (grid.CurrentRow != null)
            {
                DataGridViewRow row = grid.CurrentRow;

                if (row.Cells["queue_id"]?.Value != null &&
                    row.Cells["patient_id"]?.Value != null)
                {
                    _selectedQueueId = Convert.ToInt32(row.Cells["queue_id"].Value);
                    _selectedPatientId = Convert.ToInt32(row.Cells["patient_id"].Value);
                    bttn_viewRecord.Enabled = true;
                    return;
                }
            }

            if (grid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grid.SelectedRows[0];

                if (row.Cells["queue_id"]?.Value != null &&
                    row.Cells["patient_id"]?.Value != null)
                {
                    _selectedQueueId = Convert.ToInt32(row.Cells["queue_id"].Value);
                    _selectedPatientId = Convert.ToInt32(row.Cells["patient_id"].Value);
                    bttn_viewRecord.Enabled = true;
                    return;
                }
            }

            ClearSelectedPatient();
        }

        private void MissedCheckupsGrid_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedPatientFromGrid();
        }

        private void MissedCheckupsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var grid = dgv_missedCheckups.Grid;
                grid.Rows[e.RowIndex].Selected = true;
                grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                UpdateSelectedPatientFromGrid();
            }
        }

        private void MissedCheckupsGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateSelectedPatientFromGrid();
            }
        }

        private void MissedCheckupsGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            UpdateSelectedPatientFromGrid();
        }

        private void bttn_viewRecord_Click(object sender, EventArgs e)
        {
            UpdateSelectedPatientFromGrid();

            if (_selectedQueueId <= 0 || _selectedPatientId <= 0)
            {
                MessageBox.Show("Please select a patient first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PatientRecordContext.SelectedQueueId = _selectedQueueId;
            PatientRecordContext.SelectedPatientId = _selectedPatientId;

            MainForm.Instance.OpenChildForm(new MissedCheckupViewRecord());
        }

        private void backArrowDG_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadCurrentPageToGrid();
                UpdatePaginationUI();
                ClearSelectedPatient();
            }
        }

        private void nextArrowDG_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                LoadCurrentPageToGrid();
                UpdatePaginationUI();
                ClearSelectedPatient();
            }
        }

        private void PageLabel_Click(object sender, EventArgs e)
        {
            // Intentionally empty because page labels are only indicators, not clickable
        }

        private void cmbB_filterSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            PerformSearchAndFilter();
        }

        private void bttn_restore_Click(object sender, EventArgs e)
        {
            if (dgv_missedCheckups.Grid.CurrentRow == null) return;
            var row = dgv_missedCheckups.Grid.CurrentRow;

            int qId = Convert.ToInt32(row.Cells["queue_id"].Value);
            int dId = Convert.ToInt32(row.Cells["doctor_id"].Value);
            string specialty = row.Cells["Specialty"].Value.ToString();

            var db = new DBConnection();
            using var conn = db.GetConnection();

            try
            {
                conn.Open();

                // ✅ STEP 1: Get doctor's name and shift end time
                string getDoctorSql = @"
            SELECT CONCAT('Dr. ', first_name, ' ', last_name) AS DoctorName,
                   working_time_end
            FROM user_profile
            WHERE user_id = @did";

                string doctorName = "";
                TimeSpan workingEnd;

                using (var docCmd = new MySqlCommand(getDoctorSql, conn))
                {
                    docCmd.Parameters.AddWithValue("@did", dId);
                    using var reader = docCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        doctorName = reader["DoctorName"].ToString();
                        workingEnd = (TimeSpan)reader["working_time_end"];
                    }
                    else
                    {
                        MessageBox.Show("Could not find the assigned doctor.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // ✅ STEP 2: Block restore if doctor's shift is already over
                TimeSpan currentTime = DateTime.Now.TimeOfDay;

                if (currentTime > workingEnd)
                {
                    string formattedEnd = DateTime.Today.Add(workingEnd).ToString("hh:mm tt");

                    MessageBox.Show(
                        $"Cannot restore this patient.\n\n" +
                        $"{doctorName} has already finished their shift at {formattedEnd}.\n\n" +
                        $"The ticket can no longer be reactivated for today's session.",
                        "Doctor Unavailable",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return; // ❌ Block the restore
                }

                // ✅ STEP 3: Safe to restore — generate new queue number and update
                using var trans = conn.BeginTransaction();
                string newNum = GenerateDailyQueueNumber(GetPrefix(specialty), dId, conn, trans);

                string sql = @"UPDATE patient_queue 
                       SET queue_status_id = 1, queue_number = @qnum, queued_at = NOW() 
                       WHERE queue_id = @qid";

                using var cmd = new MySqlCommand(sql, conn, trans);
                cmd.Parameters.AddWithValue("@qnum", newNum);
                cmd.Parameters.AddWithValue("@qid", qId);
                cmd.ExecuteNonQuery();

                trans.Commit();

                PrintTicket(newNum, specialty);
                MessageBox.Show($"Patient restored with ticket: {newNum}", "Restored",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                PerformSearchAndFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Restore Error: " + ex.Message);
            }
        }

        private void PrintTicket(string qn, string sp)
        {
            // ESC/POS GS ! n  →  n = (heightMag << 4) | widthMag
            // heightMag / widthMag: 0=1x, 1=2x, 2=3x, ..., 7=8x
            const int heightMag = 7; // 8× height (maximum)
            const int widthMag = 0; // ✅ 1× width — normal, never wraps
            char sizeCmd = (char)((heightMag << 4) | widthMag);  // 0x70
            char resetCmd = (char)0x00;

            try
            {
                StringBuilder sb = new StringBuilder();

                // Header
                sb.AppendLine("\x1B\x40"
                            + "\x1B\x61\x01"
                            + "VITAL HEALTH CLINIC");
                sb.AppendLine("--------------------------");

                // Queue number — tall only, stays on 1 line
                sb.Append('\x1D');
                sb.Append('\x21');
                sb.Append(sizeCmd);  // 0x70 = height 8×, width 1×
                sb.Append(qn);
                sb.Append('\x1D');
                sb.Append('\x21');
                sb.Append(resetCmd);
                sb.AppendLine();

                // Footer
                sb.AppendLine("--------------------------");
                sb.AppendLine("Specialty: " + sp);
                sb.AppendLine("Date: " + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                sb.AppendLine("Surrender ticket when called");
                sb.AppendLine("\n\n\n\x1B\x69");

                RawPrinterHelper.SendStringToPrinter("POS-58", sb.ToString());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"PrintTicket error: {ex.Message}");
            }
        }

        private string GenerateDailyQueueNumber(string prefix, int doctorId, MySqlConnection conn, MySqlTransaction trans)
        {
            string sql = "SELECT IFNULL(MAX(CAST(SUBSTRING_INDEX(queue_number, '-', -1) AS UNSIGNED)), 0) FROM patient_queue WHERE doctor_id = @did AND DATE(queued_at) = CURDATE()";
            using var cmd = new MySqlCommand(sql, conn, trans);
            cmd.Parameters.AddWithValue("@did", doctorId);
            return $"{prefix}-{(Convert.ToInt32(cmd.ExecuteScalar()) + 1):D3}";
        }

        private string GetPrefix(string specialty) => specialty switch
        {
            "General Medicine" => "GC",
            "Pediatrics" => "PD",
            "OB-Gyne" => "OBG",
            "Internal Medicine" => "IM",
            "Dermatologist" => "DM",
            "Orthopedics" => "ORT",
            _ => "QT"
        };

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            foreach (Control c in txtB_searchBar.Controls)
            {
                if (c is TextBox tb) tb.Text = "";
                else if (c.HasChildren)
                {
                    foreach (Control child in c.Controls)
                    {
                        if (child is TextBox ntb) ntb.Text = "";
                    }
                }
            }

            _currentPage = 1;
            cmbB_filterSpecialty.SelectedIndex = 0;
            PerformSearchAndFilter();
        }

        private void btn_patientHistory_Click(object sender, EventArgs e)
        {
            _patientHistoryExpanded = !_patientHistoryExpanded;

            // Show/hide the sub-buttons
            btn_pastRecords.Visible = _patientHistoryExpanded;
            btn_missedCheckups.Visible = _patientHistoryExpanded;

            // Optional: visually indicate expanded state with an arrow
            // If your button has text:
            // btn_patientHistory.Text = _patientHistoryExpanded 
            //     ? "⏷ Patient History" 
            //     : "⏵ Patient History";
        }

        private void btn_pastRecords_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        }

        private void bttn_missedCheckups_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new MissedCheckups());
        }

        private void btn_checkupForm_Click(object sender, EventArgs e) => MainForm.Instance.OpenChildForm(new PatientsCheckUpForm());
        private void btn_todaysPatient_Click(object sender, EventArgs e) => MainForm.Instance.OpenChildForm(new TodaysPatients());
        private void btn_schedAndFee_Click(object sender, EventArgs e) => MainForm.Instance.OpenChildForm(new SchedAndFee());
        private void btn_editProfile_Click(object sender, EventArgs e) => MainForm.Instance.OpenChildForm(new EditNurseProfile());

        private void btn_logout_Click(object sender, EventArgs e)
        {
            ConfirmActionDialog dialog = new ConfirmActionDialog();
            dialog.setResult("Logout?");
            if (dialog.ShowDialog(this) == DialogResult.OK)
                MainForm.Instance.OpenChildForm(new LoginForm());
        }

        private void txtB_searchBar_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void dgv_missedCheckups_Load(object sender, EventArgs e) { }
        private void txtB_searchBar_Load_1(object sender, EventArgs e) { }
        private void bttn_search_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            PerformSearchAndFilter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _patientHistoryExpanded = !_patientHistoryExpanded;

            button3.Text = _patientHistoryExpanded
                ? "Patient History  ▲"
                : "Patient History  ▼";

            btn_pastRecords.Visible = _patientHistoryExpanded;
            btn_missedCheckups.Visible = _patientHistoryExpanded;

            btn_pastRecords.BringToFront();
            btn_missedCheckups.BringToFront();
        }

        private void bttn_pastRecords_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        }

        private void btn_missedCheckups_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new MissedCheckups());
        }
    }
}