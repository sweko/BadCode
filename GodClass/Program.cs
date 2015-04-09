using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = Utility.GenerateNewOrder();

            var discount = Utility.GetDiscountForOrder(order);

            Utility.LogError("error occured");

            var error = Utility.GetLastError();

            Utility.DefaultProductName = "My Product";

            Utility.ProcessOrder(order, discount, "1234567890");

            Utility.CalculateSquareSize(4);

        }
    }
}
