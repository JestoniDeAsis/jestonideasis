using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Authentication;

namespace VitalHealth.Forms.Nurse
{
    public partial class PatientsCheckUpForm : Form
    {
        public PatientsCheckUpForm()
        {
            InitializeComponent();
        }

        private void PatientsCheckUpForm_Load(object sender, EventArgs e)
        {
            lbl_nurseLastName.Text = MainForm.loggedInUserID.ToString();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new LoginForm());
        }
    }
}
