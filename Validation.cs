using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Finance_Management
{
    class Validation
    {
        public bool USN(string usn)
        {
            if (usn.Length == 10)
            {
                Regex usnExp = new Regex("^1BM\\d{2}[A-Z]{2}\\d{3}$");
                if (usnExp.Match(usn).Success)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Leap_Year_Check(int year)
        {
            if ((year % 100 == 0 && year % 400 == 0) || year % 4 == 0)
            {
                return true;
            }
            return false;
        }

        public int Maximum_Days_Month(int month, int year)
        {
            switch (month)
            {
                case 1:
                    return 31;
                case 2:
                    if (Leap_Year_Check(year))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                case 3:
                    return 31;
                case 4:
                    return 30;
                case 5:
                    return 31;
                case 6:
                    return 30;
                case 7:
                    return 31;
                case 8:
                    return 31;
                case 9:
                    return 30;
                case 10:
                    return 31;
                case 11:
                    return 30;
                case 12:
                    return 31;
            }
            return 0;
        }

        public bool DOB(string dob)
        {
            DateTime today = DateTime.Today;
            if (dob.Length == 10)
            {
                int year, month, day;
                try
                {
                    year = int.Parse(dob.Substring(0, 4));
                    month = int.Parse(dob.Substring(5, 2));
                    day = int.Parse(dob.Substring(8, 2));
                }
                catch (System.FormatException)
                {
                    return false;
                }
                int max_days = 0;
                if (1920 < year && year < (today.Year - 16) && day > 0)
                {
                    max_days = Maximum_Days_Month(month, today.Year);
                    if (day < max_days)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool Name(string name)
        {
            Regex nameExp = new Regex("^[a-zA-Z \\.]+$");
            if (nameExp.Match(name).Success)
            {
                return true;
            }
            return false;
        }

        public bool EmployeeID(string id)
        {
            if (id.Length == 7)
            {
                Regex idExp = new Regex("^\\d{4}[CEHNST]{3}$");
                if (idExp.Match(id).Success)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ListBox(string listItem)
        {
            if (listItem == "")
            {
                return false;
            }
            return true;
        }

        public bool ScholarshipID(string id)
        {
            if (id.Length > 4 && id.Length < 10)
            {
                Regex idExp = new Regex("^[A-Z]+_[A-Z]+$");
                if (idExp.Match(id).Success)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Amount(string amount)
        {
            try
            {
                if (int.Parse(amount) > 0)
                {
                    return true;
                }
            }
            catch (FormatException)
            {

            }
            return false;
        }

        public string Get_Timestamp(ListBox year, ListBox month, ListBox day, ListBox hour, ListBox minute, ListBox AMPM)
        {
            if (year.Text == "")
            {
                return "";
            }
            else
            {
                string timestamp = year.Text;
                if (month.Text != "")
                {
                    timestamp += "-" + month.Text;
                    if (day.Text != "")
                    {
                        timestamp += "-" + day.Text;
                        if (hour.Text != "")
                        {
                            if (AMPM.Text == "PM")
                            {
                                timestamp += " " + (int.Parse(hour.Text) + 12).ToString();
                            }
                            else
                            {
                                timestamp += " " + hour.Text;
                            }
                            timestamp += ":" + minute.Text + ":0";
                        }
                    }
                }
                return timestamp;
            }
        }
    }
}