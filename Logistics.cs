using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    class Logistics
    {
        private string a = System.DateTime.Now.ToLongDateString();

        public string deliveryStatus(Date d)
        {
            if (a.Equals(d))
                return "Done";
            return "Donen't";

        }


    }
}
