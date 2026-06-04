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
using VitalHealth.Forms.Authentication;

namespace VitalHealth.Forms.Admin
{
    public partial class ViewInfo : Form
    {
        private int _userId;

        public ViewInfo(string fullname, string employeeId, string role, string specialization, string status, string username, string contact, int userId, string workStart, string workEnd)
        {
            InitializeComponent();

            cmbWorkingHours.Items.Clear();

            cmbWorkingHours.Items.Add(new ShiftItem
            {
                Display = "8:00 am - 12:00 pm",
                StartTime = "08:00:00",
                EndTime = "12:00:00"
            });

            cmbWorkingHours.Items.Add(new ShiftItem
            {
                Display = "1:00 pm - 5:00 pm",
                StartTime = "13:00:00",
                EndTime = "17:00:00"
            });

            foreach (ShiftItem item in cmbWorkingHours.Items)
            {
                if (item.StartTime == workStart && item.EndTime == workEnd)
                {
                    cmbWorkingHours.SelectedIndex = cmbWorkingHours.Items.IndexOf(item);
                    break;
                }
            }

            _userId = userId;

            lblFullname.Text = fullname;
            lblEmployeeID.Text = employeeId;
            lblRole.Text = role;
            lblSpecialization.Text = specialization;
            lblStatus.Text = status;
            lblUsername.Text = username;
            lblContactNumber.Text = contact;

            btnBack.Click += (s, e) => this.Close();
        }

        private void ViewInfo_Load(object sender, EventArgs e)
        {
            if (lblRole.Text.Equals("Admin") || lblRole.Text.Equals("Nurse"))
            {
                btn_update.Visible = false;
                cmb_specialization.Visible = false;
                lblSpecialization.Visible = true;
            }
            else
            {
                btn_update.Visible = true;
                cmb_specialization.Visible = true;
                lblSpecialization.Visible = false;
            }
            LoadSpecializations();
        }

        private void LoadSpecializations()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=vital_health;user=root;password=;"))
                {
                    conn.Open();

                    // 1. Load current user's specialty
                    int currentSpecialtyId = -1;

                    string currentQuery = @"
                    SELECT specialty_id 
                    FROM doctor_specialty 
                    WHERE user_id = @id
                    LIMIT 1";

                    MySqlCommand currentCmd = new MySqlCommand(currentQuery, conn);
                    currentCmd.Parameters.AddWithValue("@id", _userId);

                    object result = currentCmd.ExecuteScalar();
                    if (result != null)
                        currentSpecialtyId = Convert.ToInt32(result);

                    // 2. Load all specialties
                    string query = @"
                    SELECT specialty_id, specialty_name 
                    FROM doctor_specialties
                    ORDER BY specialty_name";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmb_specialization.Items.Clear();

                        while (reader.Read())
                        {
                            var item = new ComboBoxItem
                            {
                                Text = reader["specialty_name"].ToString(),
                                Value = Convert.ToInt32(reader["specialty_id"])
                            };

                            cmb_specialization.Items.Add(item);

                            // select current specialty
                            if (Convert.ToInt32(reader["specialty_id"]) == currentSpecialtyId)
                            {
                                cmb_specialization.SelectedItem = item;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading specialization: " + ex.Message);
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (_userId <= 0)
                {
                    MessageBox.Show("Invalid user.");
                    return;
                }

                if (cmbWorkingHours.SelectedItem == null || cmb_specialization.SelectedItem == null)
                {
                    MessageBox.Show("Please select working hours and specialization.");
                    return;
                }

                if (cmbWorkingHours.SelectedItem is not ShiftItem shift)
                {
                    MessageBox.Show("Invalid shift selected.");
                    return;
                }

                var selectedSpec = cmb_specialization.SelectedItem as ComboBoxItem;
                if (selectedSpec == null)
                {
                    MessageBox.Show("Invalid specialization selected.");
                    return;
                }

                string startTime = shift.StartTime;
                string endTime = shift.EndTime;
                int specialtyId = selectedSpec.Value;

                using (MySqlConnection conn = new MySqlConnection("server=localhost;database=vital_health;user=root;password=;"))
                {
                    conn.Open();

                    // =========================================================
                    // STEP 1: CHECK IF USER IS ACTIVE
                    // =========================================================
                    string statusQuery = @"
                    SELECT is_activated 
                    FROM users 
                    WHERE user_id = @id";

                    MySqlCommand statusCmd = new MySqlCommand(statusQuery, conn);
                    statusCmd.Parameters.AddWithValue("@id", _userId);

                    int isActive = Convert.ToInt32(statusCmd.ExecuteScalar());

                    // =========================================================
                    // STEP 2: SPECIALTY CHECK (ONLY IF ACTIVE)
                    // =========================================================
                    if (isActive == 1)
                    {
                        string specCheck = @"
                        SELECT COUNT(*)
                        FROM users u
                        JOIN doctor_specialty ds ON u.user_id = ds.user_id
                        WHERE u.is_activated = 1
                          AND ds.specialty_id = @spec
                          AND u.user_id != @id";

                        MySqlCommand specCmd = new MySqlCommand(specCheck, conn);
                        specCmd.Parameters.AddWithValue("@spec", specialtyId);
                        specCmd.Parameters.AddWithValue("@id", _userId);

                        int specExists = Convert.ToInt32(specCmd.ExecuteScalar());

                        if (specExists > 0)
                        {
                            MessageBox.Show("An active doctor already uses this specialization.");
                            return;
                        }
                    }

                    // =========================================================
                    // STEP 3: SHIFT LIMIT CHECK (MAX 3 ACTIVE DOCTORS)
                    // =========================================================
                    string shiftCheck = @"
                    SELECT COUNT(DISTINCT u.user_id)
                    FROM users u
                    JOIN user_profile up ON u.user_id = up.user_id
                    WHERE u.is_activated = 1
                      AND u.role_id = 2
                      AND u.user_id != @id
                      AND TIME(up.working_time_start) = TIME(@start)
                      AND TIME(up.working_time_end) = TIME(@end)";

                    MySqlCommand shiftCmd = new MySqlCommand(shiftCheck, conn);
                    shiftCmd.Parameters.AddWithValue("@id", _userId);
                    shiftCmd.Parameters.AddWithValue("@start", startTime.Trim());
                    shiftCmd.Parameters.AddWithValue("@end", endTime.Trim());

                    int shiftCount = Convert.ToInt32(shiftCmd.ExecuteScalar());

                    if (shiftCount >= 3)
                    {
                        MessageBox.Show("This shift already has 3 active doctors.");
                        return;
                    }

                    // =========================================================
                    // STEP 4: UPDATE WORKING HOURS
                    // =========================================================
                    string updateProfile = @"
                    UPDATE user_profile
                    SET working_time_start = @start,
                        working_time_end = @end
                    WHERE user_id = @id";

                    MySqlCommand cmd1 = new MySqlCommand(updateProfile, conn);
                    cmd1.Parameters.AddWithValue("@start", startTime);
                    cmd1.Parameters.AddWithValue("@end", endTime);
                    cmd1.Parameters.AddWithValue("@id", _userId);

                    cmd1.ExecuteNonQuery();

                    // =========================================================
                    // STEP 5: UPDATE SPECIALTY
                    // =========================================================
                    string deleteOld = @"
                    DELETE FROM doctor_specialty 
                    WHERE user_id = @id";

                    MySqlCommand cmd2 = new MySqlCommand(deleteOld, conn);
                    cmd2.Parameters.AddWithValue("@id", _userId);
                    cmd2.ExecuteNonQuery();

                    string insertNew = @"
                    INSERT INTO doctor_specialty (user_id, specialty_id)
                    VALUES (@id, @spec)";

                    MySqlCommand cmd3 = new MySqlCommand(insertNew, conn);
                    cmd3.Parameters.AddWithValue("@id", _userId);
                    cmd3.Parameters.AddWithValue("@spec", specialtyId);

                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Doctor information updated successfully!");
                    MainForm.Instance.OpenChildForm(new ManageStaff());
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: " + ex.Message);
            }
        }

        public class ShiftItem
        {
            public string Display { get; set; }
            public string StartTime { get; set; }
            public string EndTime { get; set; }

            public override string ToString()
            {
                return Display;
            }
        }
    }



}
