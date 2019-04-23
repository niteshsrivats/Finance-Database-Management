using Finance_Management.forms.Staff_Info;
using System;
using System.Windows.Forms;

namespace Finance_Management.forms.Navigation
{
    public partial class Home : Form
    {
        private StaffTransaction staffTransaction;
        private StudentTransactionMenu studentTransactionMenu;
        private NewEntryMenu newEntryMenu;
        private SearchMenu searchMenu;

        public Home()
        {
            InitializeComponent();
            staffTransaction = new StaffTransaction(this);
            studentTransactionMenu = new StudentTransactionMenu(this);
            newEntryMenu = new NewEntryMenu(this);
            searchMenu = new SearchMenu(this);
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            staffTransaction.Show();
            Hide();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            studentTransactionMenu.Show();
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            //DateTime today = DateTime.Now;
            //MessageBox.Show(today.ToString());
            newEntryMenu.Show();
            Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            searchMenu.Show();
            Hide();
        }
    }
}