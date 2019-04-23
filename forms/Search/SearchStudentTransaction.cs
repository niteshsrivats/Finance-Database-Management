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
        private SearchMenu searchMenu;
        private TimeListAdder timeListAdder = new TimeListAdder();
        private DateTime today = DateTime.Now;
        private Regex usnExp = new Regex("^[A-Z1-9]+$");
        private Regex typeExp = new Regex("^[A-Z:]+$");

        public SearchStudentTransaction(SearchMenu searchMenu)
        {
            InitializeComponent();
            this.searchMenu = searchMenu;
        }

        private void SearchStudentTransaction_Load(object sender, EventArgs e)
        {
            for (int year = 1946; year <= today.Year; year++)
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
                    sqlQuery += " AND amount > " + AmountBox.Text + "";
                }
                else
                {
                    sqlQuery += " WHERE amount > " + AmountBox.Text + "";
                    criteria = true;
                }
            }
            if (validation.Amount(AmountToBox.Text))
            {
                if (criteria)
                {
                    sqlQuery += " AND amount < " + AmountToBox.Text + "";
                }
                else
                {
                    sqlQuery += " WHERE amount < " + AmountToBox.Text + "";
                    criteria = true;
                }
            }

            if (startTimestamp != "")
            {
                if (criteria)
                {
                    sqlQuery += " AND time > timestamp '" + startTimestamp + "'";
                }
                else
                {
                    sqlQuery += " WHERE time > timestamp '" + startTimestamp + "'";
                    criteria = true;
                }
            }
            if (endTimestamp != "")
            {
                if (criteria)
                {
                    sqlQuery += " AND time < timestamp '" + endTimestamp + "'";
                }
                else
                {
                    sqlQuery += " WHERE time < timestamp '" + endTimestamp + "'";
                    criteria = true;
                }
            }
            return sqlQuery;
        }

        private void Clear_All_Entries()
        {
            NameBox.Clear();
            USNBox.Clear();
            TypeBox.Clear();
            AmountBox.Clear();
            AmountToBox.Clear();
            YearList.Items.Clear();
            YearToList.Items.Clear();
            MonthList.Items.Clear();
            MonthToList.Items.Clear();
            DayList.Items.Clear();
            DayToList.Items.Clear();
            HourList.Items.Clear();
            HourToList.Items.Clear();
            MinuteList.Items.Clear();
            MinuteToList.Items.Clear();
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

        private void YearList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthList.Visible = false;
            MonthList.Items.Clear();
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

        private void YearToList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthToList.Visible = false;
            MonthToList.Items.Clear();
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

        private void MonthList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayList.Visible = false;
            DayList.Items.Clear();
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

        private void MonthToList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DayToList.Visible = false;
            DayToList.Items.Clear();
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

        private void DayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourList.Visible = false;
            HourList.Items.Clear();
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

        private void DayToList_SelectedIndexChanged(object sender, EventArgs e)
        {
            HourToList.Visible = false;
            HourToList.Items.Clear();
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

        private void HourList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(YearList.Text) == today.Year && int.Parse(MonthList.Text) == today.Month && int.Parse(DayList.Text) == today.Day && int.Parse(HourList.Text) == today.Hour)
            {
                MinuteList.Visible = false;
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

        private void HourToList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(YearToList.Text) == today.Year && int.Parse(MonthToList.Text) == today.Month && int.Parse(DayToList.Text) == today.Day && int.Parse(HourToList.Text) == today.Hour)
            {
                MinuteToList.Visible = false;
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

        private void Back_Click(object sender, EventArgs e)
        {
            searchMenu.Show();
            Hide();
            Clear_All_Entries();
        }

        private void SearchStudentTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            searchMenu.Show();
            Hide();
            Clear_All_Entries();
        }
    }
}