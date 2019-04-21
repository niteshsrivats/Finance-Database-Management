using Finance_Management.forms.Navigation;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Finance_Management.forms.Scholarship
{
    public partial class ScholarshipTransaction : Form
    {
        private SQL_Operator sql_operator = new SQL_Operator();
        private Validation validation = new Validation();
        private StudentTransactionMenu studentTransactionMenu;
        private string scholarshipID;

        public ScholarshipTransaction(StudentTransactionMenu studentTransactionMenu)
        {
            InitializeComponent();
            this.studentTransactionMenu = studentTransactionMenu;
        }

        private string Get_Search_Query()
        {
            string sqlQuery = "SELECT USN, NAME \"Name\", GRADUATION_YEAR \"Graduation Year\" FROM STUDENT_INFO";
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
            else if (!validation.Amount(AmountBox.Text))
            {
                MessageBox.Show("Enter Positive Amount", "Invalid Amount Error");
                return false;
            }
            else if (!validation.ListBox(ScholarshipNameList.Text))
            {
                MessageBox.Show("Select Scholarship Name", "Invalid Scholarship Name Error");
                return false;
            }
            switch (ScholarshipNameList.Text)
            {
                case "KCET Scholarship For Defence Wards":
                    scholarshipID = "KCET_DEF";
                    break;
                case "National College Scholarship ":
                    scholarshipID = "NAT_COLL";
                    break;
                case "Bal Vidhya Scholarship":
                    scholarshipID = "BAL_VID";
                    break;
                case "Girl Child Scholarship":
                    scholarshipID = "GIRL_CHLD";
                    break;
                case "Sri Visveswaraya Scholarship":
                    scholarshipID = "SRI_VIS";
                    break;
                case "NCC Scholarship For Undergraduates":
                    scholarshipID = "NCC_UG";
                    break;
                case "Maritime Scholarship For Engineers":
                    scholarshipID = "MAR_ENG";
                    break;
                case "Excel Student Scholarship":
                    scholarshipID = "EXC_STU";
                    break;
                case "SC/ST Undergraduates Scholarship":
                    scholarshipID = "SC_ST";
                    break;
                case "Krishi Vidhya Scholarship":
                    scholarshipID = "KRI_VID";
                    break;
            }
            return true;
        }

        private void Clear_All_Entries()
        {
            USNBox.Clear();
            AmountBox.Clear();
            ScholarshipNameList.ClearSelected();
            SearchBox.Clear();
            DataView.DataSource = null;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Validate_Form())
            {
                DateTime today = DateTime.Now;
                int amount = int.Parse(AmountBox.Text) * -1;
                string time = today.Year.ToString() + "-" + today.Month.ToString() + "-" + today.Day.ToString() + " " + today.Hour.ToString() + ":" + today.Minute.ToString() + ":" + today.Second.ToString();
                string type = "SCHOLARSHIP: GOVERNMENT";
                if (scholarshipID.Equals("EXC_STU"))
                    type = "SCHOLARSHIP: COLLEGE";

      
                string sqlQuery = "INSERT INTO SCHOLARSHIP_TRANSACTION (SCHOLARSHIP_ID, USN) VALUES ('" + scholarshipID + "', '" + USNBox.Text.ToUpper() + "')";
        
                if (sql_operator.Insert(sqlQuery))
                {
                    MessageBox.Show("Inserted Entry", "Successful");
                    Clear_All_Entries();
                }
                else
                {
                    MessageBox.Show("USN does not exist", "Failed");
                }
                sqlQuery = "INSERT INTO STUDENT_TRANSACTION (USN, TYPE, TIME, AMOUNT) VALUES ('" + USNBox.Text.ToUpper() + "', '" + type.ToUpper() + "', TIMESTAMP'" + time + "', " + amount + ")";
                sql_operator.Insert(sqlQuery);
            }
        }

        private void LabelUSN_Click(object sender, EventArgs e)
        {
            USNBox.Select();
        }

        private void LabelAmount_Click(object sender, EventArgs e)
        {
            AmountBox.Select();
        }

        private void LabelSearch_Click(object sender, EventArgs e)
        {
            SearchBox.Select();
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