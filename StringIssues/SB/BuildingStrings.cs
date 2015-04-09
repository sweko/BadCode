using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIssues
{
    public class BuildingStrings
    {
        public int Count { get; set; }

        public string GenerateStringsConcatenation()
        {
            var persons = Person.GeneratePersons(Count).ToList();

            Stopwatch stopwatch = Stopwatch.StartNew();
            string result = string.Empty;
            foreach (var person in persons)
            {
                result += string.Format("{0} {1}" + Environment.NewLine, person.FirstName, person.LastName);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            return result;
        }

        public string GenerateStringsBuilder()
        {
            var persons = Person.GeneratePersons(Count).ToList();

            Stopwatch stopwatch = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            foreach (var person in persons)
            {
                sb.AppendFormat("{0} {1}" + Environment.NewLine, person.FirstName, person.LastName);
            }
            string result = sb.ToString();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            return result;
        }
    }
}
