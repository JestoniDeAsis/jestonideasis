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
        private List<DoctorScheduleInfo> allDoctors = new List<DoctorScheduleInfo>();
        public DocSched()
        {
            InitializeComponent();
        }

        private void DocSched_Load(object sender, EventArgs e)
        {
            lbl_adminLastName.Text = MainForm.loggedInUserLastname;
            LoadDoctorsScheduleAndFees();
            LoadDoctorsToComboBox();
        }

        private void LoadDoctorsToComboBox()
        {
            allDoctors.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                SELECT 
                    u.user_id,
                    CONCAT('Dr. ', up.first_name, ' ', up.last_name) AS full_name,
                    up.working_time_start,
                    up.working_time_end,
                    ra.room_id
                FROM users u
                INNER JOIN user_profile up ON u.user_id = up.user_id
                LEFT JOIN room_assignment ra ON u.user_id = ra.doctor_id
                WHERE u.role_id = 2 AND u.is_activated = 1
                ORDER BY full_name ASC;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        allDoctors.Add(new DoctorScheduleInfo
                        {
                            UserID = reader["user_id"].ToString(),
                            FullName = reader["full_name"].ToString(),
                            Room = reader["room_id"] != DBNull.Value ? reader["room_id"].ToString() : "",
                            StartTime = reader.GetTimeSpan("working_time_start"),
                            EndTime = reader.GetTimeSpan("working_time_end")
                        });
                    }
                }
            }

            // bind to ComboBox
            cmbB_doctorNames.DataSource = null;
            cmbB_doctorNames.Items.Clear();

            cmbB_doctorNames.DisplayMember = "FullName";
            cmbB_doctorNames.ValueMember = "UserID";
            cmbB_doctorNames.DataSource = allDoctors;
        }

        private void LoadDoctorsScheduleAndFees()
        {
            try
            {
                List<DoctorScheduleInfo> morningDoctors = GetDoctorsByShift("08:00:00", "12:00:00");
                List<DoctorScheduleInfo> afternoonDoctors = GetDoctorsByShift("13:00:00", "17:00:00");

                // Morning shift
                BindDoctorToControls(morningDoctors, 0, docOnDuty1, specialty1, room1, checkupFee1);
                BindDoctorToControls(morningDoctors, 1, docOnDuty2, specialty2, room2, checkupFee2);
                BindDoctorToControls(morningDoctors, 2, docOnDuty3, specialty3, room3, checkupFee3);

                // Afternoon shift
                BindDoctorToControls(afternoonDoctors, 0, docOnDuty4, specialty4, room4, checkupFee4);
                BindDoctorToControls(afternoonDoctors, 1, docOnDuty5, specialty5, room5, checkupFee5);
                BindDoctorToControls(afternoonDoctors, 2, docOnDuty6, specialty6, room6, checkupFee6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading doctor schedule and fees:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private readonly string connectionString = "Server=localhost;Database=vital_health;Uid=root;Pwd=;";
        private List<DoctorScheduleInfo> GetDoctorsByShift(string startTime, string endTime)
        {
            List<DoctorScheduleInfo> doctors = new List<DoctorScheduleInfo>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                //bool hasCheckupFeeColumn = CheckIfCheckupFeeColumnExists(conn);
                string query = "";

                query = @"
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
                        ra.room_id,
                        up.working_time_start,
                        up.working_time_end
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

                                FullName = reader["full_name"]?.ToString() ?? "N/A",
                                Specialty = reader["specialty_name"]?.ToString() ?? "N/A",

                                CheckupFee = reader["checkup_fee"] != DBNull.Value
                                ? "₱" + Convert.ToDecimal(reader["checkup_fee"]).ToString("N2")
                                : "N/A",

                                Room = reader["room_id"] != DBNull.Value
                                ? reader["room_id"].ToString()
                                : "",

                                StartTime = reader.GetTimeSpan("working_time_start"),
                                EndTime = reader.GetTimeSpan("working_time_end")
                            };

                            doctors.Add(doctor);
                        }
                    }
                }
            }

            return doctors;
        }


        private void BindDoctorToControls(
            List<DoctorScheduleInfo> doctors,
            int index,
            Label doctorLabel,
            Label specialtyLabel,
            Label roomLabel,
            Label feeLabel) // ✅ ADD THIS
        {
            if (index < doctors.Count)
            {
                doctorLabel.Text = doctors[index].FullName;
                specialtyLabel.Text = doctors[index].Specialty;
                roomLabel.Text = doctors[index].Room;
                feeLabel.Text = doctors[index].CheckupFee; // ✅ DISPLAY FEE
            }
            else
            {
                doctorLabel.Text = "No doctor assigned";
                specialtyLabel.Text = "-";
                roomLabel.Text = "-";
                feeLabel.Text = "-";
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

            public TimeSpan StartTime { get; set; }
            public TimeSpan EndTime { get; set; }

            public override string ToString()
            {
                return FullName; // 🔥 FORCE ComboBox to display name
            }
        }

        private void cmbB_doctorNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbB_doctorNames.SelectedItem is DoctorScheduleInfo selectedDoctor)
            {
                // ✅ ROOM
                txtB_room.Text = selectedDoctor.Room;

                // ✅ SHIFT (convert from 24hr → your combo text)
                if (selectedDoctor.StartTime == TimeSpan.FromHours(8) &&
                    selectedDoctor.EndTime == TimeSpan.FromHours(12))
                {
                    cmbB_shift.SelectedItem = "8:00am - 12:00pm";
                }
                else if (selectedDoctor.StartTime == TimeSpan.FromHours(13) &&
                         selectedDoctor.EndTime == TimeSpan.FromHours(17))
                {
                    cmbB_shift.SelectedItem = "1:00pm - 5:00pm";
                }
                else
                {
                    cmbB_shift.SelectedIndex = -1; // unknown shift
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (cmbB_doctorNames.SelectedItem is not DoctorScheduleInfo selectedDoctor)
                return;

            var db = new MySqlConnection(connectionString);
            db.Open();

            using var transaction = db.BeginTransaction();

            try
            {
                string doctorId = selectedDoctor.UserID;

                // =============================
                // ✅ DETERMINE NEW SHIFT
                // =============================
                string selectedShift = cmbB_shift.SelectedItem?.ToString();

                TimeSpan newStart, newEnd;

                if (selectedShift == "8:00am - 12:00pm")
                {
                    newStart = TimeSpan.FromHours(8);
                    newEnd = TimeSpan.FromHours(12);
                }
                else if (selectedShift == "1:00pm - 5:00pm")
                {
                    newStart = TimeSpan.FromHours(13);
                    newEnd = TimeSpan.FromHours(17);
                }
                else
                {
                    MessageBox.Show("Invalid shift selected.");
                    return;
                }

                // =============================
                // ✅ CHECK IF SHIFT CHANGED
                // =============================
                bool shiftChanged = selectedDoctor.StartTime != newStart ||
                                    selectedDoctor.EndTime != newEnd;

                if (shiftChanged)
                {
                    string countQuery = @"
                SELECT COUNT(*) 
                FROM users u
                INNER JOIN user_profile up ON u.user_id = up.user_id
                WHERE u.role_id = 2
                  AND u.is_activated = 1
                  AND up.working_time_start = @start
                  AND up.working_time_end = @end";

                    using var countCmd = new MySqlCommand(countQuery, db, transaction);
                    countCmd.Parameters.AddWithValue("@start", newStart);
                    countCmd.Parameters.AddWithValue("@end", newEnd);

                    int count = Convert.ToInt32(countCmd.ExecuteScalar());

                    if (count >= 3)
                    {
                        MessageBox.Show("This shift already has 3 active doctors.");
                        transaction.Rollback();
                        return;
                    }
                }

                // =============================
                // ✅ CHECK DUPLICATE SPECIALTY IN SHIFT
                // =============================
                string specialtyCheckQuery = @"
                SELECT COUNT(*)
                FROM users u
                INNER JOIN user_profile up ON u.user_id = up.user_id
                LEFT JOIN doctor_specialty dspec ON u.user_id = dspec.user_id
                WHERE u.role_id = 2
                    AND u.is_activated = 1
                    AND up.working_time_start = @start
                    AND up.working_time_end = @end
                    AND dspec.specialty_id = (
                        SELECT specialty_id 
                        FROM doctor_specialty 
                        WHERE user_id = @docId
                        LIMIT 1
                    )
                    AND u.user_id != @docId";

                using var specCmd = new MySqlCommand(specialtyCheckQuery, db, transaction);
                specCmd.Parameters.AddWithValue("@start", newStart);
                specCmd.Parameters.AddWithValue("@end", newEnd);
                specCmd.Parameters.AddWithValue("@docId", doctorId);

                int specialtyCount = Convert.ToInt32(specCmd.ExecuteScalar());

                if (specialtyCount > 0)
                {
                    MessageBox.Show("A doctor with the same specialty is already assigned to this shift.");
                    transaction.Rollback();
                    return;
                }

                // =============================
                // ✅ VALIDATE ROOM
                // =============================
                string roomText = txtB_room.Text.Trim();

                if (!string.IsNullOrEmpty(roomText))
                {
                    if (!int.TryParse(roomText, out int roomNumber))
                    {
                        MessageBox.Show("Room must be a valid number.");
                        transaction.Rollback();
                        return;
                    }

                    // check if room already taken
                    string roomCheckQuery = @"
                SELECT COUNT(*) 
                FROM room_assignment
                WHERE room_id = @room
                  AND doctor_id != @docId";

                    using var roomCmd = new MySqlCommand(roomCheckQuery, db, transaction);
                    roomCmd.Parameters.AddWithValue("@room", roomNumber);
                    roomCmd.Parameters.AddWithValue("@docId", doctorId);

                    int roomCount = Convert.ToInt32(roomCmd.ExecuteScalar());

                    if (roomCount > 0)
                    {
                        MessageBox.Show("Room is already assigned to another doctor.");
                        transaction.Rollback();
                        return;
                    }

                    // =============================
                    // ✅ UPDATE ROOM
                    // =============================
                    string updateRoomQuery = @"
                INSERT INTO room_assignment (doctor_id, room_id)
                VALUES (@docId, @room)
                ON DUPLICATE KEY UPDATE room_id = @room";

                    using var updateRoomCmd = new MySqlCommand(updateRoomQuery, db, transaction);
                    updateRoomCmd.Parameters.AddWithValue("@docId", doctorId);
                    updateRoomCmd.Parameters.AddWithValue("@room", roomNumber);
                    updateRoomCmd.ExecuteNonQuery();
                }

                // =============================
                // ✅ UPDATE SHIFT
                // =============================
                string updateShiftQuery = @"
            UPDATE user_profile
            SET working_time_start = @start,
                working_time_end = @end
            WHERE user_id = @docId";

                using var shiftCmd = new MySqlCommand(updateShiftQuery, db, transaction);
                shiftCmd.Parameters.AddWithValue("@start", newStart);
                shiftCmd.Parameters.AddWithValue("@end", newEnd);
                shiftCmd.Parameters.AddWithValue("@docId", doctorId);

                shiftCmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("Doctor updated successfully!");

                // =============================
                // 🔄 RELOAD FORM
                // =============================
                MainForm.Instance.OpenChildForm(new DocSched());
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}
