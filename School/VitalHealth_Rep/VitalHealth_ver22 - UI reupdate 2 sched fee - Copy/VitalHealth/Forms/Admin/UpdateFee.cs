using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitalHealth.Forms.Admin
{
    public partial class UpdateFee : Form
    {
        public string NewFee { get; private set; }
        public string SelectedSpecialization { get; private set; }


        private void btnSave_Click(object sender, EventArgs e) // Assuming you have a save button
        {
            // Capture what the user typed/selected before the window closes
            // Replace 'cmbSpecialty' and 'txtFee' with your actual control names
            SelectedSpecialization = cmbSpecialization.Text;
            NewFee = txtNewFee.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewFee.Text))
            {
                MessageBox.Show("Please enter a valid fee amount.");
                return;
            }

            // Save the value and set result to OK
            NewFee = txtNewFee.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public UpdateFee()
        {
            InitializeComponent();
        }

        private void UpdateFee_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SelectedSpecialization = cmbSpecialization.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtNewFee.Text))
            {
                MessageBox.Show("Please enter a valid fee amount.");
                return;
            }

            // Save the value and set result to OK
            NewFee = txtNewFee.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbSpecialization_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
