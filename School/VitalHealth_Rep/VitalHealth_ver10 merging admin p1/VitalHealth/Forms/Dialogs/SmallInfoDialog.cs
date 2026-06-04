using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VitalHealth.Forms.Dialogs
{
    public partial class SmallInfoDialog : Form
    {
        public SmallInfoDialog()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void setResult(String message, Image image_icon)
        {
            picB_messageIcon.Image = image_icon;
            lbl_message.Text = message;
        }

        private void picB_messageIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
