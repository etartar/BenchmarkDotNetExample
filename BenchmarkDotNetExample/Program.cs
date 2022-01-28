using BenchmarkDotNet.Running;
using BenchmarkDotNetExample.Scenario1;
using BenchmarkDotNetExample.Scenario2;

namespace BenchmarkDotNetExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<Calculate>();
            //BenchmarkRunner.Run<ListCapacityPerformance>();
            BenchmarkRunner.Run<ArrayVsList>();
        }
    }
}
