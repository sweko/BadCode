using System;

namespace GodClass
{
    internal class Utility
    {
        internal static int MaxOrderNumber { get; set; }
        internal static object LastError { get; set; }

        internal static int CalculateSquareSize(int size)
        {
            return size*size;
        }

        internal static object GenerateNewOrder()
        {
            MaxOrderNumber++;
            return new {OrderId = MaxOrderNumber};
        }

        internal static void LogError(string p)
        {
            //log
        }

        internal static object GetLastError()
        {
            //get-last-error
            return LastError;
        }

        public static string DefaultProductName { get; set; }

        internal static double GetDiscountForOrder(object order)
        {
            return 0.10;
        }

        internal static void ProcessOrder(object order, double discount, string creditCardNumber)
        {
            //process order
        }
    }
}