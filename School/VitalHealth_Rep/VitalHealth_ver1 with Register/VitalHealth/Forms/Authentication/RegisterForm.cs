using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VitalHealth.Forms.Dialogs;

namespace VitalHealth.Forms.Authentication
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm.Instance.OpenChildForm(new IndexForm());
        }

        private bool passwordShown = false;
        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            if (!passwordShown)
            {
                txtB_password.UseSystemPasswordChar = false;
                passwordShown = true;
                btn_showPassword.Image = Properties.Resources.shown_icon;
            }
            else
            {
                txtB_password.UseSystemPasswordChar = true;
                passwordShown = false;
                btn_showPassword.Image = Properties.Resources.hidden_icon;
            }
        }

        private bool confirmPasswordShown = false;
        private void btn_showConfirmPassword_Click(object sender, EventArgs e)
        {
            if (!confirmPasswordShown)
            {
                txtB_confirmPassword.UseSystemPasswordChar = false;
                confirmPasswordShown = true;
                btn_showConfirmPassword.Image = Properties.Resources.shown_icon;
            }
            else
            {
                txtB_confirmPassword.UseSystemPasswordChar = true;
                confirmPasswordShown = false;
                btn_showConfirmPassword.Image = Properties.Resources.hidden_icon;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegistrationComplete dialog = new RegistrationComplete();
            DialogResult result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                MainForm.Instance.OpenChildForm(new LoginForm());
            }
        }
    }
}
