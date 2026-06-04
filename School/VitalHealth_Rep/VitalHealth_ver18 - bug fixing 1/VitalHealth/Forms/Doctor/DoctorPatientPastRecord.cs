using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;
using VitalHealth.Shared;

namespace VitalHealth.Forms.Doctor
{
    public partial class DoctorPatientPastRecord : Form
    {
        private readonly List<PastRecordRow> _records = new List<PastRecordRow>();
        private List<PastRecordRow> _filteredRecords = new List<PastRecordRow>();

        public DoctorPatientPastRecord()
        {
            InitializeComponent();
        }

        private void PatientPastRecord_Load(object sender, EventArgs e)
        {
            lbl_doctorLastName.Text = MainForm.loggedInUserLastname;

            ConfigureGrid();
            LoadPastRecordsFromDatabase();
            LoadToGrid();
        }

        private void ConfigureGrid()
        {
            var grid = pastRecordDataGrid.Grid;

            grid.Columns.Clear();
            grid.Rows.Clear();

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;

            grid.Columns.Add("QueueId", "Queue ID");
            grid.Columns["QueueId"].Visible = false;

            grid.Columns.Add("PatientId", "Patient ID");
            grid.Columns["PatientId"].Visible = false;

            grid.Columns.Add("RecordId", "Record ID");
            grid.Columns["RecordId"].Visible = false;

            grid.Columns.Add("PatientName", "Patient Name");
            grid.Columns.Add("Sex", "Sex");
            grid.Columns.Add("Age", "Age");
            grid.Columns.Add("CheckupDate", "Date");
            grid.Columns.Add("AssignedDoctor", "Assigned Doctor");
            grid.Columns.Add("Specialty", "Specialty");
            grid.Columns.Add("RoomNumber", "Room");
        }

        private void LoadPastRecordsFromDatabase()
        {
            _records.Clear();

            var db = new VitalHealth.Data.DBConnection();
            using var conn = db.GetConnection();

            try
            {
                conn.Open();

                string sql = @"
                SELECT
                    pq.queue_id,
                    pd.patient_id,
                    pr.record_id,

                    TRIM(
                        CONCAT(
                            pd.first_name,
                            CASE 
                                WHEN pd.middle_name IS NULL OR pd.middle_name = '' OR pd.middle_name = 'N/A' THEN ''
                                ELSE CONCAT(' ', pd.middle_name)
                            END,
                            ' ',
                            pd.last_name,
                            CASE
                                WHEN pd.name_suffix IS NULL OR pd.name_suffix = '' OR pd.name_suffix = 'N/A' THEN ''
                                ELSE CONCAT(' ', pd.name_suffix)
                            END
                        )
                    ) AS patient_name,

                    pd.sex,
                    TIMESTAMPDIFF(YEAR, pd.birthdate, CURDATE()) AS computed_age,
                    pq.queued_at,

                    TRIM(
                        CONCAT(
                            'Dr. ',
                            up.first_name,
                            CASE 
                                WHEN up.middle_name IS NULL OR up.middle_name = '' THEN ''
                                ELSE CONCAT(' ', up.middle_name)
                            END,
                            ' ',
                            up.last_name,
                            CASE
                                WHEN up.name_suffix IS NULL OR up.name_suffix = '' THEN ''
                                ELSE CONCAT(' ', up.name_suffix)
                            END
                        )
                    ) AS doctor_name,

                    IFNULL(ds.specialty_name, 'N/A') AS specialty_name,
                    IFNULL(CAST(ra.room_id AS CHAR), 'TBA') AS room_number

                FROM patient_records pr
                INNER JOIN patient_queue pq ON pr.queue_id = pq.queue_id
                INNER JOIN patient_data pd ON pq.patient_id = pd.patient_id
                INNER JOIN user_profile up ON pq.doctor_id = up.user_id
                LEFT JOIN doctor_specialty dspec ON up.user_id = dspec.user_id
                LEFT JOIN doctor_specialties ds ON dspec.specialty_id = ds.specialty_id
                LEFT JOIN room_assignment ra ON pq.doctor_id = ra.doctor_id

                WHERE pq.queue_status_id = 5

                ORDER BY pq.queued_at DESC, pr.record_id DESC;";

                using var cmd = new MySqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    _records.Add(new PastRecordRow
                    {
                        QueueId = Convert.ToInt32(reader["queue_id"]),
                        PatientId = Convert.ToInt32(reader["patient_id"]),
                        RecordId = Convert.ToInt32(reader["record_id"]),
                        PatientName = reader["patient_name"]?.ToString() ?? "",
                        Sex = reader["sex"]?.ToString() ?? "",
                        Age = Convert.ToInt32(reader["computed_age"]),
                        CheckupDate = Convert.ToDateTime(reader["queued_at"]),
                        AssignedDoctor = reader["doctor_name"]?.ToString() ?? "",
                        Specialty = reader["specialty_name"]?.ToString() ?? "",
                        RoomNumber = reader["room_number"]?.ToString() ?? ""
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }
        }

        private void LoadToGrid()
        {
            var grid = pastRecordDataGrid.Grid;
            grid.Rows.Clear();

            foreach (var r in _records)
            {
                grid.Rows.Add(
                    r.QueueId,
                    r.PatientId,
                    r.RecordId,
                    r.PatientName,
                    r.Sex,
                    r.Age,
                    r.CheckupDate.ToString("yyyy-MM-dd hh:mm tt"),
                    r.AssignedDoctor,
                    r.Specialty,
                    r.RoomNumber
                );
            }

            grid.ClearSelection();
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

        private void btn_assignedPatients_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorAssignedPatients());
        }

        private void btn_scheduleAndFee_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorSchedule());
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorEditProfile());
        }

        private class PastRecordRow
        {
            public int QueueId { get; set; }
            public int PatientId { get; set; }
            public int RecordId { get; set; }
            public string PatientName { get; set; } = "";
            public string Sex { get; set; } = "";
            public int Age { get; set; }
            public DateTime CheckupDate { get; set; }
            public string AssignedDoctor { get; set; } = "";
            public string Specialty { get; set; } = "";
            public string RoomNumber { get; set; } = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchValue = txtBox_search.Text.Trim().ToLower();

            _filteredRecords = _records
                .Where(r =>
                    string.IsNullOrWhiteSpace(searchValue) ||
                    r.PatientName.ToLower().Contains(searchValue) ||
                    r.QueueId.ToString().Contains(searchValue))
                .ToList();

            LoadFilteredToGrid();
        }

        private void LoadFilteredToGrid()
        {
            var grid = pastRecordDataGrid.Grid;
            grid.Rows.Clear();

            foreach (var r in _filteredRecords)
            {
                grid.Rows.Add(
                    r.QueueId,
                    r.PatientId,
                    r.RecordId,
                    r.PatientName,
                    r.Sex,
                    r.Age,
                    r.CheckupDate.ToString("yyyy-MM-dd hh:mm tt"),
                    r.AssignedDoctor,
                    r.Specialty,
                    r.RoomNumber
                );
            }

            grid.ClearSelection();
        }

        private void btn_viewRecord_Click(object sender, EventArgs e)
        {
            var grid = pastRecordDataGrid.Grid;

            if (grid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record first.");
                return;
            }

            var row = grid.SelectedRows[0];

            int queueId = Convert.ToInt32(row.Cells["QueueId"].Value);

            var form = new DoctorViewPastRecords();
            form.viewOnly = true;
            form.set_queueID(queueId);

            MainForm.userRole = "Doctor";
            MainForm.Instance.OpenChildForm(form);
        }
    }
}