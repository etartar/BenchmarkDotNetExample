using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetExample.Scenario1
{
    public class Calculate
    {
        private const int _limit = 1000000;

        [Benchmark]
        public int Sum()
        {
            int total = 0;

            for (int i = 0; i < _limit; i++)
                total += i;

            return total;
        }
    }
}
