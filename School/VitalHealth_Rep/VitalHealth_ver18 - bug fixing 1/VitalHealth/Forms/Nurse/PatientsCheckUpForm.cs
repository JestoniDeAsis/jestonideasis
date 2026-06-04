using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Data;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;

namespace VitalHealth.Forms.Nurse
{
    public partial class PatientsCheckUpForm : Form
    {
        public PatientsCheckUpForm()
        {
            InitializeComponent();

        }

        private bool _patientHistoryExpanded = false;
        private bool _isSwitchingRadio = false;

        private void PatientsCheckUpForm_Load(object sender, EventArgs e)
        {
            lbl_nurseLastName.Text = MainForm.loggedInUserLastname;

            // Handle custom button controls
            foreach (Control internalPart in bttn_clearAllEntry.Controls)
            {
                internalPart.Click += bttn_clearAllEntry_Click;
            }

            SetupRoundedTextBox(txtB_contactNumber, 10, txtB_contactNumber_KeyPress);
            SetupRoundedTextBox(txtB_contactNumberOfContactPerson, 10, txtB_contactNumberOfContactPerson_KeyPress);

            Control[] vitalControls = { txtB_weight, txtB_temperature, txtB_bloodPressure, txtB_heartRate };
            foreach (Control customControl in vitalControls)
            {
                foreach (Control internalControl in customControl.Controls)
                {
                    if (internalControl is TextBox tb)
                    {
                        tb.KeyPress += VitalSigns_KeyPress;
                        tb.MaxLength = 7;
                    }
                }
            }

            btn_pastRecords.Visible = false;
            btn_missedCheckups.Visible = false;
            button3.Text = "Patient History  ▼"; // ✅ default state

            LoadDoctors();

            txtB_age.Enabled = false;
            dtP_dateOfBirth_ValueChanged(null, null);
            UpdateCustomControlText(txtB_consultationFee, "TBA");

            // Add these two lines inside PatientsCheckUpForm_Load()
            rdBttn_newPatient.CheckedChanged += rdBttn_newPatient_CheckedChanged;
            rdBttn_returningPatient.CheckedChanged += rdBttn_returningPatient_CheckedChanged;
        }

