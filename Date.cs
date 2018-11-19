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

        public override string ToString()
        {
            return String.Format("{0}/{1}/{2}", day, month, year);
        }
    }
}
