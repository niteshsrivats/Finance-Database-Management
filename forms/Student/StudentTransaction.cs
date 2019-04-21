using Finance_Management.forms.Navigation;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Finance_Management.forms.Student_Info
{
    public partial class StudentTransaction : Form
    {
        private SQL_Operator sql_operator = new SQL_Operator();
        private Validation validation = new Validation();
        private StudentTransactionMenu studentTransactionMenu;

        public StudentTransaction(StudentTransactionMenu studentTransactionMenu)
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

        private void CategoryList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CategoryList.Text.EndsWith("Miscellaneous") || CategoryList.Text.EndsWith("Security Deposit"))
            {
                Debit.Enabled = true;
            }
            else
            {
                Credit.Checked = true;
                Debit.Enabled = false;
            }
        }

        private bool Validate_Entry()
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
            else if (!validation.ListBox(CategoryList.Text))
            {
                MessageBox.Show("Select Transaction Category", "Invalid Transaction Category Error");
                return false;
            }
            return true;
        }

        private void Clear_All_Entries()
        {
            USNBox.Clear();
            AmountBox.Clear();
            CategoryList.ClearSelected();
            SearchBox.Clear();
            DataView.DataSource = null;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Validate_Entry())
            {
                DateTime today = DateTime.Now;
                string time = today.Year.ToString() + "-" + today.Month.ToString() + "-" + today.Day.ToString() + " " + today.Hour.ToString() + ":" + today.Minute.ToString() + ":" + today.Second.ToString();
                int amount = int.Parse(AmountBox.Text);
                if (Debit.Checked)
                    amount *= -1;

                string sqlQuery = "INSERT INTO STUDENT_TRANSACTION (USN, TYPE, TIME, AMOUNT) VALUES ('" + USNBox.Text.ToUpper() + "', '" + CategoryList.Text.ToUpper() + "', TIMESTAMP '" + time + "', " + amount + ")";
                if (sql_operator.Insert(sqlQuery))
                {
                    MessageBox.Show("Inserted Entry", "Successful");
                    Clear_All_Entries();
                }
                else
                {
                    MessageBox.Show("USN does not exist", "Failed");
                }
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

        private void StudentTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            studentTransactionMenu.Show();
            Hide();
            Clear_All_Entries();
        }
    }
}