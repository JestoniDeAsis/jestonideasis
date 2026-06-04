using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;
using VitalHealth.Forms.Nurse;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace VitalHealth.Forms.Admin
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void AddStaff_Load(object sender, EventArgs e)

        {

            UpdateSpecializationUI();
            lbl_adminLastName.Text = MainForm.loggedInUserLastname;

            cmbSpecialization.Items.Clear();

            var db = new Data.DBConnection();
            using var conn = db.GetConnection();
            conn.Open();

            var list = new List<string>();
            using var cmd = new MySql.Data.MySqlClient.MySqlCommand(
              "SELECT specialty_name FROM doctor_specialties;", conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader.GetString("specialty_name"));
            }

            cmbSpecialization.DataSource = list;
            cmbSpecialization.SelectedIndex = -1;

            txtContactNumber.NumbersOnly = true;
            txtContactNumber.MaxLength = 10;
        }

        private void UpdateSpecializationUI()
        {
            cmbSpecialization.Visible = rdbDoctor.Checked;

            if (!rdbDoctor.Checked)
            {
                cmbSpecialization.SelectedIndex = -1;
            }
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

        private void btnSalesDashboard_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new AdminDashboard());
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new ManageStaff());
        }

        private void btnPatientsRec_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NewAdminPatientPastRecord());
        }

        private void btnSchedNFee_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DocSched());
        }

        private void cnbSuffix_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void rdbDoctor_Load(object sender, EventArgs e)
        {

        }

        private void rdbNurse_Load(object sender, EventArgs e)
        {

        }

        private void rdbDoctor_Load_1(object sender, EventArgs e)
        {
            UpdateSpecializationUI();
        }

        private void rdbDoctor_ToggleStateChanged(object sender, StateChangeEventArgs args)
        {
            UpdateSpecializationUI();
        }

        private void cmbSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbDoctor_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSpecializationUI();
        }

        private void rdbNurse_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSpecializationUI();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new ManageStaff());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if
                (
                string.IsNullOrEmpty(txtLastname.Text) ||
                string.IsNullOrEmpty(txtFirstname.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtContactNumber.Text) ||
                string.IsNullOrEmpty(txtB_password.Text) ||
                string.IsNullOrEmpty(txtB_securityQuestion.Text) ||
                string.IsNullOrEmpty(txtB_securityAnswer.Text) ||
                cmbWorkingHours.SelectedIndex == -1
                )
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Fill all the required boxes.", Properties.Resources.warning_icon);
                DialogResult result = dialog.ShowDialog(this);
            }
            else if (
                txtContactNumber.Text.Length != 10 ||
                !txtContactNumber.Text.All(char.IsDigit) ||
                !txtContactNumber.Text.StartsWith("9"))
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Invalid Contact number.\nStart with 9.", Properties.Resources.warning_icon);
                DialogResult result = dialog.ShowDialog(this);
            }
            else if (!rdbDoctor.Checked && !rdbNurse.Checked)
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Please select a role (Doctor or Nurse).", Properties.Resources.warning_icon);
                dialog.ShowDialog(this);
                return;
            }

            else if (rdbDoctor.Checked && cmbSpecialization.SelectedIndex == -1)
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Select doctor specialization.", Properties.Resources.warning_icon);
                DialogResult result = dialog.ShowDialog(this);
            }
            else if (!txtB_password.Text.Equals(txtB_confirmPassword.Text))
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Password don't match.", Properties.Resources.cross_icon);
                DialogResult result = dialog.ShowDialog(this);
            }
            else if (
                txtB_password.Text.Length < 8 ||
                !txtB_password.Text.Any(char.IsUpper) ||
                !txtB_password.Text.Any(char.IsLower) ||
                !txtB_password.Text.Any(char.IsDigit) ||
                !txtB_password.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {

                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Follow the given password \nrules.", Properties.Resources.warning_icon);
                DialogResult result = dialog.ShowDialog(this);
                lbl_passwordRules.Visible = true;
            }
            else
            {
                lbl_passwordRules.Visible = false;
                int role_id = 3; // nurse
                if (rdbDoctor.Checked) role_id = 2; // doc

                // --- NEW SPECIALIZATION LIMIT CHECK START ---
                if (rdbDoctor.Checked)
                {
                    int selectedSpecialtyId = cmbSpecialization.SelectedIndex + 1;
                    var checkDb = new Data.DBConnection();
                    using var checkConn = checkDb.GetConnection();
                    checkConn.Open();

                    using var checkCmd = new MySql.Data.MySqlClient.MySqlCommand(
                        @"SELECT COUNT(*) 
                          FROM doctor_specialty ds
                          INNER JOIN users u ON ds.user_id = u.user_id
                          WHERE ds.specialty_id = @specialty_id
                          AND u.is_activated = 1", checkConn);

                    checkCmd.Parameters.AddWithValue("@specialty_id", selectedSpecialtyId);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count >= 1)
                    {
                        SmallInfoDialog limitDialog = new SmallInfoDialog();
                        limitDialog.setResult($"{cmbSpecialization.Text} already has an \nassigned doctor.", Properties.Resources.warning_icon);
                        limitDialog.ShowDialog(this);
                        return; // Stop the registration process here
                    }
                }

                var db = new Data.DBConnection();
                using var conn = db.GetConnection();
                conn.Open();
                using var transaction = conn.BeginTransaction();

                try
                {
                    var cmd = conn.CreateCommand();
                    cmd.Transaction = transaction;

                    cmd.CommandText = "SELECT COUNT(*) FROM users WHERE username = @username";
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                    int exists = Convert.ToInt32(cmd.ExecuteScalar());

                    if (exists > 0)
                    {
                        transaction.Rollback();

                        SmallInfoDialog _dialog = new SmallInfoDialog();
                        _dialog.setResult("Username already exists.", Properties.Resources.cross_icon);
                        _dialog.ShowDialog(this);

                        return;
                    }

                    // Insert user
                    cmd.Parameters.Clear();
                    cmd.CommandText = @"INSERT INTO users (username, password, security_question, security_answer, role_id)
                        VALUES (@username, @password, @security_question, @security_answer, @role_id)";
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", MainForm.HashString(txtB_password.Text));
                    cmd.Parameters.AddWithValue("@role_id", role_id);
                    cmd.Parameters.AddWithValue("@security_question", txtB_securityQuestion.Text);
                    cmd.Parameters.AddWithValue("@security_answer", MainForm.HashString(txtB_securityAnswer.Text));

                    cmd.ExecuteNonQuery();

                    // Get ID
                    cmd.CommandText = "SELECT LAST_INSERT_ID();";
                    int userId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Insert profile
                    cmd.Parameters.Clear();
                    cmd.CommandText = @"INSERT INTO user_profile 
                        (user_id, first_name, middle_name, last_name, name_suffix,working_time_start, working_time_end, contact_number)
                        VALUES (@user_id, @firstname, @middlename, @lastname, @suffix, @working_start, @working_end, @contact)";

                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                    cmd.Parameters.AddWithValue("@middlename", txtMI.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);

                    string[] timeParts = cmbWorkingHours.SelectedItem.ToString().Split('-');

                    DateTime startTime = DateTime.Parse(timeParts[0].Trim());
                    DateTime endTime = DateTime.Parse(timeParts[1].Trim());

                    cmd.Parameters.AddWithValue("@working_start", startTime.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@working_end", endTime.ToString("HH:mm:ss"));

                    if (cmbSuffix.SelectedIndex == -1)
                        cmd.Parameters.AddWithValue("@suffix", "");
                    else if (cmbSuffix.SelectedIndex == 0)
                        cmd.Parameters.AddWithValue("@suffix", "");
                    else
                        cmd.Parameters.AddWithValue("@suffix", cmbSuffix.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContactNumber.Text);

                    cmd.ExecuteNonQuery();

                    if (rdbDoctor.Checked)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = @"INSERT INTO doctor_specialty (user_id, specialty_id) VALUES(@user_id, @specialty_id)";

                        cmd.Parameters.AddWithValue("@user_id", userId);
                        cmd.Parameters.AddWithValue("@specialty_id", cmbSpecialization.SelectedIndex + 1);

                        cmd.ExecuteNonQuery();


                    }

                    transaction.Commit();

                    SmallInfoDialog dialog = new SmallInfoDialog();
                    dialog.setResult("Staff registration success", Properties.Resources.check_icon);
                    DialogResult result = dialog.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        MainForm.Instance.OpenChildForm(new ManageStaff());
                    }
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private void lbl_exampleAnswer_Click(object sender, EventArgs e)
        {

        }

        private void cmbWorkingHours_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNumber_Load(object sender, EventArgs e)
        {

        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Stop at 11 digist
            if (char.IsDigit(e.KeyChar) && txtContactNumber.Text.Length >= 11)
            {
                e.Handled = true;
            }
        }

        private void btnSalesDashboard_Click_1(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new AdminDashboard());
        }

        private void btnManageStaff_Click_1(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new ManageStaff());
        }

        private bool passwordShown = false;
        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            if (!passwordShown)
            {
                txtB_password.UseSystemPasswordChar = false;
                passwordShown = true;
                btn_showPassword.Image = Properties.Resources.shown_icon;
            }
            else
            {
                txtB_password.UseSystemPasswordChar = true;
                passwordShown = false;
                btn_showPassword.Image = Properties.Resources.hidden_icon;
            }
        }

        private bool confirmPasswordShown = false;
        private void btn_showConfirmPassword_Click(object sender, EventArgs e)
        {
            if (!confirmPasswordShown)
            {
                txtB_confirmPassword.UseSystemPasswordChar = false;
                confirmPasswordShown = true;
                btn_showConfirmPassword.Image = Properties.Resources.shown_icon;
            }
            else
            {
                txtB_confirmPassword.UseSystemPasswordChar = true;
                confirmPasswordShown = false;
                btn_showConfirmPassword.Image = Properties.Resources.hidden_icon;
            }
        }

        private bool secAnswerShown = false;
        private void btn_showSecAnswer_Click(object sender, EventArgs e)
        {
            if (!secAnswerShown)
            {
                txtB_securityAnswer.UseSystemPasswordChar = false;
                secAnswerShown = true;
                btn_showSecAnswer.Image = Properties.Resources.shown_icon;
            }
            else
            {
                txtB_securityAnswer.UseSystemPasswordChar = true;
                secAnswerShown = false;
                btn_showSecAnswer.Image = Properties.Resources.hidden_icon;
            }
        }
    }
}
