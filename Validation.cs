using System;
using System.Text.RegularExpressions;

namespace Finance_Management
{
    class Validation
    {
        public bool USN(string usn)
        {
            if (usn.Length == 10)
            {
                Regex usnExp = new Regex("^1BM\\d{2}[A-Z]{2}\\d{3}$");
                Match usn_result = usnExp.Match(usn);
                if (usn_result.Success)
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
                    switch (month)
                    {
                        case 1:
                            max_days = 31;
                            break;
                        case 2:
                            if (Leap_Year_Check(today.Year))
                            {
                                max_days = 29;
                            }
                            else
                            {
                                max_days = 28;
                            }
                            break;
                        case 3:
                            max_days = 31;
                            break;
                        case 4:
                            max_days = 30;
                            break;
                        case 5:
                            max_days = 31;
                            break;
                        case 6:
                            max_days = 30;
                            break;
                        case 7:
                            max_days = 31;
                            break;
                        case 8:
                            max_days = 31;
                            break;
                        case 9:
                            max_days = 30;
                            break;
                        case 10:
                            max_days = 31;
                            break;
                        case 11:
                            max_days = 30;
                            break;
                        case 12:
                            max_days = 31;
                            break;
                    }
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
            Match name_result = nameExp.Match(name);
            if (name_result.Success)
            {
                return true;
            }
            return false;
        }
    }
}
