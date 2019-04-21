using Finance_Management.forms.Navigation;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Finance_Management.forms.Staff_Info
{
    public partial class StaffTransaction : Form
    {
        private SQL_Operator sql_operator = new SQL_Operator();
        private Validation validation = new Validation();
        private Home home;

        public StaffTransaction(Home home)
        {
            InitializeComponent();
            this.home = home;
        }

        private string Get_Search_Query()
        {
            string sqlQuery = "SELECT EMPLOYEE_ID \"Employee ID\", NAME \"Name\", JOIN_DATE \"Join Date\" FROM STAFF_INFO";
            Regex searchExp = new Regex("[0-9]+");
            if (searchExp.Match(SearchBox.Text).Success)
            {
                sqlQuery += " WHERE EMPLOYEE_ID LIKE '%" + SearchBox.Text.ToUpper() + "%'";
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
            if (CategoryList.Text.Equals("Miscellaneous"))
            {
                Credit.Enabled = true;
            }
            else
            {
                Debit.Checked = true;
                Credit.Enabled = false;
            }
        }

        private bool Validate_Entry()
        {
            if (!validation.EmployeeID(EmployeeIDBox.Text.ToUpper()))
            {
                MessageBox.Show("Invalid Employee ID", "Invalid Employee ID Error");
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
            EmployeeIDBox.Clear();
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
                string sqlQuery = "INSERT INTO STAFF_TRANSACTION (EMPLOYEE_ID, TYPE, TIME, AMOUNT) VALUES ('" + EmployeeIDBox.Text.ToUpper() + "', 'STAFF: " + CategoryList.Text.ToUpper() + "', TIMESTAMP '" + time + "', " + amount + ")";
                if (sql_operator.Insert(sqlQuery))
                {
                    MessageBox.Show("Inserted Entry", "Successful");
                    Clear_All_Entries();
                }
                else
                {
                    MessageBox.Show("Employee ID does not exist", "Failed");
                }
            }
        }

        private void LabelEmployeeID_Click(object sender, EventArgs e)
        {
            EmployeeIDBox.Select();
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
            home.Show();
            Hide();
            Clear_All_Entries();
        }

        private void StaffTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            home.Show();
            Hide();
            Clear_All_Entries();
        }
    }
}