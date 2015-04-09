using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFetish
{
    class Program
    {
        static void Main(string[] args)
        {

            IHelloWorldFactory factory = HelloWorldFactoryFactory.Instance.CreateFactory(HelloWorldFactoryType.Simple);
            var message = factory.CreateHelloWorldMessage();

            IPrintStrategy strategy = PrintStrategyFactory.Instance.GetDefaultStrategy();
            strategy.EnablePrinting(true);
            strategy.Print(message);
        }
    }
}
