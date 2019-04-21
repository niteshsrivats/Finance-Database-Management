using Finance_Management.forms.Navigation;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Finance_Management.forms.Hostel_Staff
{
    public partial class HostelStaff : Form
    {
        private SQL_Operator sql_operator = new SQL_Operator();
        private Validation validation = new Validation();
        private NewEntryMenu newEntryMenu;

        public HostelStaff(NewEntryMenu newEntryMenu)
        {
            InitializeComponent();
            this.newEntryMenu = newEntryMenu;
        }

        private string Get_Search_Query()
        {
            string sqlQuery = "SELECT EMPLOYEE_ID \"Employee Id\" , NAME \"Name\", TYPE \"Type\" FROM STAFF_INFO";
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
        private bool Validate_Entry()
        {
            if (!validation.EmployeeID(WardenBox.Text.ToUpper()))
            {
                MessageBox.Show("Invalid Warded ID", "Invalid Name Error");
                return false;
            }
            else if (!validation.EmployeeID(SupervisorBox.Text.ToUpper()))
            {
                MessageBox.Show("Invalid Supervisor ID", "Invalid Warden ID Error");
                return false;
            }
            else if (!validation.ListBox(BlockList.Text))
            {
                MessageBox.Show("Select Hostel Block", "Invalid Hostel Block Error");
                return false;
            }
            return true;
        }

        private void Clear_All_Entries()
        {
            WardenBox.Clear();
            SupervisorBox.Clear();
            BlockList.ClearSelected();
            SearchBox.Clear();
            DataView.DataSource = null;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Validate_Entry())
            {
                string sqlQuery = "INSERT INTO HOSTEL_STAFF (WARDEN_ID, SUPERVISOR_ID, BLOCK) VALUES ('" + WardenBox.Text.ToUpper() + "', '" + SupervisorBox.Text.ToUpper() + "', '" + BlockList.Text + "')";
                if (sql_operator.Insert(sqlQuery))
                {
                    MessageBox.Show("Inserted Entry", "Successful");
                    Clear_All_Entries();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Block already exists. \nProceed to update entry?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlQuery = "UPDATE HOSTEL_STAFF SET WARDEN_ID='" + WardenBox.Text.ToUpper() + "', SUPERVISOR_ID='" + SupervisorBox.Text.ToUpper() + "' WHERE BLOCK='" + BlockList.Text + "'";
                        if (sql_operator.Update(sqlQuery))
                        {
                            MessageBox.Show("Updated Entry", "Successful");
                            Clear_All_Entries();
                        }
                        else
                        {
                            MessageBox.Show("Employee ID does not exist", "Failed");
                        }
                    }
                    else
                    {
                        Clear_All_Entries();
                    }
                }
            }
        }

        private void LabelWardenID_Click(object sender, EventArgs e)
        {
            WardenBox.Select();
        }

        private void LabelSupervisorID_Click(object sender, EventArgs e)
        {
            SupervisorBox.Select();
        }

        private void LabelSearch_Click(object sender, EventArgs e)
        {
            SearchBox.Select();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            newEntryMenu.Show();
            Hide();
            Clear_All_Entries();
        }

        private void HostelStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            newEntryMenu.Show();
            Hide();
            Clear_All_Entries();
        }
    }
}