using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApocalypseReady
{
    internal class Program
    {
        private static void Main(string[] args)
        {

        }


        public static bool IsUniverseConsistentCheck()
        {
            int one = 1;
            int two = one + one;

            if (one < two)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
