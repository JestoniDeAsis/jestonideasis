namespace VitalHealth.Forms.Admin
{
    partial class UpdateFee
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


        private void btn_back_Click(object sender, EventArgs e) { }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnBack = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            lblCurrentFee = new Label();
            txtNewFee = new RoundedTextBox();
            label5 = new Label();
            lblTodayDate = new Label();
            txtReason = new RoundedTextBox();
            label7 = new Label();
            cmbSpecialization = new RoundedComboBox();
            btnCancel = new RoundedButton();
            btnUpdate = new RoundedButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 198, 83);
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 650);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = Properties.Resources.back_icon;
            btnBack.Location = new Point(17, 30);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(23, 27);
            btnBack.SizeMode = PictureBoxSizeMode.StretchImage;
            btnBack.TabIndex = 35;
            btnBack.TabStop = false;
            btnBack.Click += btn_back_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Zona Pro Bold", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(75, 25);
            label2.Name = "label2";
            label2.Size = new Size(340, 35);
            label2.TabIndex = 12;
            label2.Text = "Update Walk-In Fee";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(75, 123);
            label4.Name = "label4";
            label4.Size = new Size(209, 34);
            label4.TabIndex = 14;
            label4.Text = "Current Walk-In Fee:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(75, 159);
            label1.Name = "label1";
            label1.Size = new Size(178, 34);
            label1.TabIndex = 15;
            label1.Text = "New Walk-In Fee:";
            // 
            // lblCurrentFee
            // 
            lblCurrentFee.AutoSize = true;
            lblCurrentFee.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentFee.ForeColor = Color.Black;
            lblCurrentFee.Location = new Point(388, 123);
            lblCurrentFee.Name = "lblCurrentFee";
            lblCurrentFee.Size = new Size(73, 34);
            lblCurrentFee.TabIndex = 16;
            lblCurrentFee.Text = "₱XXX";
            lblCurrentFee.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNewFee
            // 
            txtNewFee.Location = new Point(388, 160);
            txtNewFee.Name = "txtNewFee";
            txtNewFee.Size = new Size(125, 34);
            txtNewFee.TabIndex = 17;
            txtNewFee.Theme = ControlTheme.Light;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(75, 259);
            label5.Name = "label5";
            label5.Size = new Size(150, 34);
            label5.TabIndex = 18;
            label5.Text = "Effective Date:";
            // 
            // lblTodayDate
            // 
            lblTodayDate.AutoSize = true;
            lblTodayDate.Font = new Font("Poppins", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTodayDate.ForeColor = Color.Black;
            lblTodayDate.Location = new Point(259, 259);
            lblTodayDate.Name = "lblTodayDate";
            lblTodayDate.Size = new Size(222, 34);
            lblTodayDate.TabIndex = 19;
            lblTodayDate.Text = "Today (MM:DD:YYYY)";
            lblTodayDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtReason
            // 
            txtReason.BackColor = SystemColors.ControlLight;
            txtReason.Location = new Point(173, 312);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(340, 34);
            txtReason.TabIndex = 20;
            txtReason.Theme = ControlTheme.Light;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(75, 312);
            label7.Name = "label7";
            label7.Size = new Size(90, 34);
            label7.TabIndex = 21;
            label7.Text = "Reason:";
            // 
            // cmbSpecialization
            // 
            cmbSpecialization.BackColor = Color.White;
            cmbSpecialization.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialization.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSpecialization.ForeColor = Color.Black;
            cmbSpecialization.FormattingEnabled = true;
            cmbSpecialization.IntegralHeight = false;
            cmbSpecialization.Items.AddRange(new object[] { "General Medicine", "Pediatrics", "OB-Gyne", "Internal Medicine", "Orthopedics", "Dermatology" });
            cmbSpecialization.Location = new Point(79, 366);
            cmbSpecialization.Name = "cmbSpecialization";
            cmbSpecialization.PlaceholderText = "Select a Specialization";
            cmbSpecialization.Size = new Size(434, 37);
            cmbSpecialization.TabIndex = 22;
            cmbSpecialization.Theme = ControlTheme.Light;
            cmbSpecialization.SelectedIndexChanged += cmbSpecialization_SelectedIndexChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(242, 37, 40);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins", 18F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(312, 546);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(201, 53);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(26, 117, 159);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Poppins", 18F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(93, 546);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.RightToLeft = RightToLeft.No;
            btnUpdate.Size = new Size(201, 53);
            btnUpdate.TabIndex = 33;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdateFee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 650);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(cmbSpecialization);
            Controls.Add(label7);
            Controls.Add(txtReason);
            Controls.Add(lblTodayDate);
            Controls.Add(label5);
            Controls.Add(txtNewFee);
            Controls.Add(lblCurrentFee);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateFee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += UpdateFee_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label lblCurrentFee;
        private RoundedTextBox txtNewFee;
        private Label label5;
        private Label lblTodayDate;
        private RoundedTextBox txtReason;
        private Label label7;
        private RoundedComboBox cmbSpecialization;
        private RoundedButton btnCancel;
        private RoundedButton btnUpdate;
        private PictureBox btnBack;
    }
}