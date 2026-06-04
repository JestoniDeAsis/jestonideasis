using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VitalHealth.Forms.Doctor
{
    public partial class DoctorEditProfile : Form
    {
        public DoctorEditProfile()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new DoctorAssignedPatients());
        }
    }
}
