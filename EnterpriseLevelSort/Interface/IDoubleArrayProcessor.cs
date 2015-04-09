using System.Collections.Generic;

namespace EnterpriseLevelSort
{
    public interface IDoubleArrayProcessor
    {
        IEnumerable<double> ProcessDoubles(IEnumerable<double> input);

        DoubleArrayProcessorType Type { get; }
    }
}