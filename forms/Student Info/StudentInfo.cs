using System;
using System.Windows.Forms;

namespace Finance_Management
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private bool Validate_Form()
        {
            Validation validation = new Validation();
            if (!validation.Name(NameBox.Text))
            {
                MessageBox.Show("Invalid Name", "Invalid Name Error");
                return false;
            }
            else if (!validation.USN(USNBox.Text))
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
                    sqlQuery = "insert into student_info(usn, name, dob, graduation_year, hostel_id) values('" + USNBox.Text + "', '" + NameBox.Text + "', date '" + DOBBox.Text + "', " + graduation_year + ", hostel_id_sequence.nextval)";
                }
                else
                {
                    sqlQuery = "insert into student_info(usn, name, dob, graduation_year) values('" + USNBox.Text + "', '" + NameBox.Text + "', date '" + DOBBox.Text + "', " + graduation_year + ")";
                }
                if (sql_operator.Insert(sqlQuery))
                {
                    MessageBox.Show("Inserted Entry", "Successful");
                }
                else
                {
                    MessageBox.Show("USN Must Be Unique", "Failed");
                }
            }
        }
    }
}
