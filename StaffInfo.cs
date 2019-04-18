using System;
using System.Windows.Forms;

namespace Finance_Management
{
    public partial class StaffInfo : Form
    {
        public StaffInfo()
        {
            InitializeComponent();
        }

        private bool Validate_Form()
        {
            Validation validation = new Validation();
            if (!validation.EmployeeID(EmployeeIDBox.Text))
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

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Validate_Form())
            {
                DateTime today = DateTime.Today;
                SQL_Operator sql_operator = new SQL_Operator();
                string date = today.Year.ToString() + "-" + today.Month.ToString() + "-" + today.Day.ToString();
                string sqlQuery = "insert into staff_info(employee_id, name, type, join_date, designation) values('" + EmployeeIDBox.Text + "', '" + NameBox.Text + "', '" + TypeList.Text + "', date '" + date + "', '" + DesignationList.Text + "')";
                if (sql_operator.Insert(sqlQuery))
                {
                    MessageBox.Show("Inserted Entry", "Successful");
                }
                else
                {
                    MessageBox.Show("Employee ID Must Be Unique", "Failed");
                }
            }
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
    }
}
