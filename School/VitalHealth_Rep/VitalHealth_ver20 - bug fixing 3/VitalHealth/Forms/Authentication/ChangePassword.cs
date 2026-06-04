using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Dialogs;
using VitalHealth.Forms.Doctor;
using VitalHealth.Forms.Nurse;

namespace VitalHealth.Forms.Authentication
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            btn_progress.Text = "ENTER";
            btn_progress.Location = new Point(275, 395);
        }

        private bool currPasswordShown = false;
        private void btn_showCurrPassword_Click(object sender, EventArgs e)
        {
            if (!currPasswordShown)
            {
                txtB_currPassword.UseSystemPasswordChar = false;
                currPasswordShown = true;
                btn_showCurrPassword.Image = Properties.Resources.shown_icon;
            }
            else
            {
                txtB_currPassword.UseSystemPasswordChar = true;
                currPasswordShown = false;
                btn_showCurrPassword.Image = Properties.Resources.hidden_icon;
            }
        }

        private bool newPasswordShown = false;
        private void btn_showNewPassword_Click(object sender, EventArgs e)
        {
            if (!newPasswordShown)
            {
                txtB_newPassword.UseSystemPasswordChar = false;
                newPasswordShown = true;
                btn_showNewPassword.Image = Properties.Resources.shown_icon;
            }
            else
            {
                txtB_newPassword.UseSystemPasswordChar = true;
                newPasswordShown = false;
                btn_showNewPassword.Image = Properties.Resources.hidden_icon;
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (MainForm.userRole.Equals("Doctor"))
                MainForm.Instance.OpenChildForm(new DoctorEditProfile());
            else if (MainForm.userRole.Equals("Nurse"))
                MainForm.Instance.OpenChildForm(new EditNurseProfile());
        }

        private void btn_progress_Click(object sender, EventArgs e)
        {
            switch (btn_progress.Text)
            {
                case "ENTER":
                    checkCurrentPassword();
                    break;
                case "CONFIRM":
                    setNewPassword();
                    break;
            }
        }

        void checkCurrentPassword()
        {
            if (String.IsNullOrEmpty(txtB_currPassword.Text))
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Answer the current password.", Properties.Resources.warning_icon);
                DialogResult result = dialog.ShowDialog(this);
                return;
            }

            var db = new Data.DBConnection();
            using var conn = db.GetConnection();
            conn.Open();

            string currentPassword = MainForm.HashString(txtB_currPassword.Text);

            string query = "SELECT password FROM users WHERE user_id = @user_id";

            using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user_id", MainForm.loggedInUserID);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (currentPassword.Equals(reader["password"]))
                {
                    txtB_currPassword.Enabled = false;

                    lbl_setNewPass.Visible = true;
                    btn_showNewPassword.Visible = true;
                    txtB_newPassword.Visible = true;
                    btn_showConfirmPassword.Visible = true;
                    txtB_confirmPassword.Visible = true;
                    lbl_passwordRules.Visible = true;

                    btn_progress.Text = "CONFIRM";
                    btn_progress.Location = new Point(275, 620);
                }
                else
                {
                    SmallInfoDialog dialog = new SmallInfoDialog();
                    dialog.setResult("Wrong Password.", Properties.Resources.cross_icon);
                    DialogResult result = dialog.ShowDialog(this);
                }
            }
        }

        void setNewPassword()
        {

            if (string.IsNullOrEmpty(txtB_newPassword.Text) || string.IsNullOrEmpty(txtB_confirmPassword.Text))
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Fill all the \npassword boxes.", Properties.Resources.warning_icon);
                DialogResult result = dialog.ShowDialog(this);
                return;
            }

            if (
                txtB_newPassword.Text.Length < 8 ||
                !txtB_newPassword.Text.Any(char.IsUpper) ||
                !txtB_newPassword.Text.Any(char.IsLower) ||
                !txtB_newPassword.Text.Any(char.IsDigit) ||
                !txtB_newPassword.Text.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Follow the given password \nrules.", Properties.Resources.warning_icon);
                DialogResult result = dialog.ShowDialog(this);
                lbl_passwordRules.Visible = true;
                return;
            }

            if (!txtB_newPassword.Text.Equals(txtB_confirmPassword.Text))
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Password don't match.", Properties.Resources.cross_icon);
                DialogResult result = dialog.ShowDialog(this);
                return;
            }

            var db = new Data.DBConnection();
            using var conn = db.GetConnection();
            conn.Open();

            string query_updateNewPassword = "UPDATE users SET password = @password WHERE user_id = @user_id";

            using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query_updateNewPassword, conn);
            cmd.Parameters.AddWithValue("@password", MainForm.HashString(txtB_newPassword.Text));
            cmd.Parameters.AddWithValue("@user_id", MainForm.loggedInUserID);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Password Updated.", Properties.Resources.check_icon);
                DialogResult result = dialog.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    MainForm.Instance.OpenChildForm(new LoginForm());
                }
            }
            else
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Password update failed.", Properties.Resources.cross_icon);
                DialogResult result = dialog.ShowDialog(this);
            }
        }
    }
}
