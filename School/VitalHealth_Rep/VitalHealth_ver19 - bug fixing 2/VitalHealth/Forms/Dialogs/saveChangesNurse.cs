using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Nurse;

namespace VitalHealth.Forms.Dialogs
{
    public partial class saveChangesNurse : Form
    {
        public saveChangesNurse()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Yes;
         

            ProfUpdatedSuccessfully dialog = new ProfUpdatedSuccessfully();
            DialogResult result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                //MainForm.Instance.OpenChildForm(new RegisterForm());
                MainForm.Instance.OpenChildForm(new EditNurseProfile());
            }

          

        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
