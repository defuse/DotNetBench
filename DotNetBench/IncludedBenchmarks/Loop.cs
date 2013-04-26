using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetBench.IncludedBenchmarks
{
    class Loop : IBenchmark 
    {
        public string TestName
        {
            get { return "Loop"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            double numOps = (double)info;
            for (double i = 0; i < numOps; i++) ;
        }

        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            const double NUM_OPS = 20000000000;
            double split = NUM_OPS / numThreads;
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = (object)split;
            }
            return info;
        }
    }
}
