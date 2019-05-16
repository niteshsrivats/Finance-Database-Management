using Finance_Management.forms.Navigation;
using Finance_Management.forms.Search;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Finance_Management.forms
{
    public partial class SearchStudentTransaction : Form
    {

        private SQL_Operator sql_operator = new SQL_Operator();
        private Validation validation = new Validation();
        private StudentTransactionSearchMenu studentTransactionSearchMenu;
        private TimeListAdder timeListAdder = new TimeListAdder();
        private DateTime today = DateTime.Now;
        private Regex usnExp = new Regex("^[A-Z1-9]+$");
        private Regex typeExp = new Regex("^[A-Z:]+$");

        public SearchStudentTransaction(StudentTransactionSearchMenu studentTransactionSearchMenu)
        {
            InitializeComponent();
            this.studentTransactionSearchMenu = studentTransactionSearchMenu;
        }

        private void SearchStudentTransaction_Load(object sender, EventArgs e)
        {
            for (int year = today.Year; year >= 2015; year--)
            {
                YearList.Items.Add(year);
                YearToList.Items.Add(year);
            }
        }

        private string Get_Search_Query()
        {
            string sqlQuery = "SELECT name Name, st.usn USN, st.type Type, amount Amount, TO_CHAR(time, 'YYYY-MM-DD HH24:MI') Time FROM STUDENT_TRANSACTION st LEFT JOIN STUDENT_INFO si ON st.usn = si.usn";
            string startTimestamp = validation.Get_Timestamp(YearList, MonthList, DayList, HourList, MinuteList, AMPMList);
            string endTimestamp = validation.Get_Timestamp(YearToList, MonthToList, DayToList, HourToList, MinuteToList, AMPMToList);
            bool criteria = false;

            if (validation.Name(NameBox.Text.ToUpper()))
            {
                sqlQuery += " WHERE name LIKE '%" + NameBox.Text.ToUpper() + "%'";
                criteria = true;
            }

            if (usnExp.Match(USNBox.Text.ToUpper()).Success)
            {
                if (criteria)
                {
                    sqlQuery += " AND st.usn LIKE '%" + USNBox.Text.ToUpper() + "%'";
                }
                else
                {
                    sqlQuery += " WHERE st.usn LIKE '%" + USNBox.Text.ToUpper() + "%'";
                    criteria = true;
                }
            }

            if (typeExp.Match(TypeBox.Text.ToUpper()).Success)
            {
                if (criteria)
                {
                    sqlQuery += " AND st.type LIKE '%" + TypeBox.Text.ToUpper() + "%'";
                }
                else
                {
                    sqlQuery += " WHERE st.type LIKE '%" + TypeBox.Text.ToUpper() + "%'";
                    criteria = true;
                }
            }

            if (validation.Amount(AmountBox.Text) && validation.Amount(AmountToBox.Text))
            {
                if (int.Parse(AmountBox.Text) > int.Parse(AmountToBox.Text))
                {
                    string temp = AmountBox.Text;
                    AmountBox.Text = AmountToBox.Text;
                    AmountToBox.Text = temp;
                }
            }
            if (validation.Amount(AmountBox.Text))
            {
                if (criteria)
                {
                    sqlQuery += " AND ABS(amount) > " + AmountBox.Text + "";
                }
                else
                {
                    sqlQuery += " WHERE ABS(amount) > " + AmountBox.Text + "";
                    criteria = true;
                }
            }
            if (validation.Amount(AmountToBox.Text))
            {
                if (criteria)
                {
                    sqlQuery += " AND ABS(amount) < " + AmountToBox.Text + "";
                }
                else
                {
                    sqlQuery += " WHERE ABS(amount) < " + AmountToBox.Text + "";
                    criteria = true;
                }
            }

            if (startTimestamp != "")
            {
                if (criteria)
                {
                    sqlQuery += " AND TO_CHAR(time, 'YYYY-MM-DD HH24:MI') > '" + startTimestamp + "'";
                }
                else
                {
                    sqlQuery += " WHERE TO_CHAR(time, 'YYYY-MM-DD HH24:MI') > '" + startTimestamp + "'";
                    criteria = true;
                }
            }
            if (endTimestamp != "")
            {
                if (criteria)
                {
                    sqlQuery += " AND TO_CHAR(time, 'YYYY-MM-DD HH24:MI') < '" + endTimestamp + "'";
                }
                else
                {
                    sqlQuery += " WHERE TO_CHAR(time, 'YYYY-MM-DD HH24:MI') < '" + endTimestamp + "'";
                    criteria = true;
                }
            }
            sqlQuery += " ORDER BY time DESC";
            return sqlQuery;
        }

        private void Clear_All_Entries()
        {
            NameBox.Clear();
            USNBox.Clear();
            TypeBox.Clear();
            AmountBox.Clear();
            AmountToBox.Clear();
            YearList.SelectedItems.Clear();
            YearToList.SelectedItems.Clear();
            MonthList.Visible = false;
            MonthToList.Visible = false;
            DayList.Visible = false;
            DayToList.Visible = false;
            HourList.Visible = false;
            HourToList.Visible = false;
            MinuteList.Visible = false;
            MinuteToList.Visible = false;
            AMPMList.Visible = false;
            AMPMToList.Visible = false;
            DataView.DataSource = null;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string sqlQuery = Get_Search_Query();
            sql_operator.Display(sqlQuery, DataView);
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            NameBox.Select();
        }

        private void LabelUSN_Click(object sender, EventArgs e)
        {
            USNBox.Select();
        }

        private void LabelType_Click(object sender, EventArgs e)
        {
            TypeBox.Select();
        }

        private void LabelAmount_Click(object sender, EventArgs e)
        {
            AmountBox.Select();
        }

        private void LabelAmountTo_Click(object sender, EventArgs e)
        {
            AmountToBox.Select();
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string sqlQuery = Get_Search_Query();
                sql_operator.Display(sqlQuery, DataView);
            }
        }

        private void USNBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string sqlQuery = Get_Search_Query();
                sql_operator.Display(sqlQuery, DataView);
            }
        }

        private void TypeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string sqlQuery = Get_Search_Query();
                sql_operator.Display(sqlQuery, DataView);
            }
        }

        private void AmountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string sqlQuery = Get_Search_Query();
                sql_operator.Display(sqlQuery, DataView);
            }
        }

        private void AmountToBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string sqlQuery = Get_Search_Query();
                sql_operator.Display(sqlQuery, DataView);
            }
        }

        private void YearList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthList.Visible = false;
            MonthList.ClearSelected();
            MonthList.Items.Clear();
            if (YearList.Text != "")
            {
                if (int.Parse(YearList.Text) == today.Year)
                {
                    timeListAdder.Fill_Month(MonthList, today.Month);
                }
                else
                {
                    timeListAdder.Fill_Month(MonthList, 12);
                }
                MonthList.Visible = true;
            }
        }

        private void YearToList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthToList.Visible = false;
            MonthToList.ClearSelected();
            MonthToList.Items.Clear();
            if (YearToList.Text != "")
            {
                if (int.Parse(YearToList.Text) == today.Year)
                {
                    timeListAdder.Fill_Month(MonthToList, today.Month);
                }
                else
                {
                    timeListAdder.Fill_Month(MonthToList, 12);
                }
                MonthToList.Visible = true;
            }
        }

        private void MonthList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayList.Visible = false;
            DayList.ClearSelected();
            DayList.Items.Clear();
            if (MonthList.Text != "")
            {
                if (int.Parse(YearList.Text) == today.Year && int.Parse(MonthList.Text) == 2)
                {
                    timeListAdder.Fill_Day(DayList, today.Day);
                }
                else
                {
                    timeListAdder.Fill_Day(DayList, validation.Maximum_Days_Month(int.Parse(MonthList.Text), int.Parse(YearList.Text)));
                }
                DayList.Visible = true;
            }
        }

        private void MonthToList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayToList.Visible = false;
            DayToList.ClearSelected();
            DayToList.Items.Clear();
            if (MonthToList.Text != "")
            {
                if (int.Parse(YearToList.Text) == today.Year && int.Parse(MonthToList.Text) == 2)
                {
                    timeListAdder.Fill_Day(DayToList, today.Day);
                }
                else
                {
                    timeListAdder.Fill_Day(DayToList, validation.Maximum_Days_Month(int.Parse(MonthToList.Text), int.Parse(YearToList.Text)));
                }
                DayToList.Visible = true;
            }
        }

        private void DayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourList.Visible = false;
            HourList.ClearSelected();
            HourList.Items.Clear();
            if (DayList.Text != "")
            {
                if (int.Parse(YearList.Text) == today.Year && int.Parse(MonthList.Text) == today.Month && int.Parse(DayList.Text) == today.Day)
                {
                    timeListAdder.Fill_Hour(HourList, today.Hour % 12);
                }
                else
                {
                    timeListAdder.Fill_Hour(HourList, 11);
                }
                HourList.Visible = true;
            }
        }

        private void DayToList_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourToList.Visible = false;
            HourToList.ClearSelected();
            HourToList.Items.Clear();
            if (DayToList.Text != "")
            {
                if (int.Parse(YearToList.Text) == today.Year && int.Parse(MonthToList.Text) == today.Month && int.Parse(DayToList.Text) == today.Day)
                {
                    timeListAdder.Fill_Hour(HourToList, today.Hour % 12);
                }
                else
                {
                    timeListAdder.Fill_Hour(HourToList, 11);
                }
                HourToList.Visible = true;
            }
        }

        private void HourList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MinuteList.Visible = false;
            AMPMList.Visible = false;
            MinuteList.ClearSelected();
            AMPMList.ClearSelected();
            if (HourList.Text != "")
            {
                if (int.Parse(YearList.Text) == today.Year && int.Parse(MonthList.Text) == today.Month && int.Parse(DayList.Text) == today.Day && int.Parse(HourList.Text) == today.Hour)
                {
                    MinuteList.Items.Clear();
                    timeListAdder.Fil_Minute(MinuteList, today.Minute);
                    MinuteList.Text = "00";
                }
                else if (MinuteList.Text == "")
                {
                    timeListAdder.Fil_Minute(MinuteList, 59);
                    MinuteList.Text = "00";
                }
                if (AMPMList.Text == "")
                {
                    AMPMList.Text = "AM";
                }
                MinuteList.Visible = true;
                AMPMList.Visible = true;
            }
        }

        private void HourToList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MinuteToList.Visible = false;
            AMPMToList.Visible = false;
            MinuteToList.ClearSelected();
            AMPMToList.ClearSelected();
            if (HourToList.Text != "")
            {
                if (int.Parse(YearToList.Text) == today.Year && int.Parse(MonthToList.Text) == today.Month && int.Parse(DayToList.Text) == today.Day && int.Parse(HourToList.Text) == today.Hour)
                {
                    MinuteToList.Items.Clear();
                    timeListAdder.Fil_Minute(MinuteToList, today.Minute);
                    MinuteToList.Text = "00";
                }
                else if (MinuteToList.Text == "")
                {
                    timeListAdder.Fil_Minute(MinuteToList, 59);
                    MinuteToList.Text = "00";
                }

                if (AMPMToList.Text == "")
                {
                    AMPMToList.Text = "AM";
                }
                MinuteToList.Visible = true;
                AMPMToList.Visible = true;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            studentTransactionSearchMenu.Show();
            Hide();
            Clear_All_Entries();
        }

        private void SearchStudentTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            studentTransactionSearchMenu.Show();
            Hide();
            Clear_All_Entries();
        }
    }
}