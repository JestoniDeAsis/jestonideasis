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
using VitalHealth.Forms.Nurse;

namespace VitalHealth.Forms.Doctor
{
    public partial class DoctorSchedule : Form
    {
        private readonly string connectionString = "Server=localhost;Database=vital_health;Uid=root;Pwd=;";
        public DoctorSchedule()
        {
            InitializeComponent();
        }

        private void DoctorSchedule_Load(object sender, EventArgs e)
        {
            lbl_doctorLastName.Text = MainForm.loggedInUserLastname;
            ConfigureGrid();
            cmb_filterShift.SelectedIndex = 0;
            LoadDoctorsScheduleAndFees();
        }

        private string FormatTimeRange(string start, string end)
        {
            DateTime startTime = DateTime.Parse(start);
            DateTime endTime = DateTime.Parse(end);

            return $"{startTime:hh:mm tt} - {endTime:hh:mm tt}";
        }

        private void LoadDoctorsScheduleAndFees(string filter = "All")
        {
            var grid = dtgView_docSched.Grid;
            grid.Rows.Clear();

            if (filter == "All" || filter == "Morning")
            {
                var morningDoctors = GetDoctorsByShift("08:00:00", "12:00:00");
                string morningTime = FormatTimeRange("08:00:00", "12:00:00");

                foreach (var doc in morningDoctors)
                {
                    grid.Rows.Add(
                        doc.UserID,
                        morningTime,
                        doc.FullName,
                        doc.Specialty,
                        doc.CheckupFee,
                        doc.Room
                    );
                }
            }

            if (filter == "All" || filter == "Afternoon")
            {
                var afternoonDoctors = GetDoctorsByShift("13:00:00", "17:00:00");
                string afternoonTime = FormatTimeRange("13:00:00", "17:00:00");

                foreach (var doc in afternoonDoctors)
                {
                    grid.Rows.Add(
                        doc.UserID,
                        afternoonTime,
                        doc.FullName,
                        doc.Specialty,
                        doc.CheckupFee,
                        doc.Room
                    );
                }
            }
        }


        private List<DoctorScheduleInfo> GetDoctorsByShift(string startTime, string endTime)
        {
            List<DoctorScheduleInfo> doctors = new List<DoctorScheduleInfo>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                bool hasCheckupFeeColumn = CheckIfCheckupFeeColumnExists(conn);

                string query = hasCheckupFeeColumn ? @"
                    SELECT 
                        u.user_id,
                        TRIM(
                            CONCAT(
                                'Dr. ',
                                up.first_name, ' ',
                                CASE 
                                    WHEN up.middle_name IS NULL OR up.middle_name = '' THEN ''
                                    ELSE CONCAT(up.middle_name, ' ')
                                END,
                                up.last_name,
                                CASE
                                    WHEN up.name_suffix IS NULL 
                                         OR up.name_suffix = '' 
                                         OR up.name_suffix = 'N/A' THEN ''
                                    ELSE CONCAT(' ', up.name_suffix)
                                END
                            )
                        ) AS full_name,
                        ds.specialty_name,
                        ds.checkup_fee,
                        ra.room_id
                    FROM users u
                    INNER JOIN user_profile up ON u.user_id = up.user_id
                    LEFT JOIN doctor_specialty dspec ON u.user_id = dspec.user_id
                    LEFT JOIN doctor_specialties ds ON dspec.specialty_id = ds.specialty_id
                    LEFT JOIN room_assignment ra ON u.user_id = ra.doctor_id
                    WHERE u.role_id = 2
                      AND u.is_activated = 1
                      AND up.working_time_start = @startTime
                      AND up.working_time_end = @endTime
                    ORDER BY full_name ASC
                    LIMIT 3;"
                        :
                        @"
                    SELECT 
                        u.user_id,
                        TRIM(
                            CONCAT(
                                'Dr. ',
                                up.first_name, ' ',
                                CASE 
                                    WHEN up.middle_name IS NULL OR up.middle_name = '' THEN ''
                                    ELSE CONCAT(up.middle_name, ' ')
                                END,
                                up.last_name,
                                CASE
                                    WHEN up.name_suffix IS NULL 
                                         OR up.name_suffix = '' 
                                         OR up.name_suffix = 'N/A' THEN ''
                                    ELSE CONCAT(' ', up.name_suffix)
                                END
                            )
                        ) AS full_name,
                        ds.specialty_name,
                        NULL AS checkup_fee,
                        ra.room_id
                    FROM users u
                    INNER JOIN user_profile up ON u.user_id = up.user_id
                    LEFT JOIN doctor_specialty dspec ON u.user_id = dspec.user_id
                    LEFT JOIN doctor_specialties ds ON dspec.specialty_id = ds.specialty_id
                    LEFT JOIN room_assignment ra ON u.user_id = ra.doctor_id
                    WHERE u.role_id = 2
                      AND u.is_activated = 1
                      AND up.working_time_start = @startTime
                      AND up.working_time_end = @endTime
                    ORDER BY full_name ASC
                    LIMIT 3;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startTime", startTime);
                    cmd.Parameters.AddWithValue("@endTime", endTime);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DoctorScheduleInfo doctor = new DoctorScheduleInfo
                            {
                                UserID = reader["user_id"].ToString(),
                                FullName = reader["full_name"] != DBNull.Value ? reader["full_name"].ToString() ?? "N/A" : "N/A",
                                Specialty = reader["specialty_name"] != DBNull.Value ? reader["specialty_name"].ToString() ?? "N/A" : "N/A",
                                CheckupFee = reader["checkup_fee"] != DBNull.Value
                                ? "₱" + Convert.ToDecimal(reader["checkup_fee"]).ToString("N2")
                                : "N/A",
                                Room = reader["room_id"] != DBNull.Value
                                ? reader["room_id"].ToString()
                                : "TBA"
                            };

                            doctors.Add(doctor);
                        }
                    }
                }
            }

            return doctors;
        }

        private bool CheckIfCheckupFeeColumnExists(MySqlConnection conn)
        {
            string schemaQuery = @"
                    SELECT COUNT(*) 
                    FROM INFORMATION_SCHEMA.COLUMNS
                    WHERE TABLE_SCHEMA = 'vital_health'
                      AND TABLE_NAME = 'doctor_specialties'
                      AND COLUMN_NAME = 'checkup_fee';";

            using (MySqlCommand cmd = new MySqlCommand(schemaQuery, conn))
            {
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
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

        private void btn_assignedPatients_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorAssignedPatients());
        }

        private void btn_patientRecord_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorPatientPastRecord());
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorEditProfile());
        }

        private void ConfigureGrid()
        {
            var grid = dtgView_docSched.Grid;

            grid.Columns.Clear();
            grid.Rows.Clear();

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;

            grid.Columns.Add("UserID", "User ID");
            grid.Columns["UserID"].Visible = false;
            grid.Columns.Add("Time", "Time");
            grid.Columns.Add("Name", "Name");
            grid.Columns.Add("Specialty", "Specialty");
            grid.Columns.Add("Checkup Fee", "Checkup Fee");
            grid.Columns.Add("Room", "Room");
        }

        private void cmb_filterShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmb_filterShift.SelectedItem?.ToString() ?? "All";
            LoadDoctorsScheduleAndFees(selected);
        }
    }

    public class DoctorScheduleInfo
    {
        public string UserID { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public string CheckupFee { get; set; }
        public string Room { get; set; }
    }
}
