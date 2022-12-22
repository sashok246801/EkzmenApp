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
    public partial class MainForm : Form
    {
        public List<UserPanel> AllUserPanels = new List<UserPanel>();
        public List<UserPanel> FilteredPanels = new List<UserPanel>();
        public List<UserPanel> OrderUserList = new List<UserPanel>();
        public int NowPage = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i =1; i < 50; i++)
            {
                UserPanel user_panel = new UserPanel("Книга " + i);
                MainFlow.Controls.Add(user_panel);
                AllUserPanels.Add(user_panel);
            }

            UserPanel user_panel1 = new UserPanel("P1","p1p1","M1",100,200);
            MainFlow.Controls.Add(user_panel1);
            AllUserPanels.Add(user_panel1);
            user_panel1 = new UserPanel("P2", "p1p2", "M2", 100, 200);
            MainFlow.Controls.Add(user_panel1);
            AllUserPanels.Add(user_panel1);
            user_panel1 = new UserPanel("P3", "p1p2", "M2", 150, 230);
            MainFlow.Controls.Add(user_panel1);
            AllUserPanels.Add(user_panel1);
            user_panel1 = new UserPanel("P0", "p1p3", "M2", 120, 210);
            MainFlow.Controls.Add(user_panel1);
            AllUserPanels.Add(user_panel1);

            FilterPanels(0);
            ShowPage(1);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ShowRightPanels();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserPanel[] temp_AllUserPanels = AllUserPanels.ToArray();
            
            UserPanel tempUserPanel;
            for (int i = 0; i < temp_AllUserPanels.Length; i++)
            {
                for (int j = i + 1; j < temp_AllUserPanels.Length; j++)
                {
                    if (String.Compare(temp_AllUserPanels[i].getTitle(), temp_AllUserPanels[j].getTitle()) == 1)
                    {
                        tempUserPanel = temp_AllUserPanels[i];
                        temp_AllUserPanels[i] = temp_AllUserPanels[j];
                        temp_AllUserPanels[j] = tempUserPanel;
                    }
                }
            }

            if(SortComboBox.SelectedIndex == 1)
            {
                temp_AllUserPanels = temp_AllUserPanels.Reverse().ToArray();
            }

            MainFlow.Controls.Clear();
            foreach(UserPanel CurrentUserPanel in temp_AllUserPanels)
            {
                MainFlow.Controls.Add(CurrentUserPanel);
            }
        }

        private void FiltrComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterPanels(FiltrComboBox.SelectedIndex);
        }

        void FilterPanels(int index)
        {
            FilteredPanels.Clear();

            if (index == 0)
            {
                FilteredPanels = AllUserPanels.ToList();
            }
            else
            {
                string filter = FiltrComboBox.Items[index].ToString();

                foreach (UserPanel CurrentUserPanel in AllUserPanels)
                {
                    if (CurrentUserPanel.getManufacturer() == filter)
                    {
                        FilteredPanels.Add(CurrentUserPanel);
                    }
                }
            }

            ShowRightPanels();
        }

        void ShowRightPanels()
        {
            OrderUserList.Clear();
            string SearchTarget = SearchTextBox.Text;
            if(SearchTarget == "Введите для поиска")
            {
                SearchTarget = "";
            }
            foreach (UserPanel CurrentUserPanel in AllUserPanels)
            {
                if (CurrentUserPanel.getTitle().Contains(SearchTarget) && FilteredPanels.Contains(CurrentUserPanel))
                {
                    OrderUserList.Add(CurrentUserPanel);
                    CurrentUserPanel.Show();
                }
                else
                {
                    CurrentUserPanel.Hide();
                }
            }

            UpdateLinks();
        }

        void UpdateLinks()
        {
            NavigationButton_1.Hide();
            NavigationButton_2.Hide();
            NavigationButton_3.Hide();
            NavigationButton_4.Hide();

            int PageCount = OrderUserList.Count / 10;
            if(PageCount < 1) { PageCount = 1; }

            if (PageCount < 4)
            {
                if (PageCount < 3)
                {
                    if(PageCount < 2)
                    {
                        NavigationButton_1.Show();
                        NavigationButton_1.Text = "1";

                    }
                    else
                    {
                        NavigationButton_1.Show();
                        NavigationButton_1.Text = "1";

                        NavigationButton_2.Show();
                        NavigationButton_2.Text = "2";
                    }
                }
                else
                {
                    NavigationButton_1.Show();
                    NavigationButton_1.Text = "1";

                    NavigationButton_2.Show();
                    NavigationButton_2.Text = "2";

                    NavigationButton_3.Show();
                    NavigationButton_3.Text = "3";
                }
            }
            else
            {
                NavigationButton_1.Show();
                NavigationButton_1.Text = "1";

                NavigationButton_2.Show();
                NavigationButton_2.Text = "2";

                NavigationButton_3.Show();
                NavigationButton_3.Text = "3";

                NavigationButton_4.Show();
                NavigationButton_4.Text = "4";
            }

        }

        void ShowPage(int PageNumber)
        {
            if(PageNumber > (OrderUserList.Count / 10)+1 || PageNumber < 1)
            {
                return;
            }

            foreach(UserPanel CurrentUserPanel in OrderUserList)
            {
                CurrentUserPanel.Hide();
            }

            for(int i = PageNumber * 10 - 10; i < PageNumber * 10; i++)
            {
                if(OrderUserList.Count -1  >= i && OrderUserList[i] != null)
                {
                    OrderUserList[i].Show();
                }
            }

            if(PageNumber > 4)
            {
                NavigationButton_1.Text = (PageNumber - 3).ToString();
                NavigationButton_2.Text = (PageNumber - 2).ToString();
                NavigationButton_3.Text = (PageNumber - 1).ToString();
                NavigationButton_4.Text = (PageNumber).ToString();
            }
            else
            {
                NavigationButton_1.Text = "1";
                NavigationButton_2.Text = "2";
                NavigationButton_3.Text = "3";
                NavigationButton_4.Text = "4";
            }
            NowPage = PageNumber;
        }

        private void NavigationButton_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel CurrentLinkLabel = sender as LinkLabel;

            switch (CurrentLinkLabel.Text)
            {
                case ">":
                    ShowPage(NowPage+1);
                    break;

                case "<":
                    ShowPage(NowPage - 1);
                    break;

                default:
                    ShowPage(int.Parse(CurrentLinkLabel.Text));
                    break;
            }

        }
    }
}
