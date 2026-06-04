using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VitalHealth.Forms.Admin
{
    public partial class ManageStaff : Form
    {
        public ManageStaff()
        {
            InitializeComponent();
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {
            lbl_adminLastName.Text = MainForm.loggedInUserLastname;
            loadStaffCards();
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

        private void btn_AddStaff_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new AddStaff());
        }

        private void btnPatientsRec_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new ViewPreviousRecords());
        }

        private void btnSchedNFee_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DocSched());
        }


        public void loadStaffCards()
        {

            flpStaffCards.FlowDirection = FlowDirection.LeftToRight;
            flpStaffCards.RightToLeft = RightToLeft.No;
            flpStaffCards.WrapContents = true;
            flpStaffCards.AutoScroll = true;
            flpStaffCards.Controls.Clear();

            try
            {
                using (var conn = new MySqlConnection("server=localhost;database=vital_health;user=root;password=;"))
                {
                    conn.Open();

                    // 1. Base Query
                    string query = @"SELECT u.user_id ,p.first_name, p.last_name, r.role_name, u.is_activated, 
                        IFNULL(s.specialty_name, 'N/A') AS specialty
                        FROM user_profile p
                        JOIN users u ON p.user_id = u.user_id
                        JOIN user_role r ON u.role_id = r.role_id
                        LEFT JOIN doctor_specialty ds ON u.user_id = ds.user_id
                        LEFT JOIN doctor_specialties s ON ds.specialty_id = s.specialty_id";

                    List<string> whereClauses = new List<string>();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    // 2. Build the Filters
                    if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    {
                        whereClauses.Add("(p.first_name LIKE @search OR p.last_name LIKE @search)");
                        cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");
                    }

                    if (cmbRole.Text != "All" && !string.IsNullOrEmpty(cmbRole.Text))
                    {
                        whereClauses.Add("r.role_name = @role");
                        cmd.Parameters.AddWithValue("@role", cmbRole.Text.ToLower());
                    }

                    if (cmbStatus.Text != "All" && !string.IsNullOrEmpty(cmbStatus.Text))
                    {
                        int statusValue = (cmbStatus.Text == "Approved") ? 1 : (cmbStatus.Text == "Pending" ? 0 : 2);
                        whereClauses.Add("u.is_activated = @status");
                        cmd.Parameters.AddWithValue("@status", statusValue);
                    }

                    // --- CRITICAL MISSING STEP START ---
                    if (whereClauses.Count > 0)
                    {
                        query += " WHERE " + string.Join(" AND ", whereClauses);
                    }
                    // --- CRITICAL MISSING STEP END ---

                    cmd.CommandText = query; // Now 'query' contains the WHERE clause!

                    using (var reader = cmd.ExecuteReader())
                    {
                        flpStaffCards.Controls.Clear(); // Clear old cards before showing filtered ones
                        while (reader.Read())
                        {

                            StaffCards cards = new StaffCards();
                            cards.btnAccept.TabStop = false;

                            cards.lblFullname.Text = $"{reader["first_name"]} {reader["last_name"]}";
                            cards.lblRole.Text = reader["role_name"].ToString();
                            cards.lblSpecialization.Text = reader["specialty"].ToString();

                            int cardUserId = Convert.ToInt32(reader["user_id"]);
                            cards.Tag = reader["user_id"];
                            int active = Convert.ToInt32(reader["is_activated"]);

                            if (cardUserId == MainForm.loggedInUserID)
                            {
                                cards.lblFullname.Text += " (You)";
                                cards.lblStatus.Text = "Active Session";
                                cards.lblStatus.ForeColor = Color.Blue;

                                // Hide all action buttons for your own card
                                cards.btnAccept.Visible = false;
                                cards.btnDecline.Visible = false;
                                cards.btnBlock.Visible = false;

                            }
                            else if (active == 1)
                            {
                                cards.lblStatus.Text = "Approved";
                                cards.lblStatus.ForeColor = Color.Green;

                                cards.btnAccept.Visible = false;
                                cards.btnDecline.Visible = false;
                                cards.btnBlock.Visible = true;
                                cards.btnBlock.Location = cards.btnAccept.Location;
                            }
                            else if (active == 0)
                            {
                                cards.lblStatus.Text = "Pending Approval";
                                cards.lblStatus.ForeColor = Color.Orange;

                                // UI: Show Accept and Decline, Hide Block
                                cards.btnAccept.Visible = true;
                                cards.btnDecline.Visible = true;
                                cards.btnBlock.Visible = false;
                            }
                            else if (active == 2)
                            {
                                cards.lblStatus.Text = "Blocked";
                                cards.lblStatus.ForeColor = Color.Red;
                            }
                            else if (active == 3)
                            {
                                cards.lblStatus.Text = "Deactivated";
                                cards.lblStatus.ForeColor = Color.Red;
                            }
                            else
                            {
                                cards.lblStatus.Text = "Deactivated";
                                cards.lblStatus.ForeColor = Color.Red;
                            }

                            flpStaffCards.Controls.Add(cards);
                            cards.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadStaffCards();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadStaffCards();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadStaffCards();
        }
    }
}
