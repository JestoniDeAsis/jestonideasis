using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Dialogs;

namespace VitalHealth.Forms.Nurse
{
    public partial class EditNurseProfile : Form
    {
        public EditNurseProfile()
        {
            InitializeComponent();
        }

        private void backNursePage_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new PatientsCheckUpForm());
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            saveChangesNurse dialog = new saveChangesNurse();
            DialogResult result = dialog.ShowDialog(this);

         }
    }
}