        private void LoadDoctors()
        {
            var db = new DBConnection();
            using var conn = db.GetConnection();

            string sql = @"
            SELECT 
                u.user_id, 
                up.last_name, 
                IFNULL(ds_spec.specialty_name, 'No Specialty') as specialty_name, 
                IFNULL(ds_spec.checkup_fee, 0) as checkup_fee, 
                IFNULL(ra.room_id, 'N/A') as room_id
            FROM users u
            INNER JOIN user_profile up ON u.user_id = up.user_id
            LEFT JOIN doctor_specialty ds_link ON u.user_id = ds_link.user_id
            LEFT JOIN doctor_specialties ds_spec ON ds_link.specialty_id = ds_spec.specialty_id
            LEFT JOIN room_assignment ra ON u.user_id = ra.doctor_id
            WHERE u.is_activated = 1
            AND u.role_id = 2
            AND CURRENT_TIME() <= up.working_time_end";
            //AND CURRENT_TIME() BETWEEN up.working_time_start AND up.working_time_end";

            try
            {
                conn.Open();
                using MySqlCommand cmd = new MySqlCommand(sql, conn);
                using MySqlDataReader reader = cmd.ExecuteReader();

                // CHANGE THIS LINE: Replace 'cmbB_selectedDoctor' with the 
                // ACTUAL name of the ComboBox from your Properties window.
                // If cmbB_selectedDoctor IS the ComboBox, use it directly!

                cmbB_selectedDoctor.Items.Clear();

                while (reader.Read())
                {
                    decimal feeValue = reader["checkup_fee"] != DBNull.Value ? Convert.ToDecimal(reader["checkup_fee"]) : 0;

                    cmbB_selectedDoctor.Items.Add(new DoctorItem
                    {
                        Text = $"[{reader["room_id"]}] Dr. {reader["last_name"]} - {reader["specialty_name"]}",
                        Value = reader["user_id"],
                        Fee = feeValue,
                        DisplayRoom = reader["room_id"].ToString()
                    });
                }

                // Re-bind the event to the control
                cmbB_selectedDoctor.SelectedIndexChanged -= HandleDoctorFeeUpdate;
                cmbB_selectedDoctor.SelectedIndexChanged += HandleDoctorFeeUpdate;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void AttachDoctorSelectionEvent()
        {
            foreach (Control c in cmbB_selectedDoctor.Controls)
            {
                if (c is ComboBox internalcb)
                {
                    internalcb.SelectedIndexChanged -= HandleDoctorFeeUpdate;
                    internalcb.SelectedIndexChanged += HandleDoctorFeeUpdate;
                }
            }
        }

        
        private bool PatientHasExistingRecords(string fn, string mn, string ln, string suffix, DateTime dob, string sex) 
        {
            var db = new DBConnection();
            using var conn = db.GetConnection();

            string sql = @"
            SELECT COUNT(*)
            FROM patient_data
            WHERE first_name = @fn
              AND middle_name = @mn
              AND last_name = @ln
              AND name_suffix = @sfx
              AND DATE(birthdate) = @dob
              AND sex = @sex
            LIMIT 1";

            using var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@mn", mn);
            cmd.Parameters.AddWithValue("@ln", ln);
            cmd.Parameters.AddWithValue("@sfx", suffix);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@sex", sex);

            conn.Open();

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        private void LoadPatientDetails(int patientId)
        {
            var db = new DBConnection();
            using var conn = db.GetConnection();

            string sql = @"
            SELECT 
                contact_number,
                emergency_contact_person_name,
                relationship,
                emergency_contact_number
            FROM patient_data
            WHERE patient_id = @pid
            LIMIT 1";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@pid", patientId);

            conn.Open();

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtB_contactNumber.Text = reader["contact_number"]?.ToString() ?? "";
                txtB_contactPersonName.Text = reader["emergency_contact_person_name"]?.ToString() ?? "";
                txtB_relationship.Text = reader["relationship"]?.ToString() ?? "";
                txtB_contactNumberOfContactPerson.Text = reader["emergency_contact_number"]?.ToString() ?? "";
            }
        }

        private void rdBttn_newPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (_isSwitchingRadio) return;
            if (!rdBttn_newPatient.Checked) return;

            string fn = txtB_firstname.Text.Trim();
            string mn = txtB_middlename.Text.Trim();
            if (mn == "N/A") mn = "";
            string ln = txtB_lastname.Text.Trim();
            string suffix = cmbB_suffix.Text.Trim();
            if (suffix == "N/A") suffix = "";
            DateTime dob = dtP_dateOfBirth.Value.Date;
            string sex = cmbB_sex.Text.Trim();

            if (!IsPatientInfoComplete()) return;

            if (PatientHasExistingRecords(fn, mn, ln, suffix, dob, sex))
            {
                MessageBox.Show(
                    $"{fn} {ln} already has medical records on file.\nPlease select 'Returning Patient' instead.",
                    "Returning Patient Detected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                _isSwitchingRadio = true;
                rdBttn_returningPatient.Checked = true;
                _isSwitchingRadio = false;
            }
        }

        private void rdBttn_returningPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (_isSwitchingRadio) return;
            if (!rdBttn_returningPatient.Checked) return;

            string fn = txtB_firstname.Text.Trim();
            string mn = txtB_middlename.Text.Trim();
            if (mn == "N/A") mn = "";
            string ln = txtB_lastname.Text.Trim();
            string suffix = cmbB_suffix.Text.Trim();
            if (suffix == "N/A") suffix = "";
            DateTime dob = dtP_dateOfBirth.Value.Date;
            string sex = cmbB_sex.Text.Trim();

            if (!IsPatientInfoComplete())
            {
                _isSwitchingRadio = true;
                rdBttn_newPatient.Checked = true;
                _isSwitchingRadio = false;
                return;
            }

            if (!PatientHasExistingRecords(fn, mn, ln, suffix, dob, sex))
            {
                MessageBox.Show(
                    $"No existing medical records found for {fn} {ln}.\nPlease select 'New Patient' instead.",
                    "New Patient Detected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                _isSwitchingRadio = true;
                rdBttn_newPatient.Checked = true;
                _isSwitchingRadio = false;
                return;
            }

            int patientId = GetExistingPatientId(fn, mn, ln, suffix, dob, sex);

            if (patientId != 0)
            {
                LoadPatientDetails(patientId);
            }
        }

        private bool IsPatientInfoComplete()
        {
            List<string> missingFields = new List<string>();

            if (string.IsNullOrWhiteSpace(txtB_firstname.Text))
                missingFields.Add("First Name");

            if (string.IsNullOrWhiteSpace(txtB_middlename.Text))
                missingFields.Add("Middle Name (N/A if no middle name)");

            if (string.IsNullOrWhiteSpace(txtB_lastname.Text))
                missingFields.Add("Last Name");

            if (cmbB_suffix.SelectedIndex == -1)
                missingFields.Add("Suffix");

            if (cmbB_sex.SelectedIndex == -1)
                missingFields.Add("Sex");

            if (dtP_dateOfBirth.Value.Date >= DateTime.Today)
                missingFields.Add("Valid Birthdate");

            if (missingFields.Count > 0)
            {
                string message = "Please fill in the following fields:\n\n• "
                                 + string.Join("\n• ", missingFields);

                MessageBox.Show(
                    message,
                    "Incomplete Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // This is the "Search Party" that finds the hidden dropdown inside your custom control
        private ComboBox FindComboBoxRecursive(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                // If we find a ComboBox, return it!
                if (child is ComboBox cb) return cb;

                // If we find a panel or container, look inside it too
                ComboBox found = FindComboBoxRecursive(child);
                if (found != null) return found;
            }
            return null;
        }

        private void HandleDoctorFeeUpdate(object sender, EventArgs e)
        {
            if (sender is ComboBox internalcb && internalcb.SelectedItem is DoctorItem selected)
            {
                UpdateCustomControlText(txtB_consultationFee, selected.Fee.ToString("N2"));
            }
            else
            {
                UpdateCustomControlText(txtB_consultationFee, "TBA");
            }
        }

        private void bttn_PrintQueuingNum_Click(object sender, EventArgs e)
        {
            // Name
            if (string.IsNullOrWhiteSpace(txtB_firstname.Text) || string.IsNullOrWhiteSpace(txtB_lastname.Text))
            {
                MessageBox.Show("Patient Name is required.", "Validation Error");
                return;
            }

            // Suffix
            if (cmbB_suffix.SelectedIndex == -1)
            {
                MessageBox.Show("Please select patient's suffix", "Validation Error");
                return;
            }

            // Birthdate (cannot be today or future)
            if (dtP_dateOfBirth.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Birthdate cannot be today or a future date.", "Validation Error");
                return;
            }

            // Sex
            if (cmbB_sex.SelectedIndex == -1)
            {
                MessageBox.Show("Please select patient's sex", "Validation Error");
                return;
            }

            // Contact Number (required)
            if (string.IsNullOrWhiteSpace(txtB_contactNumber.Text))
            {
                MessageBox.Show("Contact number is required.", "Validation Error");
                return;
            }

            // Emergency Contact Name
            if (string.IsNullOrWhiteSpace(txtB_contactPersonName.Text))
            {
                MessageBox.Show("Emergency contact name is required.", "Validation Error");
                return;
            }

            // Relationship
            if (string.IsNullOrWhiteSpace(txtB_relationship.Text))
            {
                MessageBox.Show("Relationship is required.", "Validation Error");
                return;
            }

            // Emergency Contact Number
            if (string.IsNullOrWhiteSpace(txtB_contactNumberOfContactPerson.Text))
            {
                MessageBox.Show("Emergency contact number is required.", "Validation Error");
                return;
            }

            // Reason for checkup
            if (string.IsNullOrWhiteSpace(txtB_reason.Text))
            {
                MessageBox.Show("Reason for checkup is required.", "Validation Error");
                return;
            }

            // Weight
            if (string.IsNullOrWhiteSpace(txtB_weight.Text) || !decimal.TryParse(txtB_weight.Text, out _))
            {
                MessageBox.Show("Please enter a valid weight.", "Validation Error");
                return;
            }

            // Heart Rate
            if (string.IsNullOrWhiteSpace(txtB_heartRate.Text) || !int.TryParse(txtB_heartRate.Text, out _))
            {
                MessageBox.Show("Please enter a valid heart rate.", "Validation Error");
                return;
            }

            // Temperature
            if (string.IsNullOrWhiteSpace(txtB_temperature.Text) || !decimal.TryParse(txtB_temperature.Text, out _))
            {
                MessageBox.Show("Please enter a valid temperature.", "Validation Error");
                return;
            }

            // Blood Pressure (strict format)
            var bpParts = txtB_bloodPressure.Text.Split('/');
            if (string.IsNullOrWhiteSpace(txtB_bloodPressure.Text) ||
                bpParts.Length != 2 ||
                !int.TryParse(bpParts[0], out _) ||
                !int.TryParse(bpParts[1], out _))
            {
                MessageBox.Show("Blood pressure must be in format like 120/80.", "Validation Error");
                return;
            }


            ComboBox internalcb = FindComboBoxRecursive(cmbB_selectedDoctor);

            // If the helper fails, try a direct cast just in case
            if (internalcb == null && cmbB_selectedDoctor is ComboBox direct)
            {
                internalcb = direct;
            }

            // Get the selected item from that SPECIFIC internal box
            DoctorItem selectedDoctor = internalcb?.SelectedItem as DoctorItem;

            if (selectedDoctor == null)
            {
                MessageBox.Show("Please select a doctor.");
                return;
            }
            string specialty = selectedDoctor.Text.Split('-').Last().Trim();
            var db = new DBConnection();
            using var conn = db.GetConnection();

            try
            {
                conn.Open();
                using var trans = conn.BeginTransaction();
                try
                {
                    int existingId = GetExistingPatientId(
                        txtB_firstname.Text.Trim(),
                        txtB_middlename.Text.Trim(),
                        txtB_lastname.Text.Trim(),
                        cmbB_suffix.Text,
                        dtP_dateOfBirth.Value.Date,
                        cmbB_sex.Text
                    );
                    long p_id = (existingId == 0) ? CreatePatient(conn, trans) : existingId;

                    // 🚫 CHECK: Already queued with same doctor?
                    if (IsPatientAlreadyQueued(p_id, selectedDoctor.Value, conn, trans))
                    {
                        MessageBox.Show(
                            "This patient is already in the queue for the selected doctor.",
                            "Duplicate Queue",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        trans.Rollback();
                        return;
                    }

                    string finalQueueNumber = GenerateDailyQueueNumber(GetPrefix(specialty), selectedDoctor.Value, conn, trans);

                    // Insert Vitals
                    string sqlV = "INSERT INTO patient_vital_signs (patient_id, weight, heart_rate, temperature, blood_pressure) VALUES (@pid, @w, @hr, @t, @bp); SELECT LAST_INSERT_ID();";
                    using var cmdV = new MySqlCommand(sqlV, conn, trans);
                    cmdV.Parameters.AddWithValue("@pid", p_id);
                    cmdV.Parameters.AddWithValue("@w", txtB_weight.Text);
                    cmdV.Parameters.AddWithValue("@hr", txtB_heartRate.Text);
                    cmdV.Parameters.AddWithValue("@t", txtB_temperature.Text);
                    cmdV.Parameters.AddWithValue("@bp", txtB_bloodPressure.Text);
                    long v_id = Convert.ToInt64(cmdV.ExecuteScalar());

                    // Insert Queue
                    string sqlQ = "INSERT INTO patient_queue (patient_id, doctor_id, queue_number, queue_status_id, queued_at) VALUES (@pid, @did, @qnum, 1, NOW()); SELECT LAST_INSERT_ID();";
                    using var cmdQ = new MySqlCommand(sqlQ, conn, trans);
                    cmdQ.Parameters.AddWithValue("@pid", p_id);
                    cmdQ.Parameters.AddWithValue("@did", selectedDoctor.Value);
                    cmdQ.Parameters.AddWithValue("@qnum", finalQueueNumber);
                    long q_id = Convert.ToInt64(cmdQ.ExecuteScalar());

                    // Insert Record
                    string sqlR = "INSERT INTO patient_records (vital_signs_id, queue_id, reason_for_checkup, recorded_at) VALUES (@vid, @qid, @reason, NOW());";
                    using var cmdR = new MySqlCommand(sqlR, conn, trans);
                    cmdR.Parameters.AddWithValue("@vid", v_id);
                    cmdR.Parameters.AddWithValue("@qid", q_id);
                    cmdR.Parameters.AddWithValue("@reason", txtB_reason.Text);
                    cmdR.ExecuteNonQuery();

                    trans.Commit();

                    // Call your print method with the 3 parameters
                    PrintTicket(finalQueueNumber, specialty);


                    MessageBox.Show($"Success! Ticket {finalQueueNumber} issued.");
                    ClearForm();
                }
                catch (Exception ex) { trans.Rollback(); MessageBox.Show("Transaction Error: " + ex.Message); }
            }
            catch (Exception ex) { MessageBox.Show("Connection Error: " + ex.Message); }
        }

        private long CreatePatient(MySqlConnection conn, MySqlTransaction trans)
        {
            string sql = @"INSERT INTO patient_data (first_name, middle_name, last_name, birthdate, sex, contact_number, 
                            emergency_contact_person_name, relationship, emergency_contact_number, name_suffix) 
                            VALUES (@fn, @mn, @ln, @dob, @sex, @num, @ecp, @rel, @ecn, @sfx); SELECT LAST_INSERT_ID();";
            using var cmd = new MySqlCommand(sql, conn, trans);
            cmd.Parameters.AddWithValue("@fn", txtB_firstname.Text.Trim());
            cmd.Parameters.AddWithValue("@mn", txtB_middlename.Text.Trim());
            cmd.Parameters.AddWithValue("@ln", txtB_lastname.Text.Trim());
            cmd.Parameters.AddWithValue("@dob", dtP_dateOfBirth.Value);
            cmd.Parameters.AddWithValue("@sex", cmbB_sex.Text);
            cmd.Parameters.AddWithValue("@num", txtB_contactNumber.Text.Trim());
            //cmd.Parameters.AddWithValue("@ag", txtB_age.Text);
            cmd.Parameters.AddWithValue("@ecp", txtB_contactPersonName.Text.Trim());
            cmd.Parameters.AddWithValue("@rel", txtB_relationship.Text.Trim());
            cmd.Parameters.AddWithValue("@ecn", txtB_contactNumberOfContactPerson.Text.Trim());
            string suffix = cmbB_suffix.Text;
            if (suffix.Equals("N/A")) suffix = "";
            cmd.Parameters.AddWithValue("@sfx", suffix);
            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        private void UpdateCustomControlText(Control customCtrl, string text)
        {
            customCtrl.Text = text;
            foreach (Control child in customCtrl.Controls)
            {
                if (child is TextBox tb) tb.Text = text;
            }
        }

        private void ClearForm()
        {
            Control[] fields = { txtB_firstname, txtB_middlename, txtB_lastname, txtB_contactNumber, txtB_contactPersonName, txtB_relationship, txtB_contactNumberOfContactPerson, txtB_weight, txtB_temperature, txtB_bloodPressure, txtB_heartRate, txtB_reason };
            foreach (Control c in fields) c.Text = "";
            cmbB_selectedDoctor.SelectedIndex = -1;
            cmbB_sex.SelectedIndex = -1;
            cmbB_suffix.SelectedIndex = -1;
            UpdateCustomControlText(txtB_consultationFee, "TBA");
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

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void bttn_pastRecords_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        }

        private void btn_missedCheckups_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new MissedCheckups());
        }

        // --- DESIGNER FIXES ---
        private void label3_Click(object sender, EventArgs e) { }
        private void roundedPanel1_Paint(object sender, PaintEventArgs e) { }

        // --- HELPERS ---
        private void SetupRoundedTextBox(Control container, int length, KeyPressEventHandler handler) { foreach (Control c in container.Controls) if (c is TextBox tb) { tb.MaxLength = length; tb.KeyPress += handler; } }
        private void txtB_contactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Get the TextBox calling this event
            TextBox tb = sender as TextBox;
            if (tb == null) return;

            // 2. Allow Control keys (backspace, etc.)
            if (char.IsControl(e.KeyChar)) return;

            // 3. Block anything that isn't a digit
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // 4. Force the FIRST digit to be '9'
            // If the textbox is empty and the user types something other than 9, block it.
            if (tb.SelectionStart == 0 && e.KeyChar != '9')
            {
                e.Handled = true;
                return;
            }

            // 5. Enforce Max Length of 10 digits
            // (If the length is already 10 and they aren't replacing text, block it)
            if (tb.Text.Length >= 10 && tb.SelectionLength == 0)
            {
                e.Handled = true;
            }
        }

        // Redirect the Emergency Contact handler to use the same logic
        private void txtB_contactNumberOfContactPerson_KeyPress(object sender, KeyPressEventArgs e)
            => txtB_contactNumber_KeyPress(sender, e); private void VitalSigns_KeyPress(object sender, KeyPressEventArgs e) { if (sender is TextBox tb && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '/') e.Handled = true; }
        private void dtP_dateOfBirth_ValueChanged(object sender, EventArgs e) { int age = DateTime.Today.Year - dtP_dateOfBirth.Value.Year; if (dtP_dateOfBirth.Value.Date > DateTime.Today.AddYears(-age)) age--; txtB_age.Text = age < 0 ? "0" : age.ToString(); }
        private string GenerateDailyQueueNumber(string prefix, object doctorId, MySqlConnection conn, MySqlTransaction trans) { string sql = "SELECT COUNT(*) FROM patient_queue WHERE doctor_id = @did AND DATE(queued_at) = CURDATE()"; using var cmd = new MySqlCommand(sql, conn, trans); cmd.Parameters.AddWithValue("@did", doctorId); return $"{prefix}-{(Convert.ToInt32(cmd.ExecuteScalar()) + 1):D3}"; }
        private int GetExistingPatientId(string fn, string mn, string ln, string suffix, DateTime dob, string sex) {
            if (mn == "N/A") mn = "";
            if (suffix == "N/A") suffix = "";

            var db = new DBConnection();
            using var conn = db.GetConnection();

            string sql = @"
            SELECT patient_id 
            FROM patient_data 
            WHERE first_name = @fn
              AND middle_name = @mn
              AND last_name = @ln
              AND name_suffix = @sfx
              AND DATE(birthdate) = @dob
              AND sex = @sex
            LIMIT 1";

            using var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@fn", fn);
            cmd.Parameters.AddWithValue("@mn", mn);
            cmd.Parameters.AddWithValue("@ln", ln);
            cmd.Parameters.AddWithValue("@sfx", suffix);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@sex", sex);

            conn.Open();

            object res = cmd.ExecuteScalar();
            return res != null ? Convert.ToInt32(res) : 0;
        }
        private void bttn_clearAllEntry_Click(object sender, EventArgs e) { if (MessageBox.Show("Clear?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes) ClearForm(); }
        private string GetPrefix(string specialty) => specialty switch { "General Medicine" => "GC", "Pediatrics" => "PD", "OB-Gyne" => "OBG", "Internal Medicine" => "IM", "Dermatologist" => "DM", "Orthopedics" => "ORT", _ => "QT" };

        // Navigation Buttons


        private void btn_logout_Click(object sender, EventArgs e) { if (new ConfirmActionDialog().ShowDialog() == DialogResult.OK) MainForm.Instance.OpenChildForm(new LoginForm()); }
        private void btn_todaysPatient_Click(object sender, EventArgs e) => MainForm.Instance.OpenChildForm(new TodaysPatients());
        private void btn_pastRecords_Click(object sender, EventArgs e) => MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        private void btn_schedAndFee_Click(object sender, EventArgs e) => MainForm.Instance.OpenChildForm(new SchedAndFee());
        private void btn_editProfile_Click(object sender, EventArgs e) => MainForm.Instance.OpenChildForm(new EditNurseProfile());

        private void button3_Click_1(object sender, EventArgs e)
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

        private bool IsPatientAlreadyQueued(long patientId, object doctorId, MySqlConnection conn, MySqlTransaction trans)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM patient_queue
                WHERE patient_id = @pid
                  AND doctor_id = @did
                  AND DATE(queued_at) = CURDATE()
                  AND queue_status_id != 5"; // means not done

            using var cmd = new MySqlCommand(sql, conn, trans);
            cmd.Parameters.AddWithValue("@pid", patientId);
            cmd.Parameters.AddWithValue("@did", doctorId);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }



    public class DoctorItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public string DisplayRoom { get; set; }
        public decimal Fee { get; set; }
        public override string ToString() => Text;
    }


}