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
    public partial class MissedCheckups : Form
    {
        public MissedCheckups()
        {
            InitializeComponent();
        }

        private void MissedCheckups_Load(object sender, EventArgs e)
        {
            lbl_nurseLastName.Text = MainForm.loggedInUserLastname;
        }

        private void btn_checkupForm_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new PatientsCheckUpForm());
        }

        private void btn_todaysPatient_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new TodaysPatients());
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new LoginForm());
        }
    }
}
