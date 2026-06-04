using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using VitalHealth.Forms.Admin;
using VitalHealth.Forms.Doctor;
using VitalHealth.Shared;

namespace VitalHealth.Forms.Nurse
{
    public partial class DoctorConsult : Form
    {
        private int _selectedQueueId = 0;
        private int _selectedPatientId = 0;
        private int _selectedRecordId = 0;

        public DoctorConsult()
        {
            InitializeComponent();
            this.Load += DoctorConsult_Load;

            patientDetailButton.Click -= patientDetailButton_Click;
            patientDetailButton.Click += patientDetailButton_Click;

            backPatientHistory.Click -= backPatientHistory_Click;
            backPatientHistory.Click += backPatientHistory_Click;
        }

        private void DoctorConsult_Load(object? sender, EventArgs e)
        {
            _selectedQueueId = PatientRecordContext.SelectedQueueId;
            _selectedPatientId = PatientRecordContext.SelectedPatientId;
            _selectedRecordId = PatientRecordContext.SelectedRecordId;

            SetFieldsAsDisplayOnly();

            if (_selectedQueueId <= 0 || _selectedPatientId <= 0 || _selectedRecordId <= 0)
            {
                MessageBox.Show("No patient consultation was selected.", "Missing Record",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MainForm.Instance.OpenChildForm(new ViewingPatientsRecord());
                return;
            }

            LoadDoctorConsultData();
        }

        private void SetFieldsAsDisplayOnly()
        {
            SetScrollableDisplayOnly(symptomRprtTxtBox);
            SetScrollableDisplayOnly(physExamTxtBox);
            SetScrollableDisplayOnly(diagnosisTxtBox);
            SetScrollableDisplayOnly(treatmentTxtBox);
            SetScrollableDisplayOnly(preMedTxtBox);
            SetScrollableDisplayOnly(labTestTxtBox);
            SetScrollableDisplayOnly(followUpTxtBox);

            patientNameLbl.ForeColor = Color.Black;
            docLbl.ForeColor = Color.Black;
            docSpecialLbl.ForeColor = Color.Black;
            feeLbl.ForeColor = Color.Black;
        }

        private void SetScrollableDisplayOnly(Control ctrl)
        {
            if (ctrl == null) return;

            ctrl.Enabled = true;
            ctrl.TabStop = true;
            ctrl.BackColor = Color.White;
            ctrl.ForeColor = Color.Black;

            ctrl.KeyPress -= PreventEdit_KeyPress;
            ctrl.KeyDown -= PreventScrollBoxEdit_KeyDown;

            ctrl.KeyPress += PreventEdit_KeyPress;
            ctrl.KeyDown += PreventScrollBoxEdit_KeyDown;
        }

        private void PreventEdit_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PreventScrollBoxEdit_KeyDown(object? sender, KeyEventArgs e)
        {
            bool allowed =
                e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.PageUp ||
                e.KeyCode == Keys.PageDown ||
                e.KeyCode == Keys.Home ||
                e.KeyCode == Keys.End ||
                e.KeyCode == Keys.Tab ||
                e.KeyCode == Keys.ShiftKey;

            if (e.Control && e.KeyCode == Keys.C)
            {
                allowed = true;
            }

            if (!allowed)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void LoadDoctorConsultData()
        {
            var db = new VitalHealth.Data.DBConnection();
            using var conn = db.GetConnection();

            try
            {
                conn.Open();

                string sql = @"
                    SELECT
                        pr.record_id,
                        pq.queue_id,
                        pd.patient_id,

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
                        ) AS patient_full_name,

                        IFNULL(pr.symptoms_report, '') AS symptoms_report,
                        IFNULL(pr.physical_exam, '') AS physical_exam,
                        IFNULL(pr.diagnosis, '') AS diagnosis,
                        IFNULL(pr.treatment_plan, '') AS treatment_plan,
                        IFNULL(pr.prescription, '') AS prescription,

                        CONCAT_WS(', ',
                            CASE WHEN lr.bloodtest = 1 THEN 'Blood Test' ELSE NULL END,
                            CASE WHEN lr.urinalysis = 1 THEN 'Urinalysis' ELSE NULL END,
                            CASE WHEN lr.x_ray = 1 THEN 'X-Ray' ELSE NULL END,
                            CASE WHEN lr.ultrasound = 1 THEN 'Ultrasound' ELSE NULL END,
                            NULLIF(TRIM(lr.other_test), '')
                        ) AS lab_tests,

                        IFNULL(pr.follow_up, '') AS follow_up,

                        TRIM(
                            CONCAT(
                                'Dr. ',
                                up.first_name,
                                CASE
                                    WHEN up.middle_name IS NULL OR up.middle_name = '' OR up.middle_name = 'N/A' THEN ''
                                    ELSE CONCAT(' ', up.middle_name)
                                END,
                                ' ',
                                up.last_name,
                                CASE
                                    WHEN up.name_suffix IS NULL OR up.name_suffix = '' OR up.name_suffix = 'N/A' THEN ''
                                    ELSE CONCAT(' ', up.name_suffix)
                                END
                            )
                        ) AS doctor_name,

                        IFNULL(ds.specialty_name, 'N/A') AS specialty_name,
                        IFNULL(ppd.payment_fee, 0) AS payment_fee

                    FROM patient_records pr
                    INNER JOIN patient_queue pq
                        ON pr.queue_id = pq.queue_id
                    INNER JOIN patient_data pd
                        ON pq.patient_id = pd.patient_id
                    LEFT JOIN lab_request lr
                        ON pr.record_id = lr.record_id
                    LEFT JOIN user_profile up
                        ON pq.doctor_id = up.user_id
                    LEFT JOIN doctor_specialty dspec
                        ON up.user_id = dspec.user_id
                    LEFT JOIN doctor_specialties ds
                        ON dspec.specialty_id = ds.specialty_id
                    LEFT JOIN patient_payment_data ppd
                        ON pq.queue_id = ppd.queue_id
                    WHERE pr.record_id = @recordId
                      AND pq.queue_id = @queueId
                      AND pd.patient_id = @patientId
                    LIMIT 1;";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@recordId", _selectedRecordId);
                cmd.Parameters.AddWithValue("@queueId", _selectedQueueId);
                cmd.Parameters.AddWithValue("@patientId", _selectedPatientId);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    patientNameLbl.Text = reader["patient_full_name"]?.ToString() ?? "";
                    symptomRprtTxtBox.Text = reader["symptoms_report"]?.ToString() ?? "";
                    physExamTxtBox.Text = reader["physical_exam"]?.ToString() ?? "";
                    diagnosisTxtBox.Text = reader["diagnosis"]?.ToString() ?? "";
                    treatmentTxtBox.Text = reader["treatment_plan"]?.ToString() ?? "";
                    preMedTxtBox.Text = reader["prescription"]?.ToString() ?? "";

                    string labTests = reader["lab_tests"]?.ToString() ?? "";
                    labTestTxtBox.Text = string.IsNullOrWhiteSpace(labTests) ? "No lab test requested." : labTests;

                    followUpTxtBox.Text = reader["follow_up"]?.ToString() ?? "";
                    docLbl.Text = reader["doctor_name"]?.ToString() ?? "";
                    docSpecialLbl.Text = reader["specialty_name"]?.ToString() ?? "";
                    feeLbl.Text = "₱" + Convert.ToDecimal(reader["payment_fee"]).ToString("N2");
                }
                else
                {
                    MessageBox.Show("Selected consultation record was not found.", "Record Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MainForm.Instance.OpenChildForm(new ViewingPatientsRecord());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error while loading doctor consultation:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error while loading doctor consultation:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backPatientHistory_Click(object? sender, EventArgs e)
        {
            if (MainForm.userRole.Equals("Nurse"))
                MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
            else if (MainForm.userRole.Equals("Doctor"))
                MainForm.Instance.OpenChildForm(new DoctorPatientPastRecord());
            else if (MainForm.userRole.Equals("Admin"))
                MainForm.Instance.OpenChildForm(new ViewPreviousRecords());
        }

        private void patientDetailButton_Click(object? sender, EventArgs e)
        {
            if (_selectedQueueId <= 0 || _selectedPatientId <= 0 || _selectedRecordId <= 0)
            {
                MessageBox.Show("No patient record selected.", "Missing Record",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PatientRecordContext.SelectedQueueId = _selectedQueueId;
            PatientRecordContext.SelectedPatientId = _selectedPatientId;
            PatientRecordContext.SelectedRecordId = _selectedRecordId;

            MainForm.Instance.OpenChildForm(new ViewingPatientsRecord());
        }

      
    }
}