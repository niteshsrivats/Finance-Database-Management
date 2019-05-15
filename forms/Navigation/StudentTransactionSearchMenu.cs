using Finance_Management.forms.Search;
using System;
using System.Windows.Forms;

namespace Finance_Management.forms.Navigation
{
    public partial class StudentTransactionSearchMenu : Form
    {
        private SearchMenu searchMenu;
        private SearchStudentTransaction searchStudentTransaction;
        private SearchScholarshipTransaction searchScholarshipTransaction;

        public StudentTransactionSearchMenu(SearchMenu searchMenu)
        {
            InitializeComponent();
            this.searchMenu = searchMenu;
            searchStudentTransaction = new SearchStudentTransaction(this);
            searchScholarshipTransaction = new SearchScholarshipTransaction(this);
        }

        private void Scholarship_Click(object sender, EventArgs e)
        {
            searchScholarshipTransaction.Show();
            Hide();
        }

        private void College_Click(object sender, EventArgs e)
        {
            searchStudentTransaction.Show();
            Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            searchMenu.Show();
            Hide();
        }

        private void StudentTransactionSearchMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            searchMenu.Show();
            Hide();
        }
    }
}
