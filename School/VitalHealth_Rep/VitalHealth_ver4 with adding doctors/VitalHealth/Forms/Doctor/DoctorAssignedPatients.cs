using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button2 = new Button();
            button1 = new Button();
            LblDoc = new Label();
            LblDocLastName = new Label();
            label1 = new Label();
            button3 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            roundedDataGridView1 = new VitalHealth.CustomControls.RoundedDataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(LblDoc);
            panel1.Controls.Add(LblDocLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-6, -5);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 1080);
            panel1.TabIndex = 2;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            button8.Image = Properties.Resources.EditProfileButtonIcon;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(1, 940);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Padding = new Padding(30, 0, 0, 0);
            button8.Size = new Size(366, 67);
            button8.TabIndex = 7;
            button8.Text = "Edit Profile";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            button7.Image = Properties.Resources.LogoutButtonIcon;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(1, 1012);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Padding = new Padding(30, 0, 0, 0);
            button7.Size = new Size(366, 67);
            button7.TabIndex = 6;
            button7.Text = "Logout";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-1, 199);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(26, 0, 0, 0);
            button2.Size = new Size(366, 67);
            button2.TabIndex = 4;
            button2.Text = "Patient's Record";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(-23, 130);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(13, 0, 0, 0);
            button1.Size = new Size(390, 67);
            button1.TabIndex = 1;
            button1.Text = "Assigned Patients";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
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
            // LblDocLastName
            // 
            LblDocLastName.AutoSize = true;
            LblDocLastName.Font = new Font("Zona Pro Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDocLastName.Location = new Point(182, 38);
            LblDocLastName.Name = "LblDocLastName";
            LblDocLastName.Size = new Size(116, 24);
            LblDocLastName.TabIndex = 2;
            LblDocLastName.Text = "lastname";
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
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 270);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(26, 0, 0, 0);
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(366, 67);
            button3.TabIndex = 2;
            button3.Text = "Schedule and Fee";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            label4.Click += label4_Click;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private Panel panel1;
        private Button button8;
        private Button button7;
        private Button button2;
        private Button button1;
        private Label LblDoc;
        private Label LblDocLastName;
        private Label label1;
        private Button button3;
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
        private Label label8;
        private Panel panel2;

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
