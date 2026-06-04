using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Dialogs;

namespace VitalHealth.Forms.Authentication
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            btn_progress.Text = "SEARCH";
            btn_progress.Location = new Point(275, 513);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new LoginForm());
        }

        private bool secAnswerShown = false;
        private void btn_showSecurityAnswer_Click(object sender, EventArgs e)
        {
            if (!secAnswerShown)
            {
                txtB_securityAnswer.UseSystemPasswordChar = false;
                secAnswerShown = true;
                btn_showSecurityAnswer.Image = Properties.Resources.shown_icon;
            }
            else
            {
                txtB_securityAnswer.UseSystemPasswordChar = true;
                secAnswerShown = false;
                btn_showSecurityAnswer.Image = Properties.Resources.hidden_icon;
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


        private void btn_progress_Click(object sender, EventArgs e)
        {
            switch (btn_progress.Text)
            {
                case "SEARCH":
                    if (string.IsNullOrEmpty(txtB_username.Text))
                        return;
                    searchUser();
                    break;
                case "CONFIRM":
                    if (string.IsNullOrEmpty(txtB_securityAnswer.Text))
                        return;
                    checkSecurityAnswerCheck();
                    break;
                case "FINALIZE":
                    setNewPassword();
                    break;
            }
        }

        string securityAnswer = "";
        int userID = 0;
        void searchUser()
        {
            var db = new Data.DBConnection();
            using var conn = db.GetConnection();
            conn.Open();

            string query_searchUser = "SELECT * FROM users WHERE BINARY username = @username";

            using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query_searchUser, conn);
            cmd.Parameters.AddWithValue("@username", txtB_username.Text);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                userID = Convert.ToInt32(reader["user_id"]);
                securityAnswer = "" + reader["security_answer"].ToString();
                txtB_username.Enabled = false;
                rtxtBox_securityQuestion.Text = "Question: " + reader["security_question"].ToString();
                btn_showSecurityAnswer.Visible = true;
                txtB_securityAnswer.Visible = true;
                btn_progress.Text = "CONFIRM";
                btn_progress.Location = new Point(275, 584);
            }
            else
            {
                rtxtBox_securityQuestion.Text = "User not found.";
            }
        }

        void checkSecurityAnswerCheck()
        {
            if (!MainForm.HashString(txtB_securityAnswer.Text).Equals(securityAnswer))
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Wrong answer.", Properties.Resources.cross_icon);
                DialogResult result = dialog.ShowDialog(this);
                return;
            }

            rtxtBox_securityQuestion.Text = "";
            secAnswerShown = false;
            btn_showSecurityAnswer.Image = Properties.Resources.hidden_icon;
            btn_showSecurityAnswer.Enabled = false;
            txtB_securityAnswer.Enabled = false;
            txtB_securityAnswer.Text = "";

            lbl_setNewPass.Visible = true;
            btn_showNewPassword.Visible = true;
            txtB_newPassword.Visible = true;
            btn_showConfirmPassword.Visible = true;
            txtB_confirmPassword.Visible = true;

            btn_progress.Text = "FINALIZE";
            btn_progress.Location = new Point(275, 803);
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
            cmd.Parameters.AddWithValue("@user_id", userID);

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
