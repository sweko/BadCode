using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrgy
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product { ID = 1, Name = "Car" };
            Product p2 = new Product { ID = 2, Name = "Carpet" };

            Order o = new Order {ID = 1, Product = p1, CreditCardNumber ="1234" };
            o.Product = p2;
        }
    }
}
