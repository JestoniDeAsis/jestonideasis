using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Authentication;

namespace VitalHealth.Forms.Doctor
{
    public partial class DoctorPatientPastRecord : Form
    {
        public DoctorPatientPastRecord()
        {
            InitializeComponent();
        }

        private void PatientPastRecord_Load(object sender, EventArgs e)
        {
            lbl_doctorLastName.Text = MainForm.loggedInUserLastname;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new LoginForm());
        }

        private void btn_assignedPatients_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorAssignedPatients());
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
