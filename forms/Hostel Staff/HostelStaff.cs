using System;
using System.Windows.Forms;

namespace Finance_Management.forms.Hostel_Staff
{
    public partial class HostelStaff : Form
    {
        public HostelStaff()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private bool Validate_Entry()
        {
            Validation validation = new Validation();
            if (!validation.EmployeeID(WardenBox.Text))
            {
                MessageBox.Show("Invalid Warded ID", "Invalid Name Error");
                return false;
            }
            else if (!validation.EmployeeID(SupervisorBox.Text))
            {
                MessageBox.Show("Invalid Supervisor ID", "Invalid Warden ID Error");
                return false;
            }
            else if (!validation.ListBox(BlockList.Text))
            {
                MessageBox.Show("Select Block", "Invalid Block Error");
                return false;
            }
            return true;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Validate_Entry())
            {
                SQL_Operator sql_operator = new SQL_Operator();
                string sqlQuery = "insert into hostel_staff(warden_id, supervisor_id, block) values('" +WardenBox.Text + "', '" + SupervisorBox.Text + "', '" + BlockList.Text + "')";
                if (sql_operator.Insert(sqlQuery))
                {
                    MessageBox.Show("Inserted Entry", "Successful");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Block already exists. \nProceed to update entry?","Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlQuery = "update hostel_staff set warden_id='" + WardenBox.Text + "', supervisor_id='" + SupervisorBox.Text + "' where block='" + BlockList.Text + "'";
                        if (sql_operator.Update(sqlQuery))
                        {
                            MessageBox.Show("Updated Entry", "Successful");
                        }
                        else
                        {
                            MessageBox.Show("Employee ID does not exist", "Failed");
                        }
                    }
                    else
                    {
                        WardenBox.Text = "";
                        SupervisorBox.Text = "";
                        BlockList.ClearSelected();
                    }
                }
            }
        }
    }
}
