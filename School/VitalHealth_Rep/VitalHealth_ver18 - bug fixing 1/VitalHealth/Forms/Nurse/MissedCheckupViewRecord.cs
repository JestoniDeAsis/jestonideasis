using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using VitalHealth.Data;
using VitalHealth.Shared;

namespace VitalHealth.Forms.Nurse
{
    public partial class MissedCheckupViewRecord : Form
    {
        private int _selectedQueueId = 0;
        private int _selectedPatientId = 0;

        public MissedCheckupViewRecord()
        {
            InitializeComponent();
            this.Load += MissedCheckupViewRecord_Load;
        }

        private void MissedCheckupViewRecord_Load(object sender, EventArgs e)
        {
            _selectedQueueId = PatientRecordContext.SelectedQueueId;
            _selectedPatientId = PatientRecordContext.SelectedPatientId;

            SetFieldsAsDisplayOnly();

            if (_selectedQueueId <= 0 || _selectedPatientId <= 0)
            {
                MessageBox.Show("No missed checkup patient was selected.", "Missing Record",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MainForm.Instance.OpenChildForm(new MissedCheckups());
                return;
            }

            LoadSelectedMissedCheckupRecord();
        }

        private void SetFieldsAsDisplayOnly()
        {
            SetRoundedTextBoxDisplayOnly(MSageTxtBox);
            SetRoundedTextBoxDisplayOnly(MSsexTxtBox);
            SetRoundedTextBoxDisplayOnly(MSbirthDateTxtBox);
            SetRoundedTextBoxDisplayOnly(MSpatientContactTxtBox);

            SetRoundedTextBoxDisplayOnly(MSemergNameTxtBox);
            SetRoundedTextBoxDisplayOnly(MSemergRelationTxtBox);
            SetRoundedTextBoxDisplayOnly(MSemergContactTxtBox);

            SetRoundedTextBoxDisplayOnly(MSchckupDateTxtBox);
            SetRoundedTextBoxDisplayOnly(MSarrivalTxtBox);
            SetRoundedTextBoxDisplayOnly(MSpatientTypeTxtBox);
            SetRoundedTextBoxDisplayOnly(MSassignDocTxtBox);
            SetRoundedTextBoxDisplayOnly(MSspecialtyTxtBox);

            SetRoundedTextBoxDisplayOnly(MSbloodPressureTxtBox);
            SetRoundedTextBoxDisplayOnly(MSheartRateTxtBox);
            SetRoundedTextBoxDisplayOnly(MStempTxtBox);
            SetRoundedTextBoxDisplayOnly(MSweightTxtBox);

            SetReasonDisplayOnly(MSreasonTxtBox);
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

        private void SetReasonDisplayOnly(Control ctrl)
        {
            if (ctrl == null) return;

            ctrl.Enabled = true;
            ctrl.TabStop = true;
            ctrl.BackColor = Color.White;
            ctrl.ForeColor = Color.Black;
            ctrl.Cursor = Cursors.Default;

            ctrl.KeyPress -= PreventReasonEdit_KeyPress;
            ctrl.KeyDown -= PreventReasonEdit_KeyDown;

            ctrl.KeyPress += PreventReasonEdit_KeyPress;
            ctrl.KeyDown += PreventReasonEdit_KeyDown;
        }

        private void PreventTextBoxEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PreventTextBoxEdit_KeyDown(object sender, KeyEventArgs e)
        {
            bool allowed = false;

            if (e.Control && e.KeyCode == Keys.C)
                allowed = true;

            if (!allowed)
                e.SuppressKeyPress = true;
        }

        private void PreventTextBoxFocus_MouseDown(object sender, MouseEventArgs e)
        {
            MSpatientNameLbl.Focus();
        }

        private void PreventTextBoxFocus_Enter(object sender, EventArgs e)
        {
            MSpatientNameLbl.Focus();
        }

        private void PreventReasonEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PreventReasonEdit_KeyDown(object sender, KeyEventArgs e)
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
                allowed = true;

            if (!allowed)
                e.SuppressKeyPress = true;
        }

        private void LoadSelectedMissedCheckupRecord()
        {
            var db = new DBConnection();
            using var conn = db.GetConnection();

            try
            {
                conn.Open();

                string sql = @"
            SELECT
                pq.queue_id,
                pd.patient_id,

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
                ) AS patient_full_name,

                TIMESTAMPDIFF(YEAR, pd.birthdate, CURDATE()) AS computed_age,
                pd.sex,
                pd.birthdate,
                pd.contact_number,
                pd.emergency_contact_person_name,
                pd.relationship,
                pd.emergency_contact_number,

                IFNULL(pr.reason_for_checkup, '') AS reason_for_checkup,
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
                        IFNULL(up.first_name, ''),
                        CASE
                            WHEN up.middle_name IS NULL OR up.middle_name = '' OR up.middle_name = 'N/A' THEN ''
                            ELSE CONCAT(' ', up.middle_name)
                        END,
                        CASE
                            WHEN up.last_name IS NULL OR up.last_name = '' OR up.last_name = 'N/A' THEN ''
                            ELSE CONCAT(' ', up.last_name)
                        END,
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

            FROM patient_queue pq
            INNER JOIN patient_data pd
                ON pq.patient_id = pd.patient_id
            LEFT JOIN patient_records pr
                ON pq.queue_id = pr.queue_id
            LEFT JOIN patient_vital_signs pvs
                ON pr.vital_signs_id = pvs.vital_signs_id
            LEFT JOIN user_profile up
                ON pq.doctor_id = up.user_id
            LEFT JOIN doctor_specialty dspec
                ON up.user_id = dspec.user_id
            LEFT JOIN doctor_specialties ds
                ON dspec.specialty_id = ds.specialty_id
            WHERE pq.queue_id = @queueId
              AND pq.patient_id = @patientId
              AND pq.queue_status_id = 3
            ORDER BY pr.record_id DESC
            LIMIT 1;";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@queueId", _selectedQueueId);
                cmd.Parameters.AddWithValue("@patientId", _selectedPatientId);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MSpatientNameLbl.Text = reader["patient_full_name"]?.ToString() ?? "";
                    MSpatientNameLbl.ForeColor = Color.Black;

                    MSageTxtBox.Text = reader["computed_age"]?.ToString() ?? "";
                    MSsexTxtBox.Text = reader["sex"]?.ToString() ?? "";

                    if (reader["birthdate"] != DBNull.Value)
                        MSbirthDateTxtBox.Text = Convert.ToDateTime(reader["birthdate"]).ToString("MMMM dd, yyyy");
                    else
                        MSbirthDateTxtBox.Text = "";

                    MSpatientContactTxtBox.Text = reader["contact_number"]?.ToString() ?? "";
                    MSemergNameTxtBox.Text = reader["emergency_contact_person_name"]?.ToString() ?? "";
                    MSemergRelationTxtBox.Text = reader["relationship"]?.ToString() ?? "";
                    MSemergContactTxtBox.Text = reader["emergency_contact_number"]?.ToString() ?? "";

                    MSreasonTxtBox.Text = reader["reason_for_checkup"]?.ToString() ?? "";

                    if (reader["queued_at"] != DBNull.Value)
                    {
                        DateTime queuedAt = Convert.ToDateTime(reader["queued_at"]);
                        MSchckupDateTxtBox.Text = queuedAt.ToString("MMMM dd, yyyy");
                        MSarrivalTxtBox.Text = queuedAt.ToString("hh:mm tt");
                    }
                    else
                    {
                        MSchckupDateTxtBox.Text = "";
                        MSarrivalTxtBox.Text = "";
                    }

                    MSpatientTypeTxtBox.Text = reader["patient_type"]?.ToString() ?? "";
                    MSassignDocTxtBox.Text = reader["assigned_doctor"]?.ToString() ?? "";
                    MSspecialtyTxtBox.Text = reader["specialty_name"]?.ToString() ?? "";

                    MSbloodPressureTxtBox.Text = reader["blood_pressure"]?.ToString() ?? "";
                    MSheartRateTxtBox.Text = reader["heart_rate"]?.ToString() ?? "";
                    MStempTxtBox.Text = reader["temperature"]?.ToString() ?? "";
                    MSweightTxtBox.Text = reader["weight_value"]?.ToString() ?? "";
                }
                else
                {
                    MessageBox.Show("Selected missed checkup record was not found.", "Record Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    MainForm.Instance.OpenChildForm(new MissedCheckups());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error while loading missed checkup record:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error while loading missed checkup record:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MSbackPatientHistory_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new MissedCheckups());
        }
    }
}