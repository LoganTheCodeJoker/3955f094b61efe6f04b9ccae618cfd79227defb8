using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    class Date
    {
        private int year, month, day;
        
        public Date()
        {
            year = System.DateTime.Now.Year;
            month = System.DateTime.Now.Month;
            day = System.DateTime.Now.Day;
        }

        public int Day
        {
            get { return day; }
            set
            {
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                year = value;
            }
        }


        public Date shipDate()
        {
            Date d = new Date();
            d.Day = System.DateTime.Now.AddDays(7).Day;
            d.Month = System.DateTime.Now.AddDays(7).Month;
            d.Year = System.DateTime.Now.AddDays(7).Year;
            return d;
        }

        


        public override string ToString()
        {
            return String.Format("{0}/{1}/{2}", month, day, year);
        }
    }
}
