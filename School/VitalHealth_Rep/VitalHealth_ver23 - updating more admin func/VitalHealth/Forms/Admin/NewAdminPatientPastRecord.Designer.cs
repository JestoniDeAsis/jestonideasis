namespace VitalHealth.Forms.Nurse
{
    partial class NewAdminPatientPastRecord
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
            pastRecordDataGrid = new VitalHealth.CustomControls.RoundedDataGridView();
            searchTxtBox = new RoundedTextBox();
            searchButton = new RoundedButton();
            label3 = new Label();
            label2 = new Label();
            page3DG = new Label();
            page4DG = new Label();
            page5DG = new Label();
            page2DG = new Label();
            page1DG = new Label();
            backArrowDG = new PictureBox();
            nextArrowDG = new PictureBox();
            viewRecordButton = new RoundedButton();
            panel2 = new Panel();
            label1 = new Label();
            lbl_adminLastName = new Label();
            LblAdmin = new Label();
            btnSalesDashboard = new Button();
            btnManageStaff = new Button();
            btnPatientsRec = new Button();
            btnSchedNFee = new Button();
            btn_logout = new Button();
            pnlSideBar = new Panel();
            ((System.ComponentModel.ISupportInitialize)backArrowDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextArrowDG).BeginInit();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // pastRecordDataGrid
            // 
            pastRecordDataGrid.BackColor = Color.White;
            pastRecordDataGrid.BorderColor = Color.Gray;
            pastRecordDataGrid.BorderRadius = 20;
            pastRecordDataGrid.BorderThickness = 2;
            pastRecordDataGrid.Location = new Point(427, 250);
            pastRecordDataGrid.Name = "pastRecordDataGrid";
            pastRecordDataGrid.Size = new Size(1401, 724);
            pastRecordDataGrid.TabIndex = 16;
            // 
            // searchTxtBox
            // 
            searchTxtBox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTxtBox.Location = new Point(427, 169);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.PlaceholderText = "Search Patient's Name/Queuing Number";
            searchTxtBox.Size = new Size(379, 54);
            searchTxtBox.TabIndex = 15;
            searchTxtBox.Theme = ControlTheme.Light;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(22, 138, 173);
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(814, 169);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(126, 54);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(427, 91);
            label3.Name = "label3";
            label3.Size = new Size(421, 25);
            label3.TabIndex = 18;
            label3.Text = "Displays past patient checkup records.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 44);
            label2.Name = "label2";
            label2.Size = new Size(252, 38);
            label2.TabIndex = 17;
            label2.Text = "Past Records";
            // 
            // page3DG
            // 
            page3DG.AutoSize = true;
            page3DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page3DG.Location = new Point(1073, 1000);
            page3DG.Name = "page3DG";
            page3DG.Size = new Size(23, 23);
            page3DG.TabIndex = 19;
            page3DG.Text = "3";
            // 
            // page4DG
            // 
            page4DG.AutoSize = true;
            page4DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page4DG.Location = new Point(1103, 1000);
            page4DG.Name = "page4DG";
            page4DG.Size = new Size(24, 23);
            page4DG.TabIndex = 20;
            page4DG.Text = "4";
            // 
            // page5DG
            // 
            page5DG.AutoSize = true;
            page5DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page5DG.Location = new Point(1133, 1000);
            page5DG.Name = "page5DG";
            page5DG.Size = new Size(23, 23);
            page5DG.TabIndex = 21;
            page5DG.Text = "5";
            // 
            // page2DG
            // 
            page2DG.AutoSize = true;
            page2DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page2DG.Location = new Point(1043, 1000);
            page2DG.Name = "page2DG";
            page2DG.Size = new Size(23, 23);
            page2DG.TabIndex = 22;
            page2DG.Text = "2";
            // 
            // page1DG
            // 
            page1DG.AutoSize = true;
            page1DG.Font = new Font("Zona Pro Bold", 15.7499981F);
            page1DG.Location = new Point(1013, 1000);
            page1DG.Name = "page1DG";
            page1DG.Size = new Size(19, 23);
            page1DG.TabIndex = 23;
            page1DG.Text = "1";
            // 
            // backArrowDG
            // 
            backArrowDG.Image = Properties.Resources.backArrowDG;
            backArrowDG.Location = new Point(973, 994);
            backArrowDG.Name = "backArrowDG";
            backArrowDG.Size = new Size(33, 33);
            backArrowDG.SizeMode = PictureBoxSizeMode.StretchImage;
            backArrowDG.TabIndex = 24;
            backArrowDG.TabStop = false;
            // 
            // nextArrowDG
            // 
            nextArrowDG.Image = Properties.Resources.nextArrowDG;
            nextArrowDG.Location = new Point(1164, 994);
            nextArrowDG.Name = "nextArrowDG";
            nextArrowDG.Size = new Size(33, 33);
            nextArrowDG.SizeMode = PictureBoxSizeMode.StretchImage;
            nextArrowDG.TabIndex = 25;
            nextArrowDG.TabStop = false;
            // 
            // viewRecordButton
            // 
            viewRecordButton.BackColor = Color.FromArgb(74, 214, 109);
            viewRecordButton.FlatAppearance.BorderSize = 0;
            viewRecordButton.FlatStyle = FlatStyle.Flat;
            viewRecordButton.Font = new Font("Zona Pro Bold", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewRecordButton.ForeColor = Color.White;
            viewRecordButton.Location = new Point(1596, 986);
            viewRecordButton.Name = "viewRecordButton";
            viewRecordButton.Size = new Size(200, 50);
            viewRecordButton.TabIndex = 26;
            viewRecordButton.Text = "VIEW RECORD";
            viewRecordButton.UseVisualStyleBackColor = false;
            viewRecordButton.Click += viewRecordButton_Click;
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
            // btnPatientsRec
            // 
            btnPatientsRec.BackColor = Color.DarkGray;
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
            pnlSideBar.TabIndex = 34;
            // 
            // NewAdminPatientPastRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(229, 231, 231);
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(pnlSideBar);
            Controls.Add(viewRecordButton);
            Controls.Add(nextArrowDG);
            Controls.Add(backArrowDG);
            Controls.Add(page1DG);
            Controls.Add(page2DG);
            Controls.Add(page5DG);
            Controls.Add(page4DG);
            Controls.Add(page3DG);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pastRecordDataGrid);
            Controls.Add(searchTxtBox);
            Controls.Add(searchButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewAdminPatientPastRecord";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += PatientPastRecords_Load;
            ((System.ComponentModel.ISupportInitialize)backArrowDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextArrowDG).EndInit();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.RoundedDataGridView pastRecordDataGrid;
        private RoundedTextBox searchTxtBox;
        private RoundedButton searchButton;
        private Label label3;
        private Label label2;
        private Label page3DG;
        private Label page4DG;
        private Label page5DG;
        private Label page2DG;
        private Label page1DG;
        private PictureBox backArrowDG;
        private PictureBox nextArrowDG;
        private RoundedButton viewRecordButton;
        private Panel panel2;
        private Label label1;
        private Label lbl_adminLastName;
        private Label LblAdmin;
        private Button btnSalesDashboard;
        private Button btnManageStaff;
        private Button btnPatientsRec;
        private Button btnSchedNFee;
        private Button btn_logout;
        private Panel pnlSideBar;
    }
}