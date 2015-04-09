using System.Collections.Generic;

namespace EnterpriseLevelSort
{
    public interface IDoubleArrayReader
    {
        IEnumerable<double> GetDoubles();

        DoubleArrayReaderType Type { get; }
    }
}