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
    public partial class UserPanel : UserControl
    {
        public UserPanel()
        {
            InitializeComponent();
        }
        public UserPanel(string ProductName)
        {
            InitializeComponent();
            UserPanel_Title.Text = ProductName;
        }
        public UserPanel(string ProductName, string ProductDescription, string ProductManufacturer, decimal ProductCost, decimal ProductTotalCost)
        {
            InitializeComponent();

            UserPanel_Title.Text = ProductName;
            UserPanel_Description.Text = ProductDescription;
            UserPanel_Manufacturer.Text = ProductManufacturer;
            UserPanel_Cost.Text = ProductCost.ToString();
            UserPanel_TotalCost.Text = ProductTotalCost.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserPanel_Load(object sender, EventArgs e)
        {

        }

        public string getTitle()
        {
            return UserPanel_Title.Text;
        }

        public string getManufacturer()
        {
            return UserPanel_Manufacturer.Text;
        }
    }
}
