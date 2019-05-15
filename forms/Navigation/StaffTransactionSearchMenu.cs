using Finance_Management.forms.Search;
using System;
using System.Windows.Forms;

namespace Finance_Management.forms.Navigation
{
    public partial class StaffTransactionSearchMenu : Form
    {
        private SearchMenu searchMenu;
        private SearchStaffTransaction searchStaffTransaction;
        private SearchHostelStaffTransaction searchHostelStaffTransaction;

        public StaffTransactionSearchMenu(SearchMenu searchMenu)
        {
            InitializeComponent();
            this.searchMenu = searchMenu;
            searchStaffTransaction = new SearchStaffTransaction(this);
            searchHostelStaffTransaction = new SearchHostelStaffTransaction(this);
        }

        private void Hostel_Click(object sender, EventArgs e)
        {
            searchHostelStaffTransaction.Show();
            Hide();
        }

        private void College_Click(object sender, EventArgs e)
        {
            searchStaffTransaction.Show();
            Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            searchMenu.Show();
            Hide();
        }

        private void StaffTransactionSearchMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            searchMenu.Show();
            Hide();
        }
    }
}
