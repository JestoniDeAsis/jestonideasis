using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;
using VitalHealth.Shared;

namespace VitalHealth.Forms.Nurse
{
    public partial class NursePatientPastRecords : Form
    {
        private const int PageSize = 18;

        private readonly List<PastRecordRow> _allRecords = new List<PastRecordRow>();
        private List<PastRecordRow> _filteredRecords = new List<PastRecordRow>();

        private int _currentPage = 1;
        private int _totalPages = 1;

        private int _selectedQueueId = 0;
        private int _selectedPatientId = 0;
        private int _selectedRecordId = 0;

        public NursePatientPastRecords()
        {
            InitializeComponent();
            WireUpCustomEvents();
        }

        private bool _patientHistoryExpanded = false;

        private void WireUpCustomEvents()
        {
            searchButton.Click += searchButton_Click;
            viewRecordButton.Click += viewRecordButton_Click;

            backArrowDG.Click += backArrowDG_Click;
            nextArrowDG.Click += nextArrowDG_Click;

            searchTxtBox.TextChanged += searchTxtBox_TextChanged;
        }

        private void PatientPastRecords_Load(object sender, EventArgs e)
        {
            lbl_nurseLastName.Text = MainForm.loggedInUserLastname;

            btn_pastRecords.Visible = false;
            btn_missedCheckups.Visible = false;
            button3.Text = "Patient History  ▼"; // ✅ default state

            ConfigurePastRecordGrid();
            LoadPastRecordsFromDatabase();
            ApplySearchAndPagination();
        }

        private void ConfigurePastRecordGrid()
        {
            var grid = pastRecordDataGrid.Grid;

            grid.Columns.Clear();
            grid.Rows.Clear();

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

            grid.SelectionChanged -= PastRecordGrid_SelectionChanged;
            grid.CellClick -= PastRecordGrid_CellClick;
            //grid.CellMouseUp -= PastRecordGrid_CellMouseUp;
            //grid.CurrentCellChanged -= PastRecordGrid_CurrentCellChanged;

            grid.SelectionChanged += PastRecordGrid_SelectionChanged;
            grid.CellClick += PastRecordGrid_CellClick;
            //grid.CellMouseUp += PastRecordGrid_CellMouseUp;
            //grid.CurrentCellChanged += PastRecordGrid_CurrentCellChanged;
        }

        private void LoadPastRecordsFromDatabase()
        {
            _allRecords.Clear();

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
                    _allRecords.Add(new PastRecordRow
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
                MessageBox.Show("Error loading past records: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySearchAndPagination()
        {
            string searchValue = searchTxtBox.Text.Trim().ToLower();

            _filteredRecords = _allRecords
                .Where(r =>
                    string.IsNullOrWhiteSpace(searchValue) ||
                    r.PatientName.ToLower().Contains(searchValue) ||
                    r.QueueId.ToString().Contains(searchValue))
                .ToList();

            _totalPages = Math.Max(1, (int)Math.Ceiling(_filteredRecords.Count / (double)PageSize));

            if (_currentPage > _totalPages)
                _currentPage = _totalPages;

            if (_currentPage < 1)
                _currentPage = 1;

            LoadCurrentPageToGrid();
            UpdatePaginationUI();
            ClearSelectedRecord();
        }

        private void LoadCurrentPageToGrid()
        {
            var grid = pastRecordDataGrid.Grid;
            grid.Rows.Clear();

            var pageItems = _filteredRecords
                .Skip((_currentPage - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            foreach (var item in pageItems)
            {
                grid.Rows.Add(
                    item.QueueId,
                    item.PatientId,
                    item.RecordId,
                    item.PatientName,
                    item.Sex,
                    item.Age,
                    item.CheckupDate.ToString("yyyy-MM-dd hh:mm tt"),
                    item.AssignedDoctor,
                    item.Specialty,
                    item.RoomNumber
                );
            }

            grid.ClearSelection();
            grid.CurrentCell = null;

            _selectedQueueId = 0;
            _selectedPatientId = 0;
            _selectedRecordId = 0;
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

        private void ClearSelectedRecord()
        {
            _selectedQueueId = 0;
            _selectedPatientId = 0;
            _selectedRecordId = 0;
            viewRecordButton.Enabled = false;
        }

        private void UpdateSelectedRecordFromGrid()
        {
            var grid = pastRecordDataGrid.Grid;

            if (grid.SelectedRows.Count == 0)
            {
                ClearSelectedRecord();
                return;
            }

            var row = grid.SelectedRows[0];

            if (row == null ||
                row.Cells["QueueId"].Value == null ||
                row.Cells["PatientId"].Value == null ||
                row.Cells["RecordId"].Value == null)
            {
                ClearSelectedRecord();
                return;
            }

            _selectedQueueId = Convert.ToInt32(row.Cells["QueueId"].Value);
            _selectedPatientId = Convert.ToInt32(row.Cells["PatientId"].Value);
            _selectedRecordId = Convert.ToInt32(row.Cells["RecordId"].Value);

            viewRecordButton.Enabled = true;
        }

        private void PastRecordGrid_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelectedRecordFromGrid();
        }

        private void PastRecordGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var grid = pastRecordDataGrid.Grid;
                grid.Rows[e.RowIndex].Selected = true;
                grid.CurrentCell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                UpdateSelectedRecordFromGrid();
            }
        }

        //private void PastRecordGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        UpdateSelectedRecordFromGrid();
        //    }
        //}

        //private void PastRecordGrid_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    UpdateSelectedRecordFromGrid();
        //}

        private void searchButton_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            ApplySearchAndPagination();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            ApplySearchAndPagination();
        }

        private void backArrowDG_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                LoadCurrentPageToGrid();
                UpdatePaginationUI();
                ClearSelectedRecord();
            }
        }

        private void nextArrowDG_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                _currentPage++;
                LoadCurrentPageToGrid();
                UpdatePaginationUI();
                ClearSelectedRecord();
            }
        }

        private void PageLabel_Click(object sender, EventArgs e)
        {
        }

        private void viewRecordButton_Click(object sender, EventArgs e)
        {
            if (_selectedQueueId <= 0 || _selectedPatientId <= 0 || _selectedRecordId <= 0)
            {
                MessageBox.Show("Please select a patient record first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PatientRecordContext.SelectedQueueId = _selectedQueueId;
            PatientRecordContext.SelectedPatientId = _selectedPatientId;
            PatientRecordContext.SelectedRecordId = _selectedRecordId;

            MainForm.userRole = "Nurse";
            MainForm.Instance.OpenChildForm(new ViewingPatientsRecord());
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

        private void btn_checkupForm_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new PatientsCheckUpForm());
        }

        private void btn_todaysPatient_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new TodaysPatients());
        }

        private void btn_missedCheckups_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new MissedCheckups());
        }

        private void btn_schedAndFee_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new SchedAndFee());
        }

        private void btn_schedAndFee_Click_1(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new SchedAndFee());
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new EditNurseProfile());
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

        private void bttn_missedCheckups_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new MissedCheckups());
        }
    }
}