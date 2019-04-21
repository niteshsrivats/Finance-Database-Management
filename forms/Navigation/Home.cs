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
        
        public Home()
        {
            InitializeComponent();
            staffTransaction = new StaffTransaction(this);
            studentTransactionMenu = new StudentTransactionMenu(this);
            newEntryMenu = new NewEntryMenu(this);
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
            newEntryMenu.Show();
            Hide();
        }
    }
}
