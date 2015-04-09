using System;
using System.Collections.Generic;

namespace EnterpriseLevelSort
{
    public class MockServiceDoubleArrayReader : IDoubleArrayReader
    {
        IEnumerable<double> IDoubleArrayReader.GetDoubles()
        {
            Random r = new Random();
            for (int i = 0; i <= 10; i++)
            {
                yield return r.NextDouble();
            }
        }

        DoubleArrayReaderType IDoubleArrayReader.Type
        {
            get
            {
                return DoubleArrayReaderType.MockService;
            }
        }
    }
}