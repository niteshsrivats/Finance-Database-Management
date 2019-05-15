using System;
using System.Windows.Forms;

namespace Finance_Management.forms.Navigation
{
    public partial class Home : Form
    {
        private NewTransactionMenu newTransactionMenu;
        private NewEntryMenu newEntryMenu;
        private SearchMenu searchMenu;

        public Home()
        {
            InitializeComponent();
            newTransactionMenu = new NewTransactionMenu(this);
            newEntryMenu = new NewEntryMenu(this);
            searchMenu = new SearchMenu(this);
        }

        private void Transaction_Click(object sender, EventArgs e)
        {
            newTransactionMenu.Show();
            Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
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