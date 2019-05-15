using Finance_Management.forms.Navigation;
using System;
using System.Windows.Forms;

namespace Finance_Management
{
    public partial class StudentInfo : Form
    {
        private NewEntryMenu newEntryMenu;

        public StudentInfo(NewEntryMenu newEntryMenu)
        {
            InitializeComponent();
            this.newEntryMenu = newEntryMenu;
        }

        private bool Validate_Form()
        {
            Validation validation = new Validation();
            if (!validation.Name(NameBox.Text))
            {
                MessageBox.Show("Invalid Name", "Invalid Name Error");
                return false;
            }
            else if (!validation.USN(USNBox.Text.ToUpper()))
            {
                MessageBox.Show("Invalid USN", "Invalid USN Error");
                return false;
            }
            else if (!validation.DOB(DOBBox.Text))
            {
                MessageBox.Show("Invalid DOB", "Invalid DOB Error");
                return false;
            }
            return true;
        }

        private void Clear_All_Entries()
        {
            USNBox.Clear();
            NameBox.Clear();
            DOBBox.Clear();
            NoButton.Checked = true;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Validate_Form())
            {
                DateTime today = DateTime.Today;
                SQL_Operator sql_operator = new SQL_Operator();
                int graduation_year = today.Year + 4;
                string sqlQuery = null;
                if (YesButton.Checked)
                {
                    sqlQuery = "INSERT INTO STUDENT_INFO (usn, name, dob, graduation_year, hostel_id) VALUES ('" + USNBox.Text.ToUpper() + "', '" + NameBox.Text.ToUpper() + "', DATE '" + DOBBox.Text + "', " + graduation_year + ", HOSTEL_ID_SEQUENCE.NEXTVAL)";
                }
                else
                {
                    sqlQuery = "INSERT INTO STUDENT_INFO (usn, name, dob, graduation_year) VALUES ('" + USNBox.Text.ToUpper() + "', '" + NameBox.Text.ToUpper() + "', DATE '" + DOBBox.Text + "', " + graduation_year + ")";
                }
                if (sql_operator.Insert(sqlQuery))
                {
                    MessageBox.Show("Inserted Entry", "Successful");
                    Clear_All_Entries();
                }
                else
                {
                    MessageBox.Show("USN Must Be Unique", "Failed");
                }
            }
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            NameBox.Select();
        }

        private void LabelUsn_Click(object sender, EventArgs e)
        {
            USNBox.Select();
        }

        private void LabelDob_Click(object sender, EventArgs e)
        {
            DOBBox.Select();
        }

        private void StudentInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            newEntryMenu.Show();
            Hide();
            Clear_All_Entries();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            newEntryMenu.Show();
            Hide();
            Clear_All_Entries();
        }
    }
}