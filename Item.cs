using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj
{
    public class Item
    {
        private string id;
        private string name;
        private decimal price;
        private int quantity;
        private decimal weight;
        private string description;
        private string brand;
        private string type;

        public decimal Price
        {
            get { return price; }
            set
            {
                try
                {
                    if (value > 0)
                        price = value;
                    else
                        throw new ArgumentException();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("u wot m8");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
    }
}
