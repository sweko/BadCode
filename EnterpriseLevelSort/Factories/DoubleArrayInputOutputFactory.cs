using System;
using System.Collections.Generic;
using System.Reflection;

namespace EnterpriseLevelSort
{
    public static class DoubleArrayInputOutputFactory
    {
        private static Dictionary<DoubleArrayReaderType, IDoubleArrayReader> readers;
        private static Dictionary<DoubleArrayWriterType, IDoubleArrayWriter> writers;

        static DoubleArrayInputOutputFactory()
        {
            readers = new Dictionary<DoubleArrayReaderType, IDoubleArrayReader>();
            writers = new Dictionary<DoubleArrayWriterType, IDoubleArrayWriter>();
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                try
                {
                    var instance = Activator.CreateInstance(type);
                    if (instance is IDoubleArrayReader)
                    {
                        readers.Add((instance as IDoubleArrayReader).Type, (instance as IDoubleArrayReader));
                    }
                }
                catch
                {
                    continue;
                }
            }

            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                try
                {
                    var instance = Activator.CreateInstance(type);
                    if (instance is IDoubleArrayWriter)
                    {
                        writers.Add((instance as IDoubleArrayWriter).Type, (instance as IDoubleArrayWriter));
                    }
                }
                catch
                {
                    continue;
                }
            }

        }

        public static IDoubleArrayReader CreateDoubleArrayReader(DoubleArrayReaderType type)
        {
            return readers[type];
        }

        public static IDoubleArrayWriter CreateDoubleArrayWriter(DoubleArrayWriterType type)
        {
            return writers[type];
        }

    }
}