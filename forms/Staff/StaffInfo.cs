using Finance_Management.forms.Navigation;
using System;
using System.Windows.Forms;

namespace Finance_Management
{
    public partial class StaffInfo : Form
    {
        private SQL_Operator sql_operator = new SQL_Operator();
        private Validation validation = new Validation();
        private NewEntryMenu newEntryMenu;

        public StaffInfo(NewEntryMenu newEntryMenu)
        {
            InitializeComponent();
            this.newEntryMenu = newEntryMenu;
        }

        private void TypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesignationList.Items.Clear();
            switch (TypeList.Text)
            {
                case "Hostel":
                    DesignationList.Items.Add("Housekeeping");
                    DesignationList.Items.Add("Supervisor");
                    break;
                case "Non - Teaching Staff":
                    DesignationList.Items.Add("Housekeeping");
                    DesignationList.Items.Add("Lab Assistant");
                    break;
                case "Security":
                    DesignationList.Items.Add("Head Guard");
                    DesignationList.Items.Add("Officer");
                    break;
                case "Teaching Staff":
                    DesignationList.Items.Add("Assistant Professor");
                    DesignationList.Items.Add("Professor");
                    break;
            }
            LabelDesignation.Visible = true;
            DesignationList.Visible = true;
        }

        private bool Validate_Form()
        {
            if (!validation.EmployeeID(EmployeeIDBox.Text.ToUpper()))
            {
                MessageBox.Show("Invalid USN", "Invalid USN Error");
                return false;
            }
            else if (!validation.Name(NameBox.Text))
            {
                MessageBox.Show("Invalid Name", "Invalid Name Error");
                return false;
            }
            else if (!validation.ListBox(TypeList.Text))
            {
                MessageBox.Show("Select Type", "Invalid Type Error");
                return false;
            }
            else if (!validation.ListBox(DesignationList.Text))
            {
                MessageBox.Show("Select Designation", "Invalid Designation Error");
                return false;
            }
            return true;
        }

        private void Clear_All_Entries()
        {
            EmployeeIDBox.Clear();
            NameBox.Clear();
            TypeList.ClearSelected();
            DesignationList.ClearSelected();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Validate_Form())
            {
                DateTime today = DateTime.Today;
                string date = today.Year.ToString() + "-" + today.Month.ToString() + "-" + today.Day.ToString();
                string sqlQuery = "INSERT INTO STAFF_INFO (EMPLOYEE_ID, NAME, TYPE, JOIN_DATE, DESIGNATION) VALUES ('" + EmployeeIDBox.Text.ToUpper() + "', '" + NameBox.Text.ToUpper() + "', '" + TypeList.Text.ToUpper() + "', date '" + date + "', '" + DesignationList.Text.ToUpper() + "')";
                if (sql_operator.Insert(sqlQuery))
                {
                    MessageBox.Show("Inserted Entry", "Successful");
                    Clear_All_Entries();
                }
                else
                {
                    MessageBox.Show("Employee ID Must Be Unique", "Failed");
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            newEntryMenu.Show();
            Hide();
        }

        private void StaffInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            newEntryMenu.Show();
            Hide();
        }

        private void LabelEmployeeID_Click(object sender, EventArgs e)
        {
            EmployeeIDBox.Select();
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            NameBox.Select();
        }
    }
}