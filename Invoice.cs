using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace proj
{
    class Invoice
    {
        private static int id = 0;
        private Customer customer;
        private List<checkOut> items;
        private Date date;
        private Employee employee;
        private decimal total;
        private bool delivery;
        private int payement;

        public string Payement
        {
            get { switch (payement) { 
                    case 0: return "Credit Card";
                    case 1: return "Debit Card";
                    case 2: return "Cash";
                    case 3: return "Bank transfer";
                    case 4: return "Cheque";
                    default: return "Credit Account";
                    }
                }
            set
            {
                payement = Int32.Parse(value);
            }
        }
        

        public Invoice(Customer cust, List<checkOut> chckOut, Employee emp, bool d)
        {
            id += 1;
            customer = cust;
            items = chckOut;
            employee = emp;
            date = new Date();
            delivery = d;

        }  

        public Invoice()
        {

        }

        public String Delivery
        {
            get { return delivery ? "onthespot" : "shipping"; }
            set
            {
                delivery = value.Equals("shipping")?true:false;
            }
        }

        public string getItem()
        {
            if (delivery == false)
                return Delivery + "/";
            else
            {
                Date d = new Date();
                return String.Format("{}/{}/{}/", Delivery, customer.Address, d.shipDate());

            }
        }

        public void calcTotal()
        {
            foreach(checkOut i in items)
            {
                total += i.total();
            }
        }

        public void saveToFile(string s)
        {
           var path = @"C:\Users\ASUS\Documents\Visual Studio 2015\Projects\proj\proj\Invoice.txt";
            File.WriteAllText(path, s);

        }

        public void poorVIP()
        {
            Console.WriteLine("u poor bitch");

        }

        public bool pay()
        {
            if (payement.Equals("Credit"))
            {
                if (customer.Credit == Customer.CREDIT_LIMIT)
                {
                    return false;
                }
            }
            return true;
        }

        public string itemList()
        {
            string s = "";
            foreach (checkOut c in items)
                s = s + c.item.Name + " " + c.quantity + "/";
            return s + "\n";
        }

        public override string ToString()
        {
            return String.Format("{}/{}/{}/{}/{}/{}/{}/{}", id, customer, employee, date, itemList(), total, Payement, getItem());
        }
    }

    public struct checkOut
    {
        public Item item;
        public int quantity;

        public checkOut(Item i, int q)
        {
            item = i;
            quantity = q;
        }

        public decimal total()
        {
            item.Quantity -= quantity;
            return item.Price + quantity;
        }
    }
}
