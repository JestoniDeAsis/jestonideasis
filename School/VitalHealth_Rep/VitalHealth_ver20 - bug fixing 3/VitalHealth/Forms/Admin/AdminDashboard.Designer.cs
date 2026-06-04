namespace VitalHealth.Forms.Admin
{
    partial class AdminDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            label2 = new Label();
            label3 = new Label();
            cmbPeriod = new RoundedComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnApply = new RoundedButton();
            dtpDateFrom = new VitalHealth.CustomControls.RoundedDateTimePicker();
            dtpDateTo = new VitalHealth.CustomControls.RoundedDateTimePicker();
            roundedPanel1 = new VitalHealth.CustomControls.RoundedPanel();
            lblTotalPatients = new Label();
            label7 = new Label();
            roundedPanel2 = new VitalHealth.CustomControls.RoundedPanel();
            lblTotalSales = new Label();
            label8 = new Label();
            btnUpdateFee = new RoundedButton();
            dgvAdminDashboard = new VitalHealth.CustomControls.RoundedDataGridView();
            pnlSideBar.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
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
            pnlSideBar.TabIndex = 0;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.White;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.Black;
            btn_logout.Image = Properties.Resources.LogoutButtonIcon;
            btn_logout.Location = new Point(1, 1013);
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
            btnSchedNFee.BackColor = Color.White;
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
            btnSchedNFee.Click += btnSchedNFee_Click;
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
            btnSalesDashboard.BackColor = Color.DarkGray;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(424, 46);
            label2.Name = "label2";
            label2.Size = new Size(321, 38);
            label2.TabIndex = 8;
            label2.Text = "Sales Dashboard";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(424, 86);
            label3.Name = "label3";
            label3.Size = new Size(535, 25);
            label3.TabIndex = 10;
            label3.Text = "Display Overview of sales on a specific timeframe";
            // 
            // cmbPeriod
            // 
            cmbPeriod.BackColor = Color.White;
            cmbPeriod.BorderRadius = 35;
            cmbPeriod.DrawMode = DrawMode.OwnerDrawFixed;
            cmbPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriod.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPeriod.ForeColor = Color.Black;
            cmbPeriod.FormattingEnabled = true;
            cmbPeriod.IntegralHeight = false;
            cmbPeriod.Items.AddRange(new object[] { "Today", "Yesterday", "This Week", "This Month" });
            cmbPeriod.Location = new Point(493, 165);
            cmbPeriod.Name = "cmbPeriod";
            cmbPeriod.PlaceholderText = "Select Period";
            cmbPeriod.Size = new Size(230, 40);
            cmbPeriod.TabIndex = 11;
            cmbPeriod.TabStop = false;
            cmbPeriod.Theme = ControlTheme.Light;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(424, 166);
            label4.Name = "label4";
            label4.Size = new Size(71, 37);
            label4.TabIndex = 12;
            label4.Text = "Filter:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 15.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(859, 167);
            label5.Name = "label5";
            label5.Size = new Size(71, 37);
            label5.TabIndex = 13;
            label5.Text = "Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 15.75F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1148, 167);
            label6.Name = "label6";
            label6.Size = new Size(41, 37);
            label6.TabIndex = 15;
            label6.Text = "To";
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.FromArgb(22, 138, 173);
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApply.ForeColor = Color.White;
            btnApply.Location = new Point(1613, 165);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(238, 40);
            btnApply.TabIndex = 16;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.BackColor = Color.White;
            dtpDateFrom.BorderColor = Color.Gray;
            dtpDateFrom.BorderRadius = 20;
            dtpDateFrom.Location = new Point(936, 165);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(200, 40);
            dtpDateFrom.TabIndex = 17;
            dtpDateFrom.Value = new DateTime(2026, 3, 18, 19, 39, 19, 714);
            // 
            // dtpDateTo
            // 
            dtpDateTo.BackColor = Color.White;
            dtpDateTo.BorderColor = Color.Gray;
            dtpDateTo.BorderRadius = 20;
            dtpDateTo.Location = new Point(1202, 165);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(200, 40);
            dtpDateTo.TabIndex = 18;
            dtpDateTo.Value = new DateTime(2026, 3, 18, 19, 39, 36, 642);
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderRadius = 30;
            roundedPanel1.Controls.Add(lblTotalPatients);
            roundedPanel1.Controls.Add(label7);
            roundedPanel1.ForeColor = Color.Black;
            roundedPanel1.Location = new Point(424, 247);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(681, 234);
            roundedPanel1.TabIndex = 19;
            // 
            // lblTotalPatients
            // 
            lblTotalPatients.AutoSize = true;
            lblTotalPatients.Font = new Font("Zona Pro Bold", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPatients.Location = new Point(23, 131);
            lblTotalPatients.Name = "lblTotalPatients";
            lblTotalPatients.Size = new Size(87, 52);
            lblTotalPatients.TabIndex = 21;
            lblTotalPatients.Text = "50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(74, 214, 109);
            label7.Location = new Point(15, 19);
            label7.Name = "label7";
            label7.Size = new Size(352, 37);
            label7.TabIndex = 21;
            label7.Text = "Total Walk-In Patients";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderRadius = 30;
            roundedPanel2.Controls.Add(lblTotalSales);
            roundedPanel2.Controls.Add(label8);
            roundedPanel2.Location = new Point(1170, 247);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(681, 234);
            roundedPanel2.TabIndex = 20;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Zona Pro Bold", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = Color.Black;
            lblTotalSales.Location = new Point(29, 131);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(253, 52);
            lblTotalSales.TabIndex = 22;
            lblTotalSales.Text = "₱100,000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(74, 214, 109);
            label8.Location = new Point(19, 19);
            label8.Name = "label8";
            label8.Size = new Size(313, 37);
            label8.TabIndex = 22;
            label8.Text = "Total Walk-In Sales";
            // 
            // btnUpdateFee
            // 
            btnUpdateFee.BackColor = Color.FromArgb(22, 138, 173);
            btnUpdateFee.FlatAppearance.BorderSize = 0;
            btnUpdateFee.FlatStyle = FlatStyle.Flat;
            btnUpdateFee.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateFee.ForeColor = Color.White;
            btnUpdateFee.Location = new Point(424, 983);
            btnUpdateFee.Name = "btnUpdateFee";
            btnUpdateFee.Size = new Size(238, 45);
            btnUpdateFee.TabIndex = 22;
            btnUpdateFee.Text = "Update Fee";
            btnUpdateFee.UseVisualStyleBackColor = false;
            btnUpdateFee.Click += btnUpdateFee_Click;
            // 
            // dgvAdminDashboard
            // 
            dgvAdminDashboard.BackColor = Color.White;
            dgvAdminDashboard.BorderColor = Color.Gray;
            dgvAdminDashboard.BorderRadius = 20;
            dgvAdminDashboard.BorderThickness = 2;
            dgvAdminDashboard.ForeColor = SystemColors.ControlText;
            dgvAdminDashboard.Location = new Point(424, 502);
            dgvAdminDashboard.Name = "dgvAdminDashboard";
            dgvAdminDashboard.Size = new Size(1427, 440);
            dgvAdminDashboard.TabIndex = 21;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(btnUpdateFee);
            Controls.Add(dgvAdminDashboard);
            Controls.Add(roundedPanel2);
            Controls.Add(roundedPanel1);
            Controls.Add(dtpDateTo);
            Controls.Add(dtpDateFrom);
            Controls.Add(btnApply);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbPeriod);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlSideBar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterParent;
            Load += AdminDashboard_Load;
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSideBar;
        private Panel panel2;
        private Label LblAdmin;
        private Label lbl_adminLastName;
        private Label label1;
        private Button btnSalesDashboard;
        private Button btnManageStaff;
        private Label label2;
        private Label label3;
        private RoundedComboBox cmbPeriod;
        private Label label4;
        private Label label5;
        private Label label6;
        private RoundedButton btnApply;
        private Button btn_logout;
        private CustomControls.RoundedDateTimePicker dtpDateFrom;
        private CustomControls.RoundedDateTimePicker dtpDateTo;
        private CustomControls.RoundedPanel roundedPanel1;
        private Label label7;
        private CustomControls.RoundedPanel roundedPanel2;
        private Label label8;
        private Label lblTotalPatients;
        private Label lblTotalSales;
        private RoundedButton btnUpdateFee;
        private CustomControls.RoundedDataGridView dgvAdminDashboard;
        private Button btnSchedNFee;
        private Button btnPatientsRec;
    }
}