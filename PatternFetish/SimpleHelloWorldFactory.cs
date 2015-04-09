using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFetish
{
    public class SimpleHelloWorldFactory : IHelloWorldFactory
    {
        public string CreateHelloWorldMessage()
        {
            return "Hello World";
        }
    }
}
