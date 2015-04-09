using System;
using System.Collections.Generic;

namespace EnterpriseLevelSort
{
    public class ConsoleDoubleArrayWriter : IDoubleArrayWriter
    {
        void IDoubleArrayWriter.WriteDoublesArray(IEnumerable<double> doubles)
        {
            foreach (double @double in doubles)
            {
                Console.WriteLine(@double);
            }
        }

        DoubleArrayWriterType IDoubleArrayWriter.Type
        {
            get
            {
                return DoubleArrayWriterType.Console;
            }
        }
    }
}