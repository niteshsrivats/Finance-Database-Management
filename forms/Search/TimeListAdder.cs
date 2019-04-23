using System.Windows.Forms;

namespace Finance_Management.forms.Search
{
    class TimeListAdder
    {
        public void Fill_Month(ListBox MonthList, int maxMonth)
        {
            for (int month = 1; month <= maxMonth; month++)
            {
                if (month < 10)
                {
                    MonthList.Items.Add("0" + month.ToString());
                }
                else
                {
                    MonthList.Items.Add(month);
                }

            }
        }

        public void Fill_Day(ListBox DayList, int maxDay)
        {
            for (int day = 1; day <= maxDay; day++)
            {
                if (day < 10)
                {
                    DayList.Items.Add("0" + day.ToString());
                }
                else
                {
                    DayList.Items.Add(day);
                }
            }
        }

        public void Fill_Hour(ListBox HourList, int maxHour)
        {
            for (int hour = 0; hour <= maxHour; hour++)
            {
                if (hour < 10)
                {
                    HourList.Items.Add("0" + hour.ToString());
                }
                else
                {
                    HourList.Items.Add(hour);
                }
            }
        }

        public void Fil_Minute(ListBox MinuteList, int maxMinute)
        {
            for (int minute = 0; minute <= maxMinute; minute++)
            {
                if (minute < 10)
                {
                    MinuteList.Items.Add("0" + minute.ToString());
                }
                else
                {
                    MinuteList.Items.Add(minute);
                }
            }
        }
    }
}
