using Finance_Management.forms.Scholarship;
using Finance_Management.forms.Student_Info;
using System;
using System.Windows.Forms;

namespace Finance_Management.forms.Navigation
{
    public partial class NewStudentTransactionMenu : Form
    {
        private NewScholarshipTransaction scholarshipTransaction;
        private StudentTransaction studentTransaction;
        private NewTransactionMenu newTransactionMenu;

        public NewStudentTransactionMenu(NewTransactionMenu newTransactionMenu)
        {
            InitializeComponent();
            scholarshipTransaction = new NewScholarshipTransaction(this);
            studentTransaction = new StudentTransaction(this);
            this.newTransactionMenu = newTransactionMenu;
        }

        private void Scholarship_Click(object sender, EventArgs e)
        {
            scholarshipTransaction.Show();
            Hide();
        }

        private void College_Click(object sender, EventArgs e)
        {
            studentTransaction.Show();
            Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            newTransactionMenu.Show();
            Hide();
        }

        private void StudentTransactionMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            newTransactionMenu.Show();
            Hide();
        }
    }
}
