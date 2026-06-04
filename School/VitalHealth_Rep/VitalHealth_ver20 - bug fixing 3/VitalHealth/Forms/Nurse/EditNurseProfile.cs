using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;
using VitalHealth.Forms.Doctor;

namespace VitalHealth.Forms.Nurse
{
    public partial class EditNurseProfile : Form
    {
        public EditNurseProfile()
        {
            InitializeComponent();
        }
        private void EditNurseProfile_Load(object sender, EventArgs e)
        {
            var db = new Data.DBConnection();
            using var conn = db.GetConnection();
            conn.Open();

            string query = @"
            SELECT 
                u.user_id,
                u.username,
                up.first_name,
                up.middle_name,
                up.last_name,
                up.name_suffix,
                up.contact_number
            FROM users u
            INNER JOIN user_profile up ON u.user_id = up.user_id
            WHERE u.user_id = @user_id";

            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@user_id", MainForm.loggedInUserID);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Labels
                        lbl_employeeID.Text = reader["user_id"].ToString();
                        lbl_username.Text = reader["username"].ToString();

                        // Textboxes
                        txtB_firstname.Text = reader["first_name"].ToString();
                        txtB_middlename.Text = reader["middle_name"]?.ToString();
                        txtB_lastname.Text = reader["last_name"].ToString();
                        txtB_contanctNum.Text = reader["contact_number"]?.ToString();

                        // Suffix (ComboBox)
                        string suffix = reader["name_suffix"]?.ToString();

                        if (!string.IsNullOrEmpty(suffix))
                        {
                            rcmbBox_suffix.SelectedItem = suffix;
                        }
                        else
                        {
                            rcmbBox_suffix.SelectedIndex = -1;
                        }
                    }
                }
            }
        }

        private void backNursePage_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new PatientsCheckUpForm());
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var db = new Data.DBConnection();

            using var conn = db.GetConnection();
            conn.Open();

            try
            {
                string query = @"
                UPDATE user_profile
                SET 
                    first_name = @first_name,
                    middle_name = @middle_name,
                    last_name = @last_name,
                    name_suffix = @suffix,
                    contact_number = @contact
                WHERE user_id = @user_id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first_name", txtB_firstname.Text);
                    cmd.Parameters.AddWithValue("@middle_name",
                        string.IsNullOrWhiteSpace(txtB_middlename.Text) ? DBNull.Value : txtB_middlename.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtB_lastname.Text);
                    cmd.Parameters.AddWithValue("@suffix",
                        string.IsNullOrWhiteSpace(rcmbBox_suffix.Text) ? DBNull.Value : rcmbBox_suffix.Text);
                    cmd.Parameters.AddWithValue("@contact", txtB_contanctNum.Text);
                    cmd.Parameters.AddWithValue("@user_id", MainForm.loggedInUserID);

                    cmd.ExecuteNonQuery();
                }

                MainForm.loggedInUserLastname = txtB_lastname.Text;

                MessageBox.Show("Profile updated successfully!");
                MainForm.Instance.OpenChildForm(new PatientsCheckUpForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            MainForm.userRole = "Nurse";
            MainForm.Instance.OpenChildForm(new ChangePassword());
        }
    }
}
