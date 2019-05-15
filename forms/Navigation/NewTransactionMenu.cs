using Finance_Management.forms.Staff_Info;
using System;
using System.Windows.Forms;

namespace Finance_Management.forms.Navigation
{
    public partial class NewTransactionMenu : Form
    {
        private Home home;
        private NewStaffTransaction newStaffTransaction;
        private NewStudentTransactionMenu newStudentTransactionMenu;

        public NewTransactionMenu(Home home)
        {
            InitializeComponent();
            this.home = home;
            newStaffTransaction = new NewStaffTransaction(this);
            newStudentTransactionMenu = new NewStudentTransactionMenu(this);
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            newStaffTransaction.Show();
            Hide();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            newStudentTransactionMenu.Show();
            Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            home.Show();
            Hide();
        }

        private void NewTransactionMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            home.Show();
            Hide();
        }
    }
}
