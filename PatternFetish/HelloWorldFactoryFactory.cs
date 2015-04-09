using System;
using System.Collections.Generic;

namespace PatternFetish
{
    internal class HelloWorldFactoryFactory
    {
        public Dictionary<HelloWorldFactoryType, Func<IHelloWorldFactory>> factoryFactories;

        private HelloWorldFactoryFactory ()
        {
            factoryFactories = new Dictionary<HelloWorldFactoryType, Func<IHelloWorldFactory>>
            {
                { HelloWorldFactoryType.Simple, () => new SimpleHelloWorldFactory()},

            };
        }

        public IHelloWorldFactory CreateFactory(HelloWorldFactoryType factoryType)
        {
            if (factoryFactories.ContainsKey(factoryType))
            {
                return factoryFactories[factoryType]();
            }
            return null;
        }

        private static HelloWorldFactoryFactory _instance;
        public static HelloWorldFactoryFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HelloWorldFactoryFactory();
                return _instance;
            }
        }
    }
}