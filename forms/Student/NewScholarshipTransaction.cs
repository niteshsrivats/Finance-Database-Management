using Finance_Management.forms.Navigation;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Finance_Management.forms.Scholarship
{
    public partial class NewScholarshipTransaction : Form
    {
        private SQL_Operator sql_operator = new SQL_Operator();
        private Validation validation = new Validation();
        private NewStudentTransactionMenu studentTransactionMenu;
        private string scholarshipID;

        public NewScholarshipTransaction(NewStudentTransactionMenu studentTransactionMenu)
        {
            InitializeComponent();
            this.studentTransactionMenu = studentTransactionMenu;
        }

        private string Get_Search_Query()
        {
            string sqlQuery = "SELECT usn, name \"Name\", graduation_year \"Graduation Year\" FROM STUDENT_INFO";
            Regex searchExp = new Regex("[0-9]+");
            if (searchExp.Match(SearchBox.Text).Success)
            {
                sqlQuery += " WHERE USN LIKE '%" + SearchBox.Text.ToUpper() + "%'";
            }
            else
            {
                sqlQuery += " WHERE NAME LIKE '%" + SearchBox.Text.ToUpper() + "%'";
            }
            return sqlQuery;
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                string sqlQuery = Get_Search_Query();
                sql_operator.Display(sqlQuery, DataView);
            }
        }

        private bool Validate_Form()
        {
            if (!validation.USN(USNBox.Text.ToUpper()))
            {
                MessageBox.Show("Invalid USN", "Invalid USN Error");
                return false;
            }
            else if (!validation.ListBox(ScholarshipNameList.Text))
            {
                MessageBox.Show("Select Scholarship Name", "Invalid Scholarship Name Error");
                return false;
            }
            return true;
        }

        private void Clear_All_Entries()
        {
            USNBox.Clear();
            ScholarshipNameList.ClearSelected();
            SearchBox.Clear();
            AmountBox.Clear();
            DataView.DataSource = null;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Validate_Form())
            {
                DateTime today = DateTime.Now;
                string time = today.Year.ToString() + "-" + today.Month.ToString() + "-" + today.Day.ToString() + " " + today.Hour.ToString() + ":" + today.Minute.ToString() + ":" + today.Second.ToString();
      
                string sqlQuery = "INSERT INTO SCHOLARSHIP_TRANSACTION(scholarship_id, usn, time, amount) VALUES ('" + scholarshipID + "', '" + USNBox.Text.ToUpper() + "', timestamp '" + time + "', -" + AmountBox.Text + ")";
        
                if (sql_operator.Insert(sqlQuery))
                {
                    MessageBox.Show("Inserted Entry", "Successful");
                    Clear_All_Entries();
                }
                else
                {
                    MessageBox.Show("USN does not exist", "Failed");
                    MessageBox.Show(sqlQuery);
                }
            }
        }

        private void LabelUSN_Click(object sender, EventArgs e)
        {
            USNBox.Select();
        }

        private void LabelSearch_Click(object sender, EventArgs e)
        {
            SearchBox.Select();
        }

        private void ScholarshipNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ScholarshipNameList.Text)
            {
                case "KCET Scholarship For Defence Wards":
                    scholarshipID = "KCET_DEF";
                    AmountBox.Text = "6500";
                    break;
                case "National College Scholarship ":
                    scholarshipID = "NAT_COLL";
                    AmountBox.Text = "8000";
                    break;
                case "Bal Vidhya Scholarship":
                    scholarshipID = "BAL_VID";
                    AmountBox.Text = "12500";
                    break;
                case "Girl Child Scholarship":
                    scholarshipID = "GIRL_CHLD";
                    AmountBox.Text = "5000";
                    break;
                case "Sri Visveswaraya Scholarship":
                    scholarshipID = "SRI_VIS";
                    AmountBox.Text = "7500";
                    break;
                case "NCC Scholarship For Undergraduates":
                    scholarshipID = "NCC_UG";
                    AmountBox.Text = "15000";
                    break;
                case "Maritime Scholarship For Engineers":
                    scholarshipID = "MAR_ENG";
                    AmountBox.Text = "9000";
                    break;
                case "Excel Student Scholarship":
                    scholarshipID = "EXC_STU";
                    AmountBox.Text = "10000";
                    break;
                case "SC/ST Undergraduates Scholarship":
                    scholarshipID = "SC_ST";
                    AmountBox.Text = "6000";
                    break;
                case "Krishi Vidhya Scholarship":
                    scholarshipID = "KRI_VID";
                    AmountBox.Text = "3000";
                    break;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            studentTransactionMenu.Show();
            Hide();
            Clear_All_Entries();
        }

        private void ScholarshipTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            studentTransactionMenu.Show();
            Hide();
            Clear_All_Entries();
        }
    }
}