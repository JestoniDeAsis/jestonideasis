using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using VitalHealth.Data;
using VitalHealth.Forms.Dialogs;
using VitalHealth.Forms.Nurse;

namespace VitalHealth.Forms.Authentication
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            rCmbBox_specialization.Items.Clear();

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

            rCmbBox_specialization.DataSource = list;

            rCmbBox_specialization.SelectedIndex = -1;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new IndexForm());
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

        private bool securityAnswerShown = false;
        private void btn_showSecurityAnswer_Click(object sender, EventArgs e)
        {
            if (!securityAnswerShown)
            {
                txtB_securityAnswer.UseSystemPasswordChar = false;
                securityAnswerShown = true;
                btn_showSecurityAnswer.Image = Properties.Resources.shown_icon;
            }
            else
            {
                txtB_securityAnswer.UseSystemPasswordChar = true;
                securityAnswerShown = false;
                btn_showSecurityAnswer.Image = Properties.Resources.hidden_icon;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtB_firstname.Text) ||
                string.IsNullOrEmpty(txtB_lastname.Text) ||
                string.IsNullOrEmpty(txtB_username.Text) ||
                string.IsNullOrEmpty(txtB_contactNumber.Text) ||
                string.IsNullOrEmpty(txtB_password.Text) ||
                string.IsNullOrEmpty(txtB_confirmPassword.Text) ||
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
                txtB_contactNumber.Text.Length != 10 || 
                !txtB_contactNumber.Text.All(char.IsDigit) || 
                !txtB_contactNumber.Text.StartsWith("9"))
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Invalid Contact number.\nStart with 9.", Properties.Resources.warning_icon);
                DialogResult result = dialog.ShowDialog(this);
            }
            else if (rdBtn_doctor.Checked && rCmbBox_specialization.SelectedIndex == -1)
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
                if (rdBtn_doctor.Checked) role_id = 2; // doc

                var db = new Data.DBConnection();
                using var conn = db.GetConnection();
                conn.Open();

                using var transaction = conn.BeginTransaction();

                try
                {
                    var cmd = conn.CreateCommand();
                    cmd.Transaction = transaction;

                    // Check if username is used
                    cmd.CommandText = "SELECT COUNT(*) FROM users WHERE username = @username";
                    cmd.Parameters.AddWithValue("@username", txtB_username.Text);

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
                    cmd.CommandText = @"INSERT INTO users (username, password, role_id, security_question, security_answer)
                        VALUES (@username, @password, @role_id, @security_question, @security_answer)";
                    cmd.Parameters.AddWithValue("@username", txtB_username.Text);
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
                        (user_id, first_name, middle_name, last_name, name_suffix, working_time_start, working_time_end, contact_number)
                        VALUES (@user_id, @firstname, @middlename, @lastname, @suffix, @working_start, @working_end, @contact)";

                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.Parameters.AddWithValue("@firstname", txtB_firstname.Text);
                    cmd.Parameters.AddWithValue("@middlename", txtB_middlename.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtB_lastname.Text);
                    if (cmbBox_suffix.SelectedIndex == -1)
                        cmd.Parameters.AddWithValue("@suffix", "");
                    else if (cmbBox_suffix.SelectedIndex == 0)
                        cmd.Parameters.AddWithValue("@suffix", "");
                    else
                        cmd.Parameters.AddWithValue("@suffix", cmbBox_suffix.SelectedValue);
                    cmd.Parameters.AddWithValue("@contact", txtB_contactNumber.Text);

                    string[] timeParts = cmbWorkingHours.SelectedItem.ToString().Split('-');

                    DateTime startTime = DateTime.Parse(timeParts[0].Trim());
                    DateTime endTime = DateTime.Parse(timeParts[1].Trim());

                    cmd.Parameters.AddWithValue("@working_start", startTime.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@working_end", endTime.ToString("HH:mm:ss"));

                    cmd.ExecuteNonQuery();

                    // Inser doctor specialty
                    if (rdBtn_doctor.Checked)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = @"INSERT INTO doctor_specialty (user_id, specialty_id) VALUES(@user_id, @specialty_id)";

                        cmd.Parameters.AddWithValue("@user_id", userId);
                        cmd.Parameters.AddWithValue("@specialty_id", rCmbBox_specialization.SelectedIndex + 1);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    RegistrationCompleteDialog dialog = new RegistrationCompleteDialog();
                    DialogResult result = dialog.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        MainForm.Instance.OpenChildForm(new LoginForm());
                    }
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private void rdBtn_doctor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn_doctor.Checked)
            {
                rCmbBox_specialization.SelectedIndex = -1;
                rCmbBox_specialization.Visible = true;
            }
        }

        private void rdBtn_nurse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn_nurse.Checked)
            {
                rCmbBox_specialization.SelectedIndex = -1;
                rCmbBox_specialization.Visible = false;
            }
        }
    }
}
