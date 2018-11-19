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

        public Invoice(Customer cust, List<checkOut> chckOut, Employee emp)
        {

            customer = cust;
            items = chckOut;
            employee = emp;
            date = new Date();

        }  

        public Invoice()
        {

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

        public string itemList()
        {
            string s = "";
            foreach (checkOut c in items)
                s = s + c.item.Name + " " + c.quantity + "/";
            return s;
        }

        public override string ToString()
        {
            return String.Format("{} {} {} {} {} {}", id, customer, employee, date, itemList(), total);
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
            return item.Price + quantity;
        }
    }
}
