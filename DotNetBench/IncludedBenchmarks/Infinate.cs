using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetBench.IncludedBenchmarks
{
    class Infinate : IBenchmark 
    {
        public string TestName
        {
            get { return "Infinate burn"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            while (true) ;
        }

        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            return info;
        }
    }
}
