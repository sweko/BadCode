using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBuffet
{
    class City
    {
        public string Name { get; set; }
        public Country Country { get; set; }

        public List<string> Streets { get; set; }
    }
}
