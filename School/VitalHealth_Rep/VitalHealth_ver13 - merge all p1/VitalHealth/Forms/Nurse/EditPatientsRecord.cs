using System;

using System.Windows.Forms;

using MySql.Data.MySqlClient;

using VitalHealth.Data;



namespace VitalHealth.Forms.Nurse

{

    public partial class EditPatientsRecord : Form

    {

        private int _patientId;

        private int _queueId;



        public EditPatientsRecord()

        {

            InitializeComponent();

        }



        public EditPatientsRecord(int patientId, int queueId) : this()

        {

            this._patientId = patientId;

            this._queueId = queueId;

        }



        private void EditPatientsRecord_Load(object sender, EventArgs e)

        {

            LockCustomControl(txtB_age);

            AttachContactValidation(txtB_contactNumber);

            AttachContactValidation(txtB_contactNumberOfContactPerson);



            // Setup Birthday logic

            var innerDtp = FindInternalControl<DateTimePicker>(dtP_birthday);

            if (innerDtp != null)

            {

                innerDtp.ValueChanged += (s, ev) =>

                {

                    int age = DateTime.Today.Year - innerDtp.Value.Year;

                    if (innerDtp.Value.Date > DateTime.Today.AddYears(-age)) age--;

                    SetCustomText(txtB_age, age.ToString());

                };

            }



            // --- USE BEGININVOKE TO WAIT FOR CUSTOM CONTROLS TO FINISH RENDER ---

            if (_queueId > 0)

            {

                this.BeginInvoke(new MethodInvoker(() =>

                {

                    LoadPatientData();

                }));

            }

        }



        // --- CORE RECURSIVE HELPER ---

        private T FindInternalControl<T>(Control parent) where T : Control

        {

            if (parent == null) return null;

            foreach (Control c in parent.Controls)

            {

                if (c is T target) return target;

                var result = FindInternalControl<T>(c);

                if (result != null) return result;

            }

            return null;

        }



        // --- CUSTOM CONTROL HELPERS ---

        private void SetCustomText(Control ctrl, string val)

        {

            var tb = FindInternalControl<TextBox>(ctrl);

            if (tb != null) tb.Text = val;

        }



        private void SetCustomCombo(Control ctrl, string val)

        {

            if (ctrl == null) return;



            // 1. Find the internal ComboBox component

            var cb = FindInternalControl<ComboBox>(ctrl);



            // 2. Normalize the value (Handle NULLs or empty strings from DB as "N/A")

            string dbValue = (string.IsNullOrWhiteSpace(val) || val.ToUpper() == "NULL") ? "N/A" : val.Trim();



            if (cb != null)

            {

                // Force the internal ComboBox to select the item

                int index = cb.FindStringExact(dbValue);

                if (index != -1)

                {

                    cb.SelectedIndex = index;

                }

                else

                {

                    cb.Text = dbValue;

                }

            }



            // 3. FORCE THE CUSTOM CONTROL UI TO UPDATE

            // We try to set the 'Texts' property which is the visual display of the custom control

            var textsProp = ctrl.GetType().GetProperty("Texts");

            if (textsProp != null)

            {

                textsProp.SetValue(ctrl, dbValue);

            }

            else

            {

                ctrl.Text = dbValue;

            }



            // 4. TRIGGER THE CUSTOM CONTROL'S INTERNAL UPDATE LOGIC

            // This finds the private/protected method that custom controls use to repaint

            var method = ctrl.GetType().GetMethod("OnSelectedIndexChanged", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            if (method != null)

            {

                method.Invoke(ctrl, new object[] { EventArgs.Empty });

            }



            // 5. Final UI Redraw

            ctrl.Invalidate();

            ctrl.Refresh();

        }



        private string GetVal(Control ctrl)

        {

            if (ctrl == null) return "N/A";



            string result = "";



            // 1. Try to get the internal ComboBox text

            var cb = FindInternalControl<ComboBox>(ctrl);

            if (cb != null)

            {

                // If an item is selected, take that. Otherwise, take the typed text.

                result = cb.SelectedIndex != -1 ? cb.SelectedItem.ToString() : cb.Text;

            }



            // 2. If still empty, try the Custom Control's 'Texts' or 'Text' property

            if (string.IsNullOrWhiteSpace(result))

            {

                var textsProp = ctrl.GetType().GetProperty("Texts");

                result = textsProp != null ? textsProp.GetValue(ctrl)?.ToString() : ctrl.Text;

            }



            // 3. FINAL SAFETY CHECK: If it's still empty or null, return "N/A"

            return string.IsNullOrWhiteSpace(result) ? "N/A" : result.Trim();

        }



        private void LockCustomControl(Control ctrl)

        {

            var tb = FindInternalControl<TextBox>(ctrl);

            if (tb != null) tb.ReadOnly = true;

        }



        private void AttachContactValidation(Control ctrl)

        {

            var tb = FindInternalControl<TextBox>(ctrl);

            if (tb != null)

            {

                tb.MaxLength = 10;

                tb.KeyPress += (s, ev) =>

                {

                    if (char.IsControl(ev.KeyChar)) return;

                    if (!char.IsDigit(ev.KeyChar)) { ev.Handled = true; return; }

                    if (tb.SelectionStart == 0 && ev.KeyChar != '9') ev.Handled = true;

                };

            }

        }



        private void LoadPatientData()
        {
            var db = new DBConnection();
            using var conn = db.GetConnection();

            // ✅ FIX: Added r.reason_for_checkup to the SELECT
            string sql = @"SELECT p.*, v.weight, v.temperature, v.blood_pressure, v.heart_rate,
                          r.reason_for_checkup
                   FROM patient_data p
                   JOIN patient_queue q ON p.patient_id = q.patient_id
                   JOIN patient_records r ON q.queue_id = r.queue_id
                   JOIN patient_vital_signs v ON r.vital_signs_id = v.vital_signs_id
                   WHERE q.queue_id = @qid";

            try
            {
                conn.Open();
                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@qid", _queueId);
                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    this._patientId = Convert.ToInt32(reader["patient_id"]);

                    SetCustomText(txtB_firstname, reader["first_name"].ToString());
                    SetCustomText(txtB_middlename, reader["middle_name"].ToString());
                    SetCustomText(txtB_lastname, reader["last_name"].ToString());
                    SetCustomText(txtB_age, reader["age"].ToString());
                    SetCustomText(txtB_contactNumber, reader["contact_number"].ToString());

                    SetCustomCombo(cmbB_suffix, reader["name_suffix"].ToString());
                    SetCustomCombo(cmbB_sex, reader["sex"].ToString());

                    var dtp = FindInternalControl<DateTimePicker>(dtP_birthday);
                    if (dtp != null && reader["birthdate"] != DBNull.Value)
                        dtp.Value = Convert.ToDateTime(reader["birthdate"]);

                    SetCustomText(txtB_relationship, reader["relationship"].ToString());
                    SetCustomText(txtB_contactPersonName, reader["emergency_contact_person_name"].ToString());
                    SetCustomText(txtB_contactNumberOfContactPerson, reader["emergency_contact_number"].ToString());

                    SetCustomText(txtB_weight, reader["weight"].ToString());
                    SetCustomText(txtB_temperature, reader["temperature"].ToString());
                    SetCustomText(txtB_bloodPressure, reader["blood_pressure"].ToString());
                    SetCustomText(txtB_heartRate, reader["heart_rate"].ToString());

                    // ✅ FIX: Now populates the reason field
                    SetCustomText(txtB_reason, reader["reason_for_checkup"].ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show("Load Error: " + ex.Message); }
        }



        private void bttn_update_Click(object sender, EventArgs e)

        {

            var db = new DBConnection();

            using var conn = db.GetConnection();

            try

            {

                conn.Open();

                using var trans = conn.BeginTransaction();



                // 1. Update Patient Personal Data

                string sqlPatient = @"UPDATE patient_data SET 

                               first_name=@fn, middle_name=@mn, last_name=@ln, name_suffix=@sfx,

                               birthdate=@dob, age=@age, sex=@sex, contact_number=@cn,

                               relationship=@rel, emergency_contact_person_name=@ecp, emergency_contact_number=@ecn

                               WHERE patient_id=@pid";



                using var cmd1 = new MySqlCommand(sqlPatient, conn, trans);

                cmd1.Parameters.AddWithValue("@pid", _patientId);

                cmd1.Parameters.AddWithValue("@fn", GetVal(txtB_firstname));

                cmd1.Parameters.AddWithValue("@mn", GetVal(txtB_middlename));

                cmd1.Parameters.AddWithValue("@ln", GetVal(txtB_lastname));

                cmd1.Parameters.AddWithValue("@sfx", GetVal(cmbB_suffix));

                cmd1.Parameters.AddWithValue("@age", GetVal(txtB_age));

                cmd1.Parameters.AddWithValue("@sex", GetVal(cmbB_sex));

                cmd1.Parameters.AddWithValue("@cn", GetVal(txtB_contactNumber));

                cmd1.Parameters.AddWithValue("@rel", GetVal(txtB_relationship));

                cmd1.Parameters.AddWithValue("@ecp", GetVal(txtB_contactPersonName));

                cmd1.Parameters.AddWithValue("@ecn", GetVal(txtB_contactNumberOfContactPerson));

                var dtp = FindInternalControl<DateTimePicker>(dtP_birthday);

                cmd1.Parameters.AddWithValue("@dob", dtp?.Value.ToString("yyyy-MM-dd") ?? DateTime.Now.ToString("yyyy-MM-dd"));

                cmd1.ExecuteNonQuery();



                // 2. Update Vital Signs (linked via the queue/records)

                string sqlVitals = @"UPDATE patient_vital_signs v

                             JOIN patient_records r ON v.vital_signs_id = r.vital_signs_id

                             SET v.weight=@w, v.temperature=@t, v.blood_pressure=@bp, v.heart_rate=@hr

                             WHERE r.queue_id=@qid";



                using var cmd2 = new MySqlCommand(sqlVitals, conn, trans);

                cmd2.Parameters.AddWithValue("@qid", _queueId);

                cmd2.Parameters.AddWithValue("@w", GetVal(txtB_weight));

                cmd2.Parameters.AddWithValue("@t", GetVal(txtB_temperature));

                cmd2.Parameters.AddWithValue("@bp", GetVal(txtB_bloodPressure));

                cmd2.Parameters.AddWithValue("@hr", GetVal(txtB_heartRate));

                cmd2.ExecuteNonQuery();



                // 3. Update Reason for Visit

                string sqlRecord = "UPDATE patient_records SET reason_for_checkup=@reason WHERE queue_id=@qid";

                using var cmd3 = new MySqlCommand(sqlRecord, conn, trans);

                cmd3.Parameters.AddWithValue("@qid", _queueId);

                cmd3.Parameters.AddWithValue("@reason", GetVal(txtB_reason)); // Ensure this control name is correct

                cmd3.ExecuteNonQuery();



                trans.Commit();

                MessageBox.Show("Record updated successfully!");

                MainForm.Instance.OpenChildForm(new TodaysPatients());

            }

            catch (Exception ex) { MessageBox.Show("Update Error: " + ex.Message); }

        }



        private void btn_back_Click(object sender, EventArgs e) => MainForm.Instance.OpenChildForm(new TodaysPatients());

        private void panel1_Paint(object sender, PaintEventArgs e)

        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)

        {

        }



        private void roundedPanel1_Paint(object sender, PaintEventArgs e)

        {

        }



        private void roundedMultilineTextBox1_Load(object sender, EventArgs e)

        {



        }

    }

}