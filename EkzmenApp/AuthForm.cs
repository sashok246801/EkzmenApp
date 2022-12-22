using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EkzmenApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(LoginTextBox.Text == "111" && PasswordTextBox.Text == "111")
            {
                CapchaWindow capchaWindow = new CapchaWindow();
                capchaWindow.ShowDialog();
                this.Hide();
            }
            else
            {
                ErrorLabel.Visible = true;
            }
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
        }
    }
}
