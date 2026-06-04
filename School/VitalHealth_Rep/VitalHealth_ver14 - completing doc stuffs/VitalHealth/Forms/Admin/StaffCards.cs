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
    public partial class StaffCards : UserControl
    {
        public StaffCards()
        {
            InitializeComponent();
        }


        private void updateStaffStatus(int newStatus)
        {
            if (this.Tag == null)
            {
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=vital_health;user=root;password=;"))
                {
                    conn.Open();

                    string query = "UPDATE users SET is_activated = @status WHERE user_id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", this.Tag.ToString());


                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string action = newStatus == 1 ? "Approved" : "Updated";
                        MessageBox.Show($"Staff successfully {action}!");

                        Form parent = this.FindForm();
                        if (parent is ManageStaff mainForm)
                        {
                            mainForm.loadStaffCards();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff status: " + ex.Message);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            updateStaffStatus(1);
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            updateStaffStatus(0);
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            updateStaffStatus(0);
        }
    }
}
