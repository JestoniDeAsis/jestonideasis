using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.CustomControls;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;
using VitalHealth.Forms.Nurse;

namespace VitalHealth.Forms.Doctor
{
    public partial class DoctorAssignedPatients : Form
    {
        public DoctorAssignedPatients()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(DoctorAssignedPatients));
            label2 = new Label();
            rdgridv_queueList = new RoundedDataGridView();
            panel3 = new Panel();
            lbl_pendingPatient = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lbl_completedPatient = new Label();
            label4 = new Label();
            panel5 = new Panel();
            lbl_totalPatient = new Label();
            label5 = new Label();
            panel2 = new Panel();
            btn_scheduleAndFee = new Button();
            label1 = new Label();
            lbl_doctorLastName = new Label();
            LblDoc = new Label();
            btn_assignedPatients = new Button();
            btn_patientRecord = new Button();
            btn_logout = new Button();
            btn_editProfile = new Button();
            panel1 = new Panel();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(416, 39);
            label2.Name = "label2";
            label2.Size = new Size(355, 38);
            label2.TabIndex = 8;
            label2.Text = "Patient Dashboard";
            // 
            // rdgridv_queueList
            // 
            rdgridv_queueList.BackColor = Color.White;
            rdgridv_queueList.BorderColor = Color.Gray;
            rdgridv_queueList.BorderRadius = 20;
            rdgridv_queueList.BorderThickness = 2;
            rdgridv_queueList.Location = new Point(416, 172);
            rdgridv_queueList.Name = "rdgridv_queueList";
            rdgridv_queueList.Size = new Size(1449, 741);
            rdgridv_queueList.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Controls.Add(lbl_pendingPatient);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(427, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 43);
            panel3.TabIndex = 14;
            // 
            // lbl_pendingPatient
            // 
            lbl_pendingPatient.AutoSize = true;
            lbl_pendingPatient.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_pendingPatient.ForeColor = Color.White;
            lbl_pendingPatient.Location = new Point(158, 13);
            lbl_pendingPatient.Name = "lbl_pendingPatient";
            lbl_pendingPatient.Size = new Size(18, 18);
            lbl_pendingPatient.TabIndex = 18;
            lbl_pendingPatient.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 13);
            label3.Name = "label3";
            label3.Size = new Size(139, 18);
            label3.TabIndex = 17;
            label3.Text = "Pending Patient:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkGreen;
            panel4.Controls.Add(lbl_completedPatient);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(672, 103);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 43);
            panel4.TabIndex = 15;
            // 
            // lbl_completedPatient
            // 
            lbl_completedPatient.AutoSize = true;
            lbl_completedPatient.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_completedPatient.ForeColor = Color.White;
            lbl_completedPatient.Location = new Point(169, 13);
            lbl_completedPatient.Name = "lbl_completedPatient";
            lbl_completedPatient.Size = new Size(18, 18);
            lbl_completedPatient.TabIndex = 19;
            lbl_completedPatient.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 13);
            label4.Name = "label4";
            label4.Size = new Size(160, 18);
            label4.TabIndex = 18;
            label4.Text = "Completed Patient:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 0, 0);
            panel5.Controls.Add(lbl_totalPatient);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(1656, 103);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 43);
            panel5.TabIndex = 16;
            // 
            // lbl_totalPatient
            // 
            lbl_totalPatient.AutoSize = true;
            lbl_totalPatient.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_totalPatient.ForeColor = Color.White;
            lbl_totalPatient.Location = new Point(154, 13);
            lbl_totalPatient.Name = "lbl_totalPatient";
            lbl_totalPatient.Size = new Size(18, 18);
            lbl_totalPatient.TabIndex = 20;
            lbl_totalPatient.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 13);
            label5.Name = "label5";
            label5.Size = new Size(114, 18);
            label5.TabIndex = 19;
            label5.Text = "Total Patient:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.VitalHealth_Logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(31, 27);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(75, 75);
            panel2.TabIndex = 1;
            // 
            // btn_scheduleAndFee
            // 
            btn_scheduleAndFee.BackColor = Color.White;
            btn_scheduleAndFee.FlatAppearance.BorderSize = 0;
            btn_scheduleAndFee.FlatStyle = FlatStyle.Flat;
            btn_scheduleAndFee.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_scheduleAndFee.Image = (Image)resources.GetObject("btn_scheduleAndFee.Image");
            btn_scheduleAndFee.ImageAlign = ContentAlignment.MiddleLeft;
            btn_scheduleAndFee.Location = new Point(0, 270);
            btn_scheduleAndFee.Margin = new Padding(3, 2, 3, 2);
            btn_scheduleAndFee.Name = "btn_scheduleAndFee";
            btn_scheduleAndFee.Padding = new Padding(26, 0, 0, 0);
            btn_scheduleAndFee.RightToLeft = RightToLeft.No;
            btn_scheduleAndFee.Size = new Size(366, 67);
            btn_scheduleAndFee.TabIndex = 2;
            btn_scheduleAndFee.Text = "Schedule and Fee";
            btn_scheduleAndFee.TextAlign = ContentAlignment.MiddleLeft;
            btn_scheduleAndFee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_scheduleAndFee.UseVisualStyleBackColor = false;
            btn_scheduleAndFee.Click += btn_scheduleAndFee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Zona Pro Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 38);
            label1.Name = "label1";
            label1.Size = new Size(73, 24);
            label1.TabIndex = 1;
            label1.Text = "Hello,";
            // 
            // lbl_doctorLastName
            // 
            lbl_doctorLastName.AutoSize = true;
            lbl_doctorLastName.Font = new Font("Zona Pro Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_doctorLastName.Location = new Point(182, 38);
            lbl_doctorLastName.Name = "lbl_doctorLastName";
            lbl_doctorLastName.Size = new Size(116, 24);
            lbl_doctorLastName.TabIndex = 2;
            lbl_doctorLastName.Text = "lastname";
            // 
            // LblDoc
            // 
            LblDoc.AutoSize = true;
            LblDoc.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDoc.ForeColor = Color.FromArgb(26, 117, 159);
            LblDoc.Location = new Point(111, 61);
            LblDoc.Name = "LblDoc";
            LblDoc.Size = new Size(50, 17);
            LblDoc.TabIndex = 3;
            LblDoc.Text = "Doctor";
            // 
            // btn_assignedPatients
            // 
            btn_assignedPatients.BackColor = Color.DarkGray;
            btn_assignedPatients.FlatAppearance.BorderSize = 0;
            btn_assignedPatients.FlatStyle = FlatStyle.Flat;
            btn_assignedPatients.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_assignedPatients.Image = (Image)resources.GetObject("btn_assignedPatients.Image");
            btn_assignedPatients.Location = new Point(-23, 130);
            btn_assignedPatients.Margin = new Padding(3, 2, 3, 2);
            btn_assignedPatients.Name = "btn_assignedPatients";
            btn_assignedPatients.Padding = new Padding(13, 0, 0, 0);
            btn_assignedPatients.Size = new Size(390, 67);
            btn_assignedPatients.TabIndex = 1;
            btn_assignedPatients.Text = "Assigned Patients";
            btn_assignedPatients.TextAlign = ContentAlignment.MiddleLeft;
            btn_assignedPatients.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_assignedPatients.UseVisualStyleBackColor = false;
            // 
            // btn_patientRecord
            // 
            btn_patientRecord.BackColor = Color.White;
            btn_patientRecord.FlatAppearance.BorderSize = 0;
            btn_patientRecord.FlatStyle = FlatStyle.Flat;
            btn_patientRecord.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_patientRecord.Image = (Image)resources.GetObject("btn_patientRecord.Image");
            btn_patientRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btn_patientRecord.Location = new Point(-1, 199);
            btn_patientRecord.Margin = new Padding(3, 2, 3, 2);
            btn_patientRecord.Name = "btn_patientRecord";
            btn_patientRecord.Padding = new Padding(26, 0, 0, 0);
            btn_patientRecord.Size = new Size(366, 67);
            btn_patientRecord.TabIndex = 4;
            btn_patientRecord.Text = "Patient's Record";
            btn_patientRecord.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_patientRecord.UseVisualStyleBackColor = false;
            btn_patientRecord.Click += btn_patientRecord_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.White;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_logout.Image = Properties.Resources.LogoutButtonIcon;
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(1, 1012);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(30, 0, 0, 0);
            btn_logout.Size = new Size(366, 67);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_editProfile
            // 
            btn_editProfile.BackColor = Color.White;
            btn_editProfile.FlatAppearance.BorderSize = 0;
            btn_editProfile.FlatStyle = FlatStyle.Flat;
            btn_editProfile.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btn_editProfile.Image = Properties.Resources.EditProfileButtonIcon;
            btn_editProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btn_editProfile.Location = new Point(1, 940);
            btn_editProfile.Margin = new Padding(3, 2, 3, 2);
            btn_editProfile.Name = "btn_editProfile";
            btn_editProfile.Padding = new Padding(30, 0, 0, 0);
            btn_editProfile.Size = new Size(366, 67);
            btn_editProfile.TabIndex = 7;
            btn_editProfile.Text = "Edit Profile";
            btn_editProfile.TextAlign = ContentAlignment.MiddleLeft;
            btn_editProfile.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editProfile.UseVisualStyleBackColor = false;
            btn_editProfile.Click += btn_editProfile_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_editProfile);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_patientRecord);
            panel1.Controls.Add(btn_assignedPatients);
            panel1.Controls.Add(LblDoc);
            panel1.Controls.Add(lbl_doctorLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_scheduleAndFee);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 1080);
            panel1.TabIndex = 2;
            // 
            // DoctorAssignedPatients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1064);
            ControlBox = false;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(rdgridv_queueList);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "DoctorAssignedPatients";
            Load += DoctorAssignedPatients_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label2;
        private CustomControls.RoundedDataGridView rdgridv_queueList;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbl_pendingPatient;
        private Label lbl_completedPatient;
        private Panel panel2;
        private Button btn_scheduleAndFee;
        private Label label1;
        private Label lbl_doctorLastName;
        private Label LblDoc;
        private Button btn_assignedPatients;
        private Button btn_patientRecord;
        private Button btn_logout;
        private Button btn_editProfile;
        private Panel panel1;
        private Label lbl_totalPatient;


        private void DoctorAssignedPatients_Load(object sender, EventArgs e)
        {
            lbl_doctorLastName.Text = MainForm.loggedInUserLastname;

            rdgridv_queueList.Grid.Columns.Add("QueueNumber", "Queue Number");
            rdgridv_queueList.Grid.Columns.Add("PatientName", "Patient Name");
            rdgridv_queueList.Grid.Columns.Add("Status", "Status");
            rdgridv_queueList.Grid.Columns.Add("PatientID", "PatientID");
            rdgridv_queueList.Grid.Columns["PatientID"].Visible = false;

            // Add button column ONCE
            var btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Details";
            btnColumn.HeaderText = "Details";
            btnColumn.Text = "View";
            btnColumn.UseColumnTextForButtonValue = true;

            rdgridv_queueList.Grid.Columns.Add(btnColumn);

            // Attach click event
            rdgridv_queueList.Grid.CellContentClick += Grid_CellContentClick;

            loadQueueList();
        }

        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && rdgridv_queueList.Grid.Columns[e.ColumnIndex].Name == "Details")
            {
                var row = rdgridv_queueList.Grid.Rows[e.RowIndex];

                int patientID = Convert.ToInt32(row.Cells["PatientID"].Value);

                var form = new DoctorViewPastRecords();
                form.set_patientID(patientID);

                MainForm.Instance.OpenChildForm(form);
            }
        }

        private void loadQueueList()
        {
            var db = new Data.DBConnection();
            using var conn = db.GetConnection();
            conn.Open();

            string query = @"
            SELECT 
                pq.queue_id,
                pq.patient_id,
                pd.first_name,
                pd.middle_name,
                pd.last_name,
                pd.name_suffix,
                qs.status_name
            FROM patient_queue pq
            INNER JOIN patient_data pd 
                ON pq.patient_id = pd.patient_id
            INNER JOIN queue_status qs
                ON pq.queue_status_id = qs.queue_status_id
            WHERE pq.doctor_id = @doctorID
                AND DATE(pq.queued_at) = CURDATE()
            ORDER BY pq.queue_id ASC";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@doctorID", MainForm.loggedInUserID);

            using var reader = cmd.ExecuteReader();

            rdgridv_queueList.Grid.Rows.Clear();

            int queueNumber = 1; // 👈 dynamic numbering

            while (reader.Read())
            {
                string middle = reader["middle_name"]?.ToString();
                string suffix = reader["name_suffix"]?.ToString();

                string fullName =
                    reader["first_name"] + " " +
                    (string.IsNullOrEmpty(middle) ? "" : middle + " ") +
                    reader["last_name"] +
                    (string.IsNullOrEmpty(suffix) ? "" : " " + suffix);

                string status = reader["status_name"].ToString();

                rdgridv_queueList.Grid.Rows.Add(
                    queueNumber,
                    fullName.Trim(),
                    status,
                    reader["patient_id"]
                );

                queueNumber++;
            }

            updatePatientCounts();
        }

        void updatePatientCounts()
        {
            var db = new Data.DBConnection();
            using var conn = db.GetConnection();
            conn.Open();

            int pending = 0;
            int completed = 0;
            int total = 0;

            int doctorId = MainForm.loggedInUserID;

            string totalQuery = @"
            SELECT COUNT(*) 
            FROM patient_queue
            WHERE doctor_id = @doctorId";

            using (var cmd = new MySqlCommand(totalQuery, conn))
            {
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                total = Convert.ToInt32(cmd.ExecuteScalar());
            }

            string completedQuery = @"
            SELECT COUNT(*) 
            FROM patient_queue 
            WHERE doctor_id = @doctorId
            AND queue_status_id = 5";

            using (var cmd = new MySqlCommand(completedQuery, conn))
            {
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                completed = Convert.ToInt32(cmd.ExecuteScalar());
            }

            string pendingQuery = @"
            SELECT COUNT(*) 
            FROM patient_queue 
            WHERE doctor_id = @doctorId
            AND queue_status_id != 5";

            using (var cmd = new MySqlCommand(pendingQuery, conn))
            {
                cmd.Parameters.AddWithValue("@doctorId", doctorId);
                pending = Convert.ToInt32(cmd.ExecuteScalar());
            }

            lbl_pendingPatient.Text = pending.ToString();
            lbl_completedPatient.Text = completed.ToString();
            lbl_totalPatient.Text = total.ToString();
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

        private void btn_patientRecord_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorPatientPastRecord());
        }

        private void btn_scheduleAndFee_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorSchedule());
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorEditProfile());
        }
    }
}
