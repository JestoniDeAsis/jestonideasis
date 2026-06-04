using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Dialogs;
using VitalHealth.Forms.Admin;
using VitalHealth.Forms.Doctor;
using VitalHealth.Forms.Nurse;
using VitalHealth.Data;

namespace VitalHealth.Forms.Authentication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtB_username.Text) && !String.IsNullOrEmpty(txtB_password.Text))
            {
                var db = new Data.DBConnection();
                using var conn = db.GetConnection();
                conn.Open();

                string query_userCheck = @"
                    SELECT users.*, user_profile.*
                    FROM users
                    JOIN user_profile ON users.user_id = user_profile.user_id
                    WHERE BINARY users.username = @username";

                using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query_userCheck, conn);
                cmd.Parameters.AddWithValue("@username", txtB_username.Text);

                using var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    SmallInfoDialog dialog = new SmallInfoDialog();
                    int is_activated = Convert.ToInt32(reader["is_activated"]);

                    if (!MainForm.HashString(txtB_password.Text).Equals(reader["password"]))
                    {
                        dialog.setResult("Wrong password.", Properties.Resources.cross_icon);
                        DialogResult result = dialog.ShowDialog(this);
                        return;
                    }
                    else if (is_activated == 0)
                    {
                        dialog.setResult("Account not activated.\nContact Admin for info.", Properties.Resources.cross_icon);
                        DialogResult result = dialog.ShowDialog(this);
                    }
                    else if (is_activated == 2)
                    {
                        dialog.setResult("Account deactivated.\nContact Admin for info.", Properties.Resources.cross_icon);
                        DialogResult result = dialog.ShowDialog(this);
                    }
                    else
                    {
                        int role = Convert.ToInt32(reader["role_id"]);
                        MainForm.loggedInUserID = Convert.ToInt32(reader["user_id"]);
                        MainForm.loggedInUserLastname = reader["last_name"].ToString();

                        dialog.setResult("Login successfully!", Properties.Resources.check_icon);
                        DialogResult result = dialog.ShowDialog(this);

                        switch (role)
                        {
                            case 1: // admin
                                if (result == DialogResult.OK)
                                {
                                    MainForm.Instance.OpenChildForm(new AdminDashboard());
                                }
                                break;
                            case 2: // doctor
                                if (result == DialogResult.OK)
                                {
                                    MainForm.Instance.OpenChildForm(new DoctorAssignedPatients());
                                }
                                break;
                            case 3: // nurse
                                if (result == DialogResult.OK)
                                {
                                    MainForm.Instance.OpenChildForm(new PatientsCheckUpForm());
                                }
                                break;
                        }

                    }
                }
                else
                {
                    SmallInfoDialog dialog = new SmallInfoDialog();
                    dialog.setResult("User not found.", Properties.Resources.cross_icon);
                    DialogResult result = dialog.ShowDialog(this);
                }
            }
            else
            {
                SmallInfoDialog dialog = new SmallInfoDialog();
                dialog.setResult("Fill all the boxes.", Properties.Resources.warning_icon);
                DialogResult result = dialog.ShowDialog(this);
            }
        }

        private void btn_registerHere_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new RegisterForm());
        }

        private void btn_resetPassword_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new ResetPasswordForm());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtB_username.Text = "JDeAsis";
            txtB_password.Text = "Pass123`";
        }
    }
}
