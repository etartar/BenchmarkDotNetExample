using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchmarkDotNetExample.Scenario2
{
    [MemoryDiagnoser]
    public class ArrayVsList
    {
        [Params(20, 80, 30, 800)]
        public int capacity;

        [Benchmark]
        public int[] SetArrayCapacity()
        {
            int[] playerArray = new int[capacity];

            for (int i = 0; i < capacity; i++)
                playerArray[i] = i;

            return playerArray;
        }

        [Benchmark]
        public List<int> SetListCapacity()
        {
            List<int> playerList = new List<int>();

            for (int i = 0; i < capacity; i++)
                playerList.Add(i);

            return playerList;
        }
    }
}
