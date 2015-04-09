using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        private static bool broken = true;

        static void Main(string[] args)
        {
            CallDeepMethod();
        }

        private static void CallDeepMethod()
        {
            try
            {
                CallNextLevel();
            }
            catch (Exception ex)
            {
                Console.WriteLine("big bada boom");   
                throw;
            }
            
        }

        private static void CallNextLevel()
        {

            CallYetAnotherLayer();
        }

        private static void CallYetAnotherLayer()
        {
            if (broken)
            {
                throw new InvalidOperationException("boom");
            }
        }


    }
}
