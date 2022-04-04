using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Class_Library
{
    public class DOB
    {
        int date;
        int month;
        int year;
        int year_min;
        int year_max;

        #region GET Properties
        public int Date
        {
            get { return date; }
        }
        public int Month
        {
            get { return month; }
        }
        public int Year
        {
            get { return year; }
        }
        #endregion

        public DOB(int year_min, int year_max)
        {
            this.year_min = year_min;
            this.year_max = year_max;
        }
        public DOB(int date, int month, int year)
        {
            List<int> month_30 = new List<int>() { 2, 4, 6, 9, 11 };
            if (year < year_min || year >= year_max)
            {
                throw new Exception("Invalid Date of Birth");
            }
            if (month > 12 || month < 1)
            {
                throw new Exception("Invalid Date of Birth");
            }
            if (date > 31 || date < 1)
            {
                throw new Exception("Invalid Date of Birth");
            }
            if (month_30.Contains(month) && date == 31)
            {
                throw new Exception("Invalid Date of Birth");
            }
            if (!DateTime.IsLeapYear(year) && (date == 29 || date == 30))
            {
                throw new Exception("Invalid Date of Birth");
            }
            this.date = date;
            this.month = month;
            this.year = year;
        }
    }
    public enum Gender
    {
        Male = 1,
        Female = 2
        Transgender = 3
    }
}

