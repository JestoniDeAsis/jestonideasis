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
    using VitalHealth.Forms.Dialogs;
    using VitalHealth.Forms.Nurse;

    namespace VitalHealth.Forms.Admin
    {
        public partial class DocSched : Form
        {
            public DocSched()
            {
                InitializeComponent();
            }

            private void DocSched_Load(object sender, EventArgs e)
            {
                lbl_adminLastName.Text = MainForm.loggedInUserLastname;
                ConfigureGrid();
                cmb_filterShift.SelectedIndex = 0;
                LoadDoctorsScheduleAndFees();

                dtgView_docSched.Grid.CellContentClick += dtgView_docSched_CellContentClick;
                dtgView_docSched.Grid.CellBeginEdit += dtgView_docSched_CellBeginEdit;
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


            private readonly string connectionString = "Server=localhost;Database=vital_health;Uid=root;Pwd=;";
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

            private void btnSalesDashboard_Click(object sender, EventArgs e)
            {
                MainForm.Instance.OpenChildForm(new AdminDashboard());
            }

            private void btnManageStaff_Click(object sender, EventArgs e)
            {
                MainForm.Instance.OpenChildForm(new ManageStaff());
            }

            private void btnPatientsRec_Click(object sender, EventArgs e)
            {
                MainForm.Instance.OpenChildForm(new NewAdminPatientPastRecord());
            }

            public class DoctorScheduleInfo
            {
                public string UserID { get; set; }
                public string FullName { get; set; }
                public string Specialty { get; set; }
                public string CheckupFee { get; set; }
                public string Room { get; set; }
            }

        private void ConfigureGrid()
        {
            var grid = dtgView_docSched.Grid;

            grid.Columns.Clear();
            grid.Rows.Clear();

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;

            // default behavior
            //grid.ReadOnly = true;

            grid.Columns.Add("UserID", "User ID");
            grid.Columns.Add("Time", "Time");
            grid.Columns.Add("Name", "Name");
            grid.Columns.Add("Specialty", "Specialty");
            grid.Columns.Add("Checkup Fee", "Checkup Fee");

            grid.Columns.Add("Room", "Room");

            var btnCol = new DataGridViewButtonColumn();
            btnCol.Name = "UpdateRoom";
            btnCol.HeaderText = "Action";
            btnCol.Text = "Update";
            btnCol.UseColumnTextForButtonValue = true;

            grid.Columns.Add(btnCol);
        }

        private void dtgView_docSched_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dtgView_docSched.Grid.Columns[e.ColumnIndex].Name != "Room")
            {
                e.Cancel = true;
            }
        }

        private void dtgView_docSched_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = dtgView_docSched.Grid;

            if (e.RowIndex < 0)
                return;

            if (grid.Columns[e.ColumnIndex].Name != "UpdateRoom")
                return;

            string userId = grid.Rows[e.RowIndex].Cells["UserID"].Value?.ToString();
            grid.EndEdit(); // forces latest value
            string room = grid.Rows[e.RowIndex].Cells["Room"].Value?.ToString();

            if (!int.TryParse(room, out int roomNumber))
            {
                MessageBox.Show("Room must be a number.");
                return;
            }

            if (IsRoomAlreadyUsed(roomNumber, userId))
            {
                MessageBox.Show("This room is already assigned to another doctor.");
                return;
            }

            SaveOrUpdateRoom(userId, roomNumber);

            MessageBox.Show("Room updated successfully!");
        }

        private bool IsRoomAlreadyUsed(int roomId, string currentDoctorId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT COUNT(*) 
                FROM room_assignment 
                WHERE room_id = @roomId 
                  AND doctor_id != @doctorId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@roomId", roomId);
                    cmd.Parameters.AddWithValue("@doctorId", currentDoctorId);

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        private void SaveOrUpdateRoom(string doctorId, int roomId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = @"
            SELECT COUNT(*) 
            FROM room_assignment 
            WHERE doctor_id = @doctorId";

                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@doctorId", doctorId);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    string query;

                    if (exists > 0)
                    {
                        query = @"
                    UPDATE room_assignment 
                    SET room_id = @roomId 
                    WHERE doctor_id = @doctorId";
                    }
                    else
                    {
                        query = @"
                    INSERT INTO room_assignment (doctor_id, room_id)
                    VALUES (@doctorId, @roomId)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@doctorId", doctorId);
                        cmd.Parameters.AddWithValue("@roomId", roomId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void cmb_filterShift_SelectedIndexChanged(object sender, EventArgs e)
            {
                string selected = cmb_filterShift.SelectedItem?.ToString() ?? "All";
                LoadDoctorsScheduleAndFees(selected);
            }
        }
    }
