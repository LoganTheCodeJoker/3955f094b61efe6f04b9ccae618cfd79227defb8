using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{

    class Customer
    {
        public static decimal CREDIT_LIMIT = 50;
        private string custID;
        private string name;
        private bool type;
        private decimal credit= 0;
        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }

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
                    {
                        credit += value;
                        if (credit >= CREDIT_LIMIT)
                        {
                            credit = CREDIT_LIMIT;
                            throw new Exception();
                        }
                    }
                    else
                        throw new ArgumentException();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("u wot m8");
                }
                catch (Exception)
                {
                    Console.WriteLine("eww poor");
                }

            }
        }

        public void payDebt(decimal moolah)
        {
            Credit -= moolah;
            Console.WriteLine("u gib money. i luv you.");
        }


    }
}
