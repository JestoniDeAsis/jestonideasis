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

        public void btnAccept_Click(object sender, EventArgs e)
        {
            updateStaffStatus(1);
        }

        public void btnDecline_Click(object sender, EventArgs e)
        {
            updateStaffStatus(0);
        }

        public void btnBlock_Click(object sender, EventArgs e)
        {
            updateStaffStatus(2);
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(this.Tag);

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=vital_health;user=root;password=;"))
            {
                conn.Open();
                string query = @"
                SELECT 
                    CONCAT(up.first_name, ' ', up.last_name) AS fullname,
                    u.user_id,
                    ur.role_name,
                    IFNULL(ds.specialty_name, 'N/A') AS specialty,
                    CASE 
                        WHEN u.is_activated = 1 THEN 'Active' 
                        WHEN u.is_activated = 0 THEN 'Pending Approval'
                        ELSE 'Blocked' 
                    END AS status,
                    u.username,
                    up.contact_number,
                    up.working_time_start,
                    up.working_time_end
                FROM users u
                JOIN user_profile up ON u.user_id = up.user_id
                JOIN user_role ur ON u.role_id = ur.role_id
                LEFT JOIN doctor_specialty dsp ON u.user_id = dsp.user_id
                LEFT JOIN doctor_specialties ds ON dsp.specialty_id = ds.specialty_id
                WHERE u.user_id = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ViewInfo form = new ViewInfo(
                            reader["fullname"].ToString(),
                            reader["user_id"].ToString(),
                            reader["role_name"].ToString(),
                            reader["specialty"].ToString(),
                            reader["status"].ToString(),
                            reader["username"].ToString(),
                            reader["contact_number"].ToString(),
                            Convert.ToInt32(reader["user_id"]),
                            reader["working_time_start"].ToString(),
                            reader["working_time_end"].ToString()
                        );
                        form.Tag = this;
                        form.ShowDialog();
                    }
                }
            }
        }
    }
}
