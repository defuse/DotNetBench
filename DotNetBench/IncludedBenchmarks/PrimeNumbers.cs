using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

//WE NEED TO MAKE THE BENCHMARK CLASS HANDLE THE THREADING FOR USSSSSSSSSSSSS. CUZ THIS IS JUST BS LOL

namespace DotNetBench.IncludedBenchmarks
{
    class PrimeNumbers : IBenchmark 
    {
        public string TestName
        {
            get { return "Prime number"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            int spread = (int)info;
            int start = threadNum * spread;
            int end = start + spread;

            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    double x = (double)i / (double)j;
                    int y = (int)(i / j);
                    if (y == x)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
        }

        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            const int HIGHEST_PRIME = 10000000;
            int spread = HIGHEST_PRIME / numThreads;
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = spread;
            }
            return info;
        }
    }
}
