using System;
using System.Collections.Generic;
using System.Reflection;

namespace EnterpriseLevelSort
{
    public static class DoubleArrayProcessorFactory
    {
        private static Dictionary<DoubleArrayProcessorType, IDoubleArrayProcessor> processors;

        static DoubleArrayProcessorFactory()
        {
            processors = new Dictionary<DoubleArrayProcessorType, IDoubleArrayProcessor>();
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                try
                {
                    var instance = Activator.CreateInstance(type);
                    if (instance is IDoubleArrayProcessor)
                    {
                        processors.Add((instance as IDoubleArrayProcessor).Type, (instance as IDoubleArrayProcessor));
                    }
                }
                catch
                {
                    continue;
                }
            }
        }

        public static IDoubleArrayProcessor CreateDoubleArrayProcessor(DoubleArrayProcessorType type)
        {
            return processors[type];
        }

    }
}