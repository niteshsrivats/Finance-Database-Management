using System;
using System.Windows.Forms;

namespace Finance_Management.forms.Navigation
{
    public partial class SearchMenu : Form
    {
        private Home home;
        private StaffTransactionSearchMenu staffTransactionSearchMenu;
        private StudentTransactionSearchMenu studentTransactionSearchMenu;

        public SearchMenu(Home home)
        {
            InitializeComponent();
            this.home = home;
            staffTransactionSearchMenu = new StaffTransactionSearchMenu(this);
            studentTransactionSearchMenu = new StudentTransactionSearchMenu(this);
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            staffTransactionSearchMenu.Show();
            Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            home.Show();
            Hide();
        }

        private void SearchMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            home.Show();
            Hide();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            studentTransactionSearchMenu.Show();
            Hide();
        }
    }
}
