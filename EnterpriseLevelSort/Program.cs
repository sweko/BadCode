
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseLevelSort
{
    class Program
    {
        static void Main(string[] args)
        {
            IDoubleArrayReader reader = DoubleArrayInputOutputFactory.CreateDoubleArrayReader(DoubleArrayReaderType.MockService);
            IDoubleArrayProcessor processor = DoubleArrayProcessorFactory.CreateDoubleArrayProcessor(DoubleArrayProcessorType.Sorter);
            IDoubleArrayWriter writer = DoubleArrayInputOutputFactory.CreateDoubleArrayWriter(DoubleArrayWriterType.Console);

            var doubles = reader.GetDoubles();
            doubles = processor.ProcessDoubles(doubles);
            writer.WriteDoublesArray(doubles);
        }
    }
}
