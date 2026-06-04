using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Authentication;
using VitalHealth.Forms.Dialogs;

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
            roundedDataGridView1 = new VitalHealth.CustomControls.RoundedDataGridView();
            panel3 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            label8 = new Label();
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
            // roundedDataGridView1
            // 
            roundedDataGridView1.BackColor = Color.White;
            roundedDataGridView1.BorderColor = Color.Gray;
            roundedDataGridView1.BorderRadius = 20;
            roundedDataGridView1.BorderThickness = 2;
            roundedDataGridView1.Location = new Point(416, 172);
            roundedDataGridView1.Name = "roundedDataGridView1";
            roundedDataGridView1.Size = new Size(1449, 741);
            roundedDataGridView1.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(427, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 43);
            panel3.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(158, 13);
            label6.Name = "label6";
            label6.Size = new Size(18, 18);
            label6.TabIndex = 18;
            label6.Text = "0";
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
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(672, 103);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 43);
            panel4.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(169, 13);
            label7.Name = "label7";
            label7.Size = new Size(18, 18);
            label7.TabIndex = 19;
            label7.Text = "0";
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
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(1656, 103);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 43);
            panel5.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(154, 13);
            label8.Name = "label8";
            label8.Size = new Size(18, 18);
            label8.TabIndex = 20;
            label8.Text = "0";
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
            panel1.Location = new Point(-8, -8);
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
            Controls.Add(roundedDataGridView1);
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
        private CustomControls.RoundedDataGridView roundedDataGridView1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
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
        private Label label8;

        private void DoctorAssignedPatients_Load(object sender, EventArgs e)
        {
            lbl_doctorLastName.Text = MainForm.loggedInUserLastname;
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
