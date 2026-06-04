namespace VitalHealth.Forms.Admin
{
    partial class DocSched
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void label2_Click(object sender, EventArgs e) { }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            roundedPanel1 = new VitalHealth.CustomControls.RoundedPanel();
            label4 = new Label();
            roundedPanel2 = new VitalHealth.CustomControls.RoundedPanel();
            label5 = new Label();
            dgvSchedule = new VitalHealth.CustomControls.RoundedDataGridView();
            pnlSideBar = new Panel();
            btn_logout = new Button();
            btnSchedNFee = new Button();
            btnPatientsRec = new Button();
            btnManageStaff = new Button();
            btnSalesDashboard = new Button();
            LblAdmin = new Label();
            lbl_adminLastName = new Label();
            label1 = new Label();
            panel2 = new Panel();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(426, 86);
            label3.Name = "label3";
            label3.Size = new Size(722, 25);
            label3.TabIndex = 16;
            label3.Text = "Displays daily schedule of the doctors and checkup fee in the clinic";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(426, 46);
            label2.Name = "label2";
            label2.Size = new Size(337, 38);
            label2.TabIndex = 15;
            label2.Text = "Schedule and Fee";
            label2.Click += label2_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(45, 198, 83);
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Location = new Point(435, 162);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(336, 127);
            roundedPanel1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Zona Pro Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 44);
            label4.Name = "label4";
            label4.Size = new Size(249, 38);
            label4.TabIndex = 19;
            label4.Text = "CLINIC DAYS:";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderRadius = 30;
            roundedPanel2.Controls.Add(label5);
            roundedPanel2.Location = new Point(732, 162);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(524, 127);
            roundedPanel2.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(91, 33);
            label5.Name = "label5";
            label5.Size = new Size(384, 62);
            label5.TabIndex = 19;
            label5.Text = "Monday - Saturday";
            // 
            // dgvSchedule
            // 
            dgvSchedule.BackColor = Color.White;
            dgvSchedule.BorderColor = Color.Gray;
            dgvSchedule.BorderRadius = 20;
            dgvSchedule.BorderThickness = 2;
            dgvSchedule.Location = new Point(435, 320);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.Size = new Size(1414, 706);
            dgvSchedule.TabIndex = 19;
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.White;
            pnlSideBar.Controls.Add(btn_logout);
            pnlSideBar.Controls.Add(btnSchedNFee);
            pnlSideBar.Controls.Add(btnPatientsRec);
            pnlSideBar.Controls.Add(btnManageStaff);
            pnlSideBar.Controls.Add(btnSalesDashboard);
            pnlSideBar.Controls.Add(LblAdmin);
            pnlSideBar.Controls.Add(lbl_adminLastName);
            pnlSideBar.Controls.Add(label1);
            pnlSideBar.Controls.Add(panel2);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Padding = new Padding(20, 0, 0, 0);
            pnlSideBar.Size = new Size(368, 1080);
            pnlSideBar.TabIndex = 32;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.White;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.Black;
            btn_logout.Image = Properties.Resources.LogoutButtonIcon;
            btn_logout.Location = new Point(1, 1010);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(366, 67);
            btn_logout.TabIndex = 11;
            btn_logout.Text = "Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btnSchedNFee
            // 
            btnSchedNFee.BackColor = Color.DarkGray;
            btnSchedNFee.FlatAppearance.BorderSize = 0;
            btnSchedNFee.FlatStyle = FlatStyle.Flat;
            btnSchedNFee.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnSchedNFee.ForeColor = Color.Black;
            btnSchedNFee.Image = Properties.Resources.ScheduleAndFeeIcon;
            btnSchedNFee.Location = new Point(0, 340);
            btnSchedNFee.Margin = new Padding(3, 2, 3, 2);
            btnSchedNFee.Name = "btnSchedNFee";
            btnSchedNFee.Padding = new Padding(20, 0, 0, 0);
            btnSchedNFee.Size = new Size(366, 67);
            btnSchedNFee.TabIndex = 10;
            btnSchedNFee.Text = "Shedule and Fee";
            btnSchedNFee.TextAlign = ContentAlignment.MiddleLeft;
            btnSchedNFee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSchedNFee.UseVisualStyleBackColor = false;
            // 
            // btnPatientsRec
            // 
            btnPatientsRec.BackColor = Color.White;
            btnPatientsRec.FlatAppearance.BorderSize = 0;
            btnPatientsRec.FlatStyle = FlatStyle.Flat;
            btnPatientsRec.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnPatientsRec.ForeColor = Color.Black;
            btnPatientsRec.Image = Properties.Resources.patients_records_icon;
            btnPatientsRec.Location = new Point(1, 270);
            btnPatientsRec.Margin = new Padding(3, 2, 3, 2);
            btnPatientsRec.Name = "btnPatientsRec";
            btnPatientsRec.Padding = new Padding(17, 0, 0, 0);
            btnPatientsRec.Size = new Size(366, 67);
            btnPatientsRec.TabIndex = 9;
            btnPatientsRec.Text = "Patients Record";
            btnPatientsRec.TextAlign = ContentAlignment.MiddleLeft;
            btnPatientsRec.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPatientsRec.UseVisualStyleBackColor = false;
            btnPatientsRec.Click += btnPatientsRec_Click;
            // 
            // btnManageStaff
            // 
            btnManageStaff.BackColor = Color.White;
            btnManageStaff.FlatAppearance.BorderSize = 0;
            btnManageStaff.FlatStyle = FlatStyle.Flat;
            btnManageStaff.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnManageStaff.ForeColor = Color.Black;
            btnManageStaff.Image = Properties.Resources.staff_icon;
            btnManageStaff.Location = new Point(1, 199);
            btnManageStaff.Margin = new Padding(3, 2, 3, 2);
            btnManageStaff.Name = "btnManageStaff";
            btnManageStaff.Padding = new Padding(10, 0, 0, 0);
            btnManageStaff.Size = new Size(366, 67);
            btnManageStaff.TabIndex = 8;
            btnManageStaff.Text = "Manage Staff";
            btnManageStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnManageStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageStaff.UseVisualStyleBackColor = false;
            btnManageStaff.Click += btnManageStaff_Click;
            // 
            // btnSalesDashboard
            // 
            btnSalesDashboard.BackColor = Color.White;
            btnSalesDashboard.FlatAppearance.BorderSize = 0;
            btnSalesDashboard.FlatStyle = FlatStyle.Flat;
            btnSalesDashboard.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            btnSalesDashboard.ForeColor = Color.Black;
            btnSalesDashboard.Image = Properties.Resources.sales_perf_icon;
            btnSalesDashboard.Location = new Point(1, 130);
            btnSalesDashboard.Margin = new Padding(3, 2, 3, 2);
            btnSalesDashboard.Name = "btnSalesDashboard";
            btnSalesDashboard.Padding = new Padding(20, 0, 0, 0);
            btnSalesDashboard.Size = new Size(366, 67);
            btnSalesDashboard.TabIndex = 7;
            btnSalesDashboard.Text = "Sales Dashboard\r\n";
            btnSalesDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalesDashboard.UseVisualStyleBackColor = false;
            btnSalesDashboard.Click += btnSalesDashboard_Click;
            // 
            // LblAdmin
            // 
            LblAdmin.AutoSize = true;
            LblAdmin.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAdmin.ForeColor = Color.FromArgb(26, 117, 159);
            LblAdmin.Location = new Point(131, 68);
            LblAdmin.Name = "LblAdmin";
            LblAdmin.Size = new Size(61, 26);
            LblAdmin.TabIndex = 6;
            LblAdmin.Text = "Admin";
            // 
            // lbl_adminLastName
            // 
            lbl_adminLastName.AutoSize = true;
            lbl_adminLastName.Font = new Font("Poppins", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_adminLastName.ForeColor = Color.Black;
            lbl_adminLastName.Location = new Point(202, 38);
            lbl_adminLastName.Name = "lbl_adminLastName";
            lbl_adminLastName.Size = new Size(128, 40);
            lbl_adminLastName.TabIndex = 5;
            lbl_adminLastName.Text = "lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(74, 214, 109);
            label1.Location = new Point(131, 38);
            label1.Name = "label1";
            label1.Size = new Size(79, 40);
            label1.TabIndex = 4;
            label1.Text = "Hello,";
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
            panel2.TabIndex = 2;
            // 
            // DocSched
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(pnlSideBar);
            Controls.Add(dgvSchedule);
            Controls.Add(roundedPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(roundedPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DocSched";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += DocSched_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.RoundedPanel roundedPanel2;
        private Label label4;
        private Label label5;
        private CustomControls.RoundedDataGridView dgvSchedule;
        private Panel pnlSideBar;
        private Button btn_logout;
        private Button btnSchedNFee;
        private Button btnPatientsRec;
        private Button btnManageStaff;
        private Button btnSalesDashboard;
        private Label LblAdmin;
        private Label lbl_adminLastName;
        private Label label1;
        private Panel panel2;
    }
}