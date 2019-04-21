using Finance_Management.forms.Scholarship;
using Finance_Management.forms.Student_Info;
using System;
using System.Windows.Forms;

namespace Finance_Management.forms.Navigation
{
    public partial class StudentTransactionMenu : Form
    {
        private ScholarshipTransaction scholarshipTransaction;
        private StudentTransaction studentTransaction;
        private Home home;

        public StudentTransactionMenu(Home home)
        {
            InitializeComponent();
            scholarshipTransaction = new ScholarshipTransaction(this);
            studentTransaction = new StudentTransaction(this);
            this.home = home;
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
            home.Show();
            Hide();
        }

        private void StudentTransactionMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            home.Show();
            Hide();
        }
    }
}
