using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalHealth.Forms.Admin
{
    public partial class ViewInfo : Form
    {
        private int _userId;

        public ViewInfo(string fullname, string employeeId, string role, string specialization, string status, string username, string contact, int userId, string workStart, string workEnd)
        {
            InitializeComponent();

            string workingHours = $"{workStart} - {workEnd}";
            if (workingHours == "08:00:00 - 12:00:00")
                cmbWorkingHours.SelectedIndex = 0; // "8:00 am - 12:00 pm"
            else if (workingHours == "13:00:00 - 17:00:00")
                cmbWorkingHours.SelectedIndex = 1; // "1:00 pm - 5:00 pm"
            else
                cmbWorkingHours.SelectedIndex = -1;

            _userId = userId;

            lblFullname.Text = fullname;
            lblEmployeeID.Text = employeeId;
            lblRole.Text = role;
            lblSpecialization.Text = specialization;
            lblStatus.Text = status;
            lblUsername.Text = username;
            lblContactNumber.Text = contact;

            btnBack.Click += (s, e) => this.Close();

            if (userId == MainForm.loggedInUserID)
            {
                btnAccept2.Visible = false;
                btnReject.Visible = false;
                btnBlock2.Visible = false;
            }
            else if (status == "Pending Approval")
            {
                btnAccept2.Visible = true;
                btnReject.Visible = true;
                btnBlock2.Visible = false;
                btnReject.BackColor = Color.FromArgb(190, 138, 34);
            }
            else if (status == "Active")
            {
                btnAccept2.Visible = false;
                btnReject.Visible = false;
                btnBlock2.Visible = true;
                btnBlock2.Location = new Point(631, 319);
            }
            else
            {
                btnAccept2.Visible = false;
                btnReject.Visible = false;
            }

            // Wire actions
            btnAccept2.Click += (s, e) =>
            {
                if (Tag is StaffCards card)
                    card.btnAccept_Click(s, e);
                this.Close();
            };

            btnReject.Click += (s, e) =>
            {
                if (Tag is StaffCards card)
                    card.btnDecline_Click(s, e);
                this.Close();
            };

            btnBlock2.Click += (s, e) =>
            {
                if (Tag is StaffCards card)
                    card.btnBlock_Click(s, e);
                this.Close();
            };
        }

        private void UpdateStatus(int newStatus)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=vital_health;user=root;password=;"))
                {
                    conn.Open();
                    string query = "UPDATE users SET is_activated = @status WHERE user_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", _userId);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string action = newStatus == 1 ? "Approved" : "Blocked";
                        MessageBox.Show($"Staff successfully {action}!");
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ViewInfo_Load(object sender, EventArgs e)
        {

        }
    }



}
