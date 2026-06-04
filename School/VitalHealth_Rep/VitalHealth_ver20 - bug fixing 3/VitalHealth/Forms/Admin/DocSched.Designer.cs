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
            label3 = new Label();
            label2 = new Label();
            dtgView_docSched = new VitalHealth.CustomControls.RoundedDataGridView();
            cmb_filterShift = new RoundedComboBox();
            pnlSideBar.SuspendLayout();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(450, 80);
            label3.Name = "label3";
            label3.Size = new Size(762, 25);
            label3.TabIndex = 34;
            label3.Text = "Displays the daily schedule of the doctors and checkup fee in the clinic";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(447, 33);
            label2.Name = "label2";
            label2.Size = new Size(341, 38);
            label2.TabIndex = 33;
            label2.Text = "Schedule And Fee";
            // 
            // dtgView_docSched
            // 
            dtgView_docSched.BackColor = Color.White;
            dtgView_docSched.BorderColor = Color.Gray;
            dtgView_docSched.BorderRadius = 20;
            dtgView_docSched.BorderThickness = 2;
            dtgView_docSched.Location = new Point(423, 180);
            dtgView_docSched.Name = "dtgView_docSched";
            dtgView_docSched.Size = new Size(1449, 799);
            dtgView_docSched.TabIndex = 39;
            // 
            // cmb_filterShift
            // 
            cmb_filterShift.BackColor = Color.White;
            cmb_filterShift.BorderRadius = 35;
            cmb_filterShift.DrawMode = DrawMode.OwnerDrawFixed;
            cmb_filterShift.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_filterShift.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_filterShift.ForeColor = Color.Black;
            cmb_filterShift.FormattingEnabled = true;
            cmb_filterShift.IntegralHeight = false;
            cmb_filterShift.Items.AddRange(new object[] { "All", "Morning", "Afternoon" });
            cmb_filterShift.Location = new Point(447, 144);
            cmb_filterShift.Name = "cmb_filterShift";
            cmb_filterShift.PlaceholderText = "Filter by shift";
            cmb_filterShift.Size = new Size(237, 30);
            cmb_filterShift.TabIndex = 40;
            cmb_filterShift.TabStop = false;
            cmb_filterShift.Theme = ControlTheme.Light;
            cmb_filterShift.SelectedIndexChanged += cmb_filterShift_SelectedIndexChanged;
            // 
            // DocSched
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(cmb_filterShift);
            Controls.Add(dtgView_docSched);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlSideBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DocSched";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += DocSched_Load;
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label3;
        private Label label2;
        private CustomControls.RoundedDataGridView dtgView_docSched;
        private RoundedComboBox cmb_filterShift;
    }
}