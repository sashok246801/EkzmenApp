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
    public partial class CapchaWindow : Form
    {
        public CapchaWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
