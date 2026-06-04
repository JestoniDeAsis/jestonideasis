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

namespace VitalHealth.Forms.Admin
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lbl_adminLastName.Text = MainForm.loggedInUserLastname;

            dtpDateFrom.Value = DateTime.Now;
            dtpDateTo.Value = DateTime.Now;

            btnApply_Click(null, null);

            cmbPeriod.SelectedIndexChanged += cmbPeriod_SelectedIndexChanged;
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

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new ManageStaff());
        }

        private void btnPatientsRec_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new ViewPreviousRecords());
        }

        private void btnSchedNFee_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DocSched());
        }

        private string connStr = "server=localhost;database=vital_health;user=root;password=;";
        private void btnApply_Click(object sender, EventArgs e)
        {
            // Convert the picker values into SQL-friendly strings
            string dateStart = dtpDateFrom.Value.ToString("yyyy-MM-dd 00:00:00");
            string dateEnd = dtpDateTo.Value.ToString("yyyy-MM-dd 23:59:59");

            // Pass those strings to your helper methods
            LoadDashboardStats(dateStart, dateEnd);
            LoadSalesTable(dateStart, dateEnd);
        }

        private void LoadDashboardStats(string start, string end)
        {
            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    // Query for Total Patients
                    string qPatients = "SELECT COUNT(*) FROM patient_queue WHERE queued_at BETWEEN @start AND @end";
                    MySqlCommand cmd1 = new MySqlCommand(qPatients, conn);
                    cmd1.Parameters.AddWithValue("@start", start);
                    cmd1.Parameters.AddWithValue("@end", end);
                    lblTotalPatients.Text = cmd1.ExecuteScalar().ToString();

                    // Query for Total Sales (Sum of Walk-in fees)
                    string qSales = "SELECT IFNULL(SUM(payment_fee), 0) FROM patient_payment_data WHERE payment_at BETWEEN @start AND @end";
                    MySqlCommand cmd2 = new MySqlCommand(qSales, conn);
                    cmd2.Parameters.AddWithValue("@start", start);
                    cmd2.Parameters.AddWithValue("@end", end);
                    decimal totalSales = Convert.ToDecimal(cmd2.ExecuteScalar());
                    lblTotalSales.Text = $"₱{totalSales:N2}"; // Formats as ₱1,234.56
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stats: " + ex.Message);
            }
        }

        private void LoadSalesTable(string start, string end)
        {
            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    // Complex Join to get all info for your DataGridView
                    string query = @"
                    SELECT 
                        q.queue_number AS 'Queue Number', 
                        CONCAT(p.first_name, ' ', p.last_name) AS 'Patient Name',
                        DATE_FORMAT(q.queued_at, '%Y-%m-%d') AS 'Date',
                        DATE_FORMAT(q.queued_at, '%h:%i %p') AS 'Time Arrival',
                        CONCAT('Dr. ', up.first_name, ' ', up.last_name) AS 'Assigned Doctor',
                        ds.specialty_name AS 'Specialty',
                        ra.room_id AS 'Room Number',
                        CONCAT('₱', FORMAT(pay.payment_fee, 2)) AS 'Walk-In Fee'
                    FROM patient_queue q
                    INNER JOIN patient_data p ON q.patient_id = p.patient_id
                    INNER JOIN user_profile up ON q.doctor_id = up.user_id
                    LEFT JOIN doctor_specialty d_spec ON q.doctor_id = d_spec.user_id
                    LEFT JOIN doctor_specialties ds ON d_spec.specialty_id = ds.specialty_id
                    LEFT JOIN room_assignment ra ON q.doctor_id = ra.doctor_id
                    LEFT JOIN patient_payment_data pay ON q.queue_id = pay.queue_id
                    WHERE q.queued_at BETWEEN @start AND @end
                    AND q.queue_status_id = 5
                    ORDER BY q.queued_at DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@start", start);
                    cmd.Parameters.AddWithValue("@end", end);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvAdminDashboard.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading table: " + ex.Message);
            }
        }

        private void dgvAdminDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    // Complex Join to get all info for your DataGridView
                    string query = @"
                SELECT 
                    q.queue_id AS 'Queue Number', 
                    CONCAT(p.first_name, ' ', p.last_name) AS 'Patient Name',
                    DATE_FORMAT(q.queued_at, '%Y-%m-%d') AS 'Date',
                    DATE_FORMAT(q.queued_at, '%h:%i %p') AS 'Time Arrival',
                    CONCAT('Dr. ', up.first_name, ' ', up.last_name) AS 'Assigned Doctor',
                    ds.specialty_name AS 'Specialty',
                    ra.room_id AS 'Room Number',
                    CONCAT('₱', FORMAT(pay.payment_fee, 2)) AS 'Walk-In Fee'
                FROM patient_queue q
                INNER JOIN patient_data p ON q.patient_id = p.patient_id
                INNER JOIN user_profile up ON q.doctor_id = up.user_id
                LEFT JOIN doctor_specialty d_spec ON q.doctor_id = d_spec.user_id
                LEFT JOIN doctor_specialties ds ON d_spec.specialty_id = ds.specialty_id
                LEFT JOIN room_assignment ra ON q.doctor_id = ra.doctor_id
                LEFT JOIN patient_payment_data pay ON q.queue_id = pay.queue_id
                WHERE q.queued_at BETWEEN @start AND @end
                ORDER BY q.queued_at DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@start", dtpDateFrom);
                    cmd.Parameters.AddWithValue("@end", dtpDateTo);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvAdminDashboard.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading table: " + ex.Message);
            }
        }

        private void btnUpdateFee_Click(object sender, EventArgs e)
        {
            using (UpdateFee dialog = new UpdateFee())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string price = dialog.NewFee;

                    // HIGHLIGHT: You must grab the selected specialty from the dialog!
                    // This fixes the 'specializationName does not exist' error
                    string specName = dialog.SelectedSpecialization;

                    UpdateFeeInDatabase(price, specName);

                    // Refresh the dashboard
                    btnApply_Click(null, null);
                }
            }
        }


        public string SelectedSpecialization { get; private set; }
        private void UpdateFeeInDatabase(string newPrice, string specializationName)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    // Ensure you are updating 'checkup_fee' and filtering by 'specialty_name'
                    string query = "UPDATE doctor_specialties SET checkup_fee = @amount WHERE specialty_name = @name";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Ensure @amount is a decimal to match your DB structure
                        cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(newPrice));
                        cmd.Parameters.AddWithValue("@name", specializationName);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                            MessageBox.Show("Fee updated successfully!");
                        else
                            MessageBox.Show("No matching specialty found.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                // This will give you more specific details than just "Fatal Error"
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message);
            }
        }

        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime start, end;

            switch (cmbPeriod.SelectedIndex)
            {
                case 0: start = today; end = today; break;
                case 1: start = today.AddDays(-1); end = today.AddDays(-1); break;

                //From Monday - Today
                case 2:
                    int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
                    start = today.AddDays(-diff); end = today; break;

                //First day of Month - Today
                case 3: start = new DateTime(today.Year, today.Month, 1); end = today; break;
                default: return;
            }

            dtpDateFrom.Value = start;
            dtpDateTo.Value = end;
            btnApply_Click(null, null);
        }
    }
}
