using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{

    class Customer
    {
        private string custID;
        private string name;
        private bool type;
        private decimal credit;

        public string Type
        {
            get { return type ? "VIP" : "Peasant"; }

            set
            {
                type = value.ToLower().Equals("vip") ? true : false;
            }
        }

        public decimal Credit
        {
            get { return credit; }

            set
            {
                try
                {
                    if (value > 0)
                        credit = value;
                    else
                        throw new ArgumentException();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("u wot m8");
                }

            }
        }

        public void topUp(decimal moolah)
        {
            Credit += moolah;
            Console.WriteLine("top up bich");
        }


    }
}
