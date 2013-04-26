using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetBench.IncludedBenchmarks
{
    class RAM : IBenchmark 
    {
                public string TestName
        {
            get { return "RAM"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            double numOps = (double)info;
            
            for (int j = 0; j < numOps; j++)
            {
                List<double> x = new List<double>();
                for (double i = 0; i < 20000000; i++)
                {
                    x.Add(i);
                }
               
                x.Clear();
                x = null;
            }
            
        }

        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            const double NUM_OPS = 64;
            double split = NUM_OPS / numThreads;
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = (object)split;
            }
            return info;
        }
    }
}
