using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApocalypseReady
{
    internal static class OrderManager
    {
        public static void AddOrder(List<Order> orders, Product product)
        {
            if ((orders != null) && (product != null))
            {
                Order order = OrderManager.CreateOrder(product);
                if (order != null)
                {
                    orders.Add(order);
                }
            }
        }

        private static Order CreateOrder(Product product)
        {

            if (product != null)
            {
                DateTime orderDate = DateTime.Now;
                if (orderDate < DateTime.MaxValue)
                {
                    Order order = new Order {Product = product, OrderDate = orderDate};
                    if (order != null)
                    {
                        return order;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

        }
    }
}
}
