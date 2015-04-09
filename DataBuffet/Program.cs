using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBuffet
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = PersonRepository.LoadPerson();
            Console.WriteLine(p.FirstName);
        }
    }
}
