using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetBench.IncludedBenchmarks
{
    class SquareRoot : IBenchmark 
    {
        public string TestName
        {
            get { return "Square root"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            double spread = (double)info;
            double start = threadNum * spread;
            double end = start + spread;
            double root;
            for (double i = start; i <= end; i++)
            {
                root = Math.Sqrt(i);
            }
        }

        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            double MAX_ROOT = 11128654848;
            double spread = MAX_ROOT / (UInt64)numThreads;
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = spread;
            }
            return info;
        }
    }
}
