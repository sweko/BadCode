using System.Collections.Generic;

namespace EnterpriseLevelSort
{
    public interface IDoubleArrayWriter
    {
        void WriteDoublesArray(IEnumerable<double> doubles);

        DoubleArrayWriterType Type { get; }
    }
}