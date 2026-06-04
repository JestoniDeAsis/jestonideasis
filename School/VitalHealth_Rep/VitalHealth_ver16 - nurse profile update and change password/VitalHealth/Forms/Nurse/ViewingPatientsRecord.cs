using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using VitalHealth.Shared;

namespace VitalHealth.Forms.Nurse
{
    public partial class ViewingPatientsRecord : Form
    {
        private int _selectedQueueId = 0;
        private int _selectedPatientId = 0;
        private int _selectedRecordId = 0;

        public ViewingPatientsRecord()
        {
            InitializeComponent();
            this.Load += ViewingPatientsRecord_Load;
        }

        private void ViewingPatientsRecord_Load(object? sender, EventArgs e)
        {
            _selectedQueueId = PatientRecordContext.SelectedQueueId;
            _selectedPatientId = PatientRecordContext.SelectedPatientId;
            _selectedRecordId = PatientRecordContext.SelectedRecordId;

            SetFieldsAsDisplayOnly();

            if (_selectedQueueId <= 0 || _selectedPatientId <= 0 || _selectedRecordId <= 0)
            {
                MessageBox.Show("No patient record was selected.", "Missing Record",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
                return;
            }

            LoadSelectedPatientRecord();
        }

        private void SetFieldsAsDisplayOnly()
        {
            SetRoundedTextBoxDisplayOnly(ageTxtBox);
            SetRoundedTextBoxDisplayOnly(sexTxtBox);
            SetRoundedTextBoxDisplayOnly(birthDateTxtBox);
            SetRoundedTextBoxDisplayOnly(patientContactTxtBox);
            SetRoundedTextBoxDisplayOnly(emergNameTxtBox);
            SetRoundedTextBoxDisplayOnly(emergRelationTxtBox);
            SetRoundedTextBoxDisplayOnly(emergContactTxtBox);
            SetRoundedTextBoxDisplayOnly(chckupDateTxtBox);
            SetRoundedTextBoxDisplayOnly(arrivalTxtBox);
            SetRoundedTextBoxDisplayOnly(patientTypeTxtBox);
            SetRoundedTextBoxDisplayOnly(assignDocTxtBox);
            SetRoundedTextBoxDisplayOnly(specialtyTxtBox);
            SetRoundedTextBoxDisplayOnly(bloodPressureTxtBox);
            SetRoundedTextBoxDisplayOnly(heartRateTxtBox);
            SetRoundedTextBoxDisplayOnly(tempTxtBox);
            SetRoundedTextBoxDisplayOnly(weightTxtBox);

            SetRoundedMultilineTextBoxDisplayOnly(reasonTxtBox);
        }

        private void SetRoundedTextBoxDisplayOnly(Control ctrl)
        {
            if (ctrl == null) return;

            ctrl.Enabled = true;
            ctrl.TabStop = false;
            ctrl.BackColor = Color.White;
            ctrl.ForeColor = Color.Black;
            ctrl.Cursor = Cursors.Default;

            ctrl.KeyPress -= PreventTextBoxEdit_KeyPress;
            ctrl.KeyDown -= PreventTextBoxEdit_KeyDown;
            ctrl.MouseDown -= PreventTextBoxFocus_MouseDown;
            ctrl.Enter -= PreventTextBoxFocus_Enter;

            ctrl.KeyPress += PreventTextBoxEdit_KeyPress;
            ctrl.KeyDown += PreventTextBoxEdit_KeyDown;
            ctrl.MouseDown += PreventTextBoxFocus_MouseDown;
            ctrl.Enter += PreventTextBoxFocus_Enter;
        }

        private void SetRoundedMultilineTextBoxDisplayOnly(Control ctrl)
        {
            if (ctrl == null) return;

            ctrl.Enabled = true;
            ctrl.TabStop = true;
            ctrl.BackColor = Color.White;
            ctrl.ForeColor = Color.Black;

            ctrl.KeyPress -= PreventReasonEdit_KeyPress;
            ctrl.KeyDown -= PreventReasonEdit_KeyDown;

            ctrl.KeyPress += PreventReasonEdit_KeyPress;
            ctrl.KeyDown += PreventReasonEdit_KeyDown;
        }

        private void PreventTextBoxEdit_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PreventTextBoxEdit_KeyDown(object? sender, KeyEventArgs e)
        {
            bool allowed = false;

            if (e.Control && e.KeyCode == Keys.C)
            {
                allowed = true;
            }

            if (!allowed)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void PreventTextBoxFocus_MouseDown(object? sender, MouseEventArgs e)
        {
            patientNameLbl.Focus();
        }

        private void PreventTextBoxFocus_Enter(object? sender, EventArgs e)
        {
            patientNameLbl.Focus();
        }

        private void PreventReasonEdit_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PreventReasonEdit_KeyDown(object? sender, KeyEventArgs e)
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

        private void LoadSelectedPatientRecord()
        {
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
                        ) AS patient_full_name,

                        TIMESTAMPDIFF(YEAR, pd.birthdate, CURDATE()) AS computed_age,
                        pd.sex,
                        pd.birthdate,
                        pd.contact_number,
                        pd.emergency_contact_person_name,
                        pd.relationship,
                        pd.emergency_contact_number,

                        pr.reason_for_checkup,
                        pq.queued_at,

                        CASE
                            WHEN EXISTS (
                                SELECT 1
                                FROM patient_data pd2
                                WHERE pd2.patient_id <> pd.patient_id
                                  AND IFNULL(pd2.first_name, '') = IFNULL(pd.first_name, '')
                                  AND IFNULL(pd2.middle_name, '') = IFNULL(pd.middle_name, '')
                                  AND IFNULL(pd2.last_name, '') = IFNULL(pd.last_name, '')
                                  AND IFNULL(pd2.name_suffix, '') = IFNULL(pd.name_suffix, '')
                            )
                            THEN 'Returning Patient'
                            ELSE 'New Patient'
                        END AS patient_type,

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
                        ) AS assigned_doctor,

                        IFNULL(ds.specialty_name, 'N/A') AS specialty_name,

                        IFNULL(pvs.blood_pressure, 'N/A') AS blood_pressure,
                        IFNULL(CAST(pvs.heart_rate AS CHAR), 'N/A') AS heart_rate,
                        IFNULL(CAST(pvs.temperature AS CHAR), 'N/A') AS temperature,
                        IFNULL(CAST(pvs.weight AS CHAR), 'N/A') AS weight_value

                    FROM patient_records pr
                    INNER JOIN patient_queue pq
                        ON pr.queue_id = pq.queue_id
                    INNER JOIN patient_data pd
                        ON pq.patient_id = pd.patient_id
                    LEFT JOIN patient_vital_signs pvs
                        ON pr.vital_signs_id = pvs.vital_signs_id
                    LEFT JOIN user_profile up
                        ON pq.doctor_id = up.user_id
                    LEFT JOIN doctor_specialty dspec
                        ON up.user_id = dspec.user_id
                    LEFT JOIN doctor_specialties ds
                        ON dspec.specialty_id = ds.specialty_id
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
                    patientNameLbl.ForeColor = Color.Black;

                    ageTxtBox.Text = reader["computed_age"]?.ToString() ?? "";
                    sexTxtBox.Text = reader["sex"]?.ToString() ?? "";
                    birthDateTxtBox.Text = Convert.ToDateTime(reader["birthdate"]).ToString("MMMM dd, yyyy");

                    patientContactTxtBox.Text = reader["contact_number"]?.ToString() ?? "";
                    emergNameTxtBox.Text = reader["emergency_contact_person_name"]?.ToString() ?? "";
                    emergRelationTxtBox.Text = reader["relationship"]?.ToString() ?? "";
                    emergContactTxtBox.Text = reader["emergency_contact_number"]?.ToString() ?? "";

                    reasonTxtBox.Text = reader["reason_for_checkup"]?.ToString() ?? "";
                    chckupDateTxtBox.Text = Convert.ToDateTime(reader["queued_at"]).ToString("MMMM dd, yyyy");
                    arrivalTxtBox.Text = Convert.ToDateTime(reader["queued_at"]).ToString("hh:mm tt");

                    patientTypeTxtBox.Text = reader["patient_type"]?.ToString() ?? "";
                    assignDocTxtBox.Text = reader["assigned_doctor"]?.ToString() ?? "";
                    specialtyTxtBox.Text = reader["specialty_name"]?.ToString() ?? "";

                    bloodPressureTxtBox.Text = reader["blood_pressure"]?.ToString() ?? "";
                    heartRateTxtBox.Text = reader["heart_rate"]?.ToString() ?? "";
                    tempTxtBox.Text = reader["temperature"]?.ToString() ?? "";
                    weightTxtBox.Text = reader["weight_value"]?.ToString() ?? "";
                }
                else
                {
                    MessageBox.Show("Selected patient record was not found.", "Record Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error while loading patient record:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error while loading patient record:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doctorConsultationBtn_Click(object? sender, EventArgs e)
        {
            if (_selectedQueueId <= 0 || _selectedPatientId <= 0 || _selectedRecordId <= 0)
            {
                MessageBox.Show("No patient record selected for doctor consultation.", "Missing Record",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PatientRecordContext.SelectedQueueId = _selectedQueueId;
            PatientRecordContext.SelectedPatientId = _selectedPatientId;
            PatientRecordContext.SelectedRecordId = _selectedRecordId;

            MainForm.Instance.OpenChildForm(new DoctorConsult());
        }

        private void backPatientHistory_Click(object? sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        }

      
    }
}