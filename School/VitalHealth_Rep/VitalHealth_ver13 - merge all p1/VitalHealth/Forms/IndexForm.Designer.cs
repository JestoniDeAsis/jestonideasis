namespace VitalHealth
{
    partial class IndexForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            lbl_h1 = new Label();
            btn_goToLogin = new RoundedButton();
            btn_exitApp = new RoundedButton();
            lbl_p = new Label();
            picB_vitalHealthLogo = new PictureBox();
            picB_people_1 = new PictureBox();
            picB_people_2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picB_vitalHealthLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picB_people_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picB_people_2).BeginInit();
            SuspendLayout();
            // 
            // lbl_h1
            // 
            lbl_h1.AutoSize = true;
            lbl_h1.BackColor = Color.Transparent;
            lbl_h1.Font = new Font("Zona Pro Bold", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_h1.Location = new Point(506, 141);
            lbl_h1.Name = "lbl_h1";
            lbl_h1.Size = new Size(889, 104);
            lbl_h1.TabIndex = 0;
            lbl_h1.Text = "VitalHealth - Your Partner in Better\r\nHealth.";
            lbl_h1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_goToLogin
            // 
            btn_goToLogin.BackColor = Color.FromArgb(26, 117, 159);
            btn_goToLogin.Cursor = Cursors.Hand;
            btn_goToLogin.FlatAppearance.BorderSize = 0;
            btn_goToLogin.FlatStyle = FlatStyle.Flat;
            btn_goToLogin.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_goToLogin.ForeColor = Color.White;
            btn_goToLogin.Location = new Point(835, 540);
            btn_goToLogin.Name = "btn_goToLogin";
            btn_goToLogin.Size = new Size(250, 50);
            btn_goToLogin.TabIndex = 2;
            btn_goToLogin.Text = "GO TO LOGIN";
            btn_goToLogin.UseVisualStyleBackColor = false;
            btn_goToLogin.Click += btn_goToLogin_Click;
            // 
            // btn_exitApp
            // 
            btn_exitApp.BackColor = Color.Black;
            btn_exitApp.Cursor = Cursors.Hand;
            btn_exitApp.FlatAppearance.BorderSize = 0;
            btn_exitApp.FlatStyle = FlatStyle.Flat;
            btn_exitApp.Font = new Font("Zona Pro Bold", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exitApp.ForeColor = Color.White;
            btn_exitApp.Location = new Point(835, 600);
            btn_exitApp.Name = "btn_exitApp";
            btn_exitApp.Size = new Size(250, 50);
            btn_exitApp.TabIndex = 3;
            btn_exitApp.Text = "EXIT TO DESKTOP";
            btn_exitApp.UseVisualStyleBackColor = false;
            btn_exitApp.Click += btn_exitApp_Click;
            // 
            // lbl_p
            // 
            lbl_p.AutoSize = true;
            lbl_p.BackColor = Color.Transparent;
            lbl_p.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_p.Location = new Point(577, 273);
            lbl_p.Name = "lbl_p";
            lbl_p.Size = new Size(739, 73);
            lbl_p.TabIndex = 4;
            lbl_p.Text = resources.GetString("lbl_p.Text");
            lbl_p.TextAlign = ContentAlignment.MiddleCenter;
            lbl_p.UseCompatibleTextRendering = true;
            // 
            // picB_vitalHealthLogo
            // 
            picB_vitalHealthLogo.BackColor = Color.Transparent;
            picB_vitalHealthLogo.Image = Properties.Resources.VitalHealth_Logo;
            picB_vitalHealthLogo.Location = new Point(52, 38);
            picB_vitalHealthLogo.Name = "picB_vitalHealthLogo";
            picB_vitalHealthLogo.Size = new Size(114, 114);
            picB_vitalHealthLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picB_vitalHealthLogo.TabIndex = 5;
            picB_vitalHealthLogo.TabStop = false;
            // 
            // picB_people_1
            // 
            picB_people_1.BackColor = Color.Transparent;
            picB_people_1.Image = (Image)resources.GetObject("picB_people_1.Image");
            picB_people_1.Location = new Point(-9, 402);
            picB_people_1.Name = "picB_people_1";
            picB_people_1.Size = new Size(644, 717);
            picB_people_1.SizeMode = PictureBoxSizeMode.StretchImage;
            picB_people_1.TabIndex = 6;
            picB_people_1.TabStop = false;
            // 
            // picB_people_2
            // 
            picB_people_2.BackColor = Color.Transparent;
            picB_people_2.Image = (Image)resources.GetObject("picB_people_2.Image");
            picB_people_2.Location = new Point(1267, 402);
            picB_people_2.Name = "picB_people_2";
            picB_people_2.Size = new Size(644, 717);
            picB_people_2.SizeMode = PictureBoxSizeMode.StretchImage;
            picB_people_2.TabIndex = 7;
            picB_people_2.TabStop = false;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.landingpage_bg;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(picB_vitalHealthLogo);
            Controls.Add(btn_exitApp);
            Controls.Add(btn_goToLogin);
            Controls.Add(lbl_h1);
            Controls.Add(lbl_p);
            Controls.Add(picB_people_1);
            Controls.Add(picB_people_2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IndexForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "IndexForm";
            ((System.ComponentModel.ISupportInitialize)picB_vitalHealthLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picB_people_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picB_people_2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_h1;
        private RoundedButton btn_goToLogin;
        private RoundedButton btn_exitApp;
        private Label lbl_p;
        private PictureBox picB_vitalHealthLogo;
        private PictureBox picB_people_1;
        private PictureBox picB_people_2;
    }
}
