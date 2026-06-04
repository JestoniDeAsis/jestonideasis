using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;

namespace VitalHealth.Forms.Nurse
{
    public partial class SchedAndFee : Form
    {
        private readonly string connectionString = "Server=localhost;Database=vital_health;Uid=root;Pwd=;";

        public SchedAndFee()
        {
            InitializeComponent();
        }
        private bool _patientHistoryExpanded = false;
        private void SchedAndFee_Load(object sender, EventArgs e)
        {
            lbl_nurseLastName.Text = MainForm.loggedInUserLastname;
            LoadDoctorsScheduleAndFees();

            btn_pastRecords.Visible = false;
            btn_missedCheckups.Visible = false;
            button3.Text = "Patient History  ▼"; // ✅ default state
        }

        private void LoadDoctorsScheduleAndFees()
        {
            try
            {
                List<DoctorScheduleInfo> morningDoctors = GetDoctorsByShift("08:00:00", "12:00:00");
                List<DoctorScheduleInfo> afternoonDoctors = GetDoctorsByShift("13:00:00", "17:00:00");

                // Morning shift
                BindDoctorToControls(morningDoctors, 0, docOnDuty1, specialty1, checkupFee1);
                BindDoctorToControls(morningDoctors, 1, docOnDuty2, specialty2, checkupFee2);
                BindDoctorToControls(morningDoctors, 2, docOnDuty3, specialty3, checkupFee3);

                // Afternoon shift
                BindDoctorToControls(afternoonDoctors, 0, docOnDuty4, specialty4, checkupFee4);
                BindDoctorToControls(afternoonDoctors, 1, docOnDuty5, specialty5, checkupFee5);
                BindDoctorToControls(afternoonDoctors, 2, docOnDuty6, specialty6, checkupFee6);
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

        private List<DoctorScheduleInfo> GetDoctorsByShift(string startTime, string endTime)
        {
            List<DoctorScheduleInfo> doctors = new List<DoctorScheduleInfo>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                bool hasCheckupFeeColumn = CheckIfCheckupFeeColumnExists(conn);
                string query = "";

                if (hasCheckupFeeColumn)
                {
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
                            ds.checkup_fee
                        FROM users u
                        INNER JOIN user_profile up ON u.user_id = up.user_id
                        LEFT JOIN doctor_specialty dspec ON u.user_id = dspec.user_id
                        LEFT JOIN doctor_specialties ds ON dspec.specialty_id = ds.specialty_id
                        WHERE u.role_id = 2
                          AND up.working_time_start = @startTime
                          AND up.working_time_end = @endTime
                        ORDER BY full_name ASC
                        LIMIT 3;";
                }
                else
                {
                    query = @"
                        SELECT 
                            u.user_id,
                            TRIM(
                                CONCAT(
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
                            NULL AS checkup_fee
                        FROM users u
                        INNER JOIN user_profile up ON u.user_id = up.user_id
                        LEFT JOIN doctor_specialty dspec ON u.user_id = dspec.user_id
                        LEFT JOIN doctor_specialties ds ON dspec.specialty_id = ds.specialty_id
                        WHERE u.role_id = 2
                          AND up.working_time_start = @startTime
                          AND up.working_time_end = @endTime
                        ORDER BY full_name ASC
                        LIMIT 3;";
                }

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
                                FullName = reader["full_name"] != DBNull.Value ? reader["full_name"].ToString() ?? "N/A" : "N/A",
                                Specialty = reader["specialty_name"] != DBNull.Value ? reader["specialty_name"].ToString() ?? "N/A" : "N/A",
                                CheckupFee = reader["checkup_fee"] != DBNull.Value
                                    ? "₱" + Convert.ToDecimal(reader["checkup_fee"]).ToString("N2")
                                    : "N/A"
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

        private void BindDoctorToControls(
            List<DoctorScheduleInfo> doctors,
            int index,
            Label doctorLabel,
            Label specialtyLabel,
            Label feeLabel)
        {
            if (index < doctors.Count)
            {
                doctorLabel.Text = doctors[index].FullName;
                specialtyLabel.Text = doctors[index].Specialty;
                feeLabel.Text = doctors[index].CheckupFee;
            }
            else
            {
                doctorLabel.Text = "No doctor assigned";
                specialtyLabel.Text = "-";
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

        private void btn_checkupForm_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new PatientsCheckUpForm());
        }

        private void btn_todaysPatient_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new TodaysPatients());
        }

        private void btn_pastRecords_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        }

        private void btn_missedCheckups_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new MissedCheckups());
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new EditNurseProfile());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _patientHistoryExpanded = !_patientHistoryExpanded;

            button3.Text = _patientHistoryExpanded
                ? "Patient History  ▲"
                : "Patient History  ▼";

            btn_pastRecords.Visible = _patientHistoryExpanded;
            btn_missedCheckups.Visible = _patientHistoryExpanded;

            btn_pastRecords.BringToFront();
            btn_missedCheckups.BringToFront();
        }

        private void bttn_pastRecords_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new NursePatientPastRecords());
        }

        private void bttn_missedCheckups_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new MissedCheckups());
        }
    }

    public class DoctorScheduleInfo
    {
        public string FullName { get; set; } = "";
        public string Specialty { get; set; } = "";
        public string CheckupFee { get; set; } = "";
    }
}