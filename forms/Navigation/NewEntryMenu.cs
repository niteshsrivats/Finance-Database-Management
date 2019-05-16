using System;
using System.Windows.Forms;

namespace Finance_Management.forms.Navigation
{
    public partial class NewEntryMenu : Form
    {
        private Home home;
        private NewStudentEntry studentInfo;
        private NewStaffEntry staffInfo;

        public NewEntryMenu(Home home)
        {
            InitializeComponent();
            this.home = home;
            studentInfo = new NewStudentEntry(this);
            staffInfo = new NewStaffEntry(this);
        }

        private void Student_Click(object sender, EventArgs e)
        {
            studentInfo.Show();
            Hide();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            staffInfo.Show();
            Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            home.Show();
            Hide();
        }

        private void NewEntryMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            home.Show();
            Hide();
        }
    }
}
