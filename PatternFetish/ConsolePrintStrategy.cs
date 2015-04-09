using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFetish
{
    public class ConsolePrintStrategy : IPrintStrategy
    {
        private readonly Action<string> method;
        private bool isEnabled;

        public ConsolePrintStrategy(Action<string> printMethod)
        {
            this.method = printMethod;
            this.isEnabled = true;
        }

        public void Print(string message)
        {
            if (isEnabled)
                method(message);
        }

        public void EnablePrinting(bool enable)
        {
            isEnabled = enable;
        }
    }
}
