using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchmarkDotNetExample.Scenario2
{
    [MemoryDiagnoser]
    public class ListCapacityPerformance
    {
        [Params(20, 80, 30, 800)]
        public int capacity;

        [Benchmark]
        public List<int> DynamicCapacity()
        {
            List<int> valueList = new List<int>();

            for (int i = 0; i < capacity; i++)
                valueList.Add(i);

            return valueList;
        }

        [Benchmark]
        public List<int> SetCapacity()
        {
            List<int> valueList = new List<int>(capacity);

            for (int i = 0; i < capacity; i++)
                valueList.Add(i);

            return valueList;

        }
    }
}
