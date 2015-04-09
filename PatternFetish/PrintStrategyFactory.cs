using System;

namespace PatternFetish
{
    internal class PrintStrategyFactory
    {
        private static PrintStrategyFactory _instance;
        public static PrintStrategyFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PrintStrategyFactory();
                return _instance;
            }
        }

        internal IPrintStrategy GetDefaultStrategy()
        {
            return new ConsolePrintStrategy(Console.WriteLine);
        }
    }
}