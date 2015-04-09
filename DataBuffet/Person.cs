using System.Collections.Generic;
using System.Net.Sockets;

namespace DataBuffet
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public List<Person> Children { get; set; }
    }
}