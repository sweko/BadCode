using System;
using System.Collections.Generic;
using System.Linq;

namespace EnterpriseLevelSort
{
    public class SorterDoubleArrayProcessor : IDoubleArrayProcessor
    {
        IEnumerable<double> IDoubleArrayProcessor.ProcessDoubles(IEnumerable<double> input)
        {
            var output = input.ToArray();
            Array.Sort(output);
            return output;
        }

        DoubleArrayProcessorType IDoubleArrayProcessor.Type
        {
            get
            {
                return DoubleArrayProcessorType.Sorter;
            }
        }
    }
}