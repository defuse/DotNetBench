using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetBench.IncludedBenchmarks
{
    class EmptyCalls : IBenchmark
    {
        public string TestName
        {
            get { return "Empty calls"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            double numOps = (double)info;
            for (double i = 0; i < numOps; i++)
            {
                MakeEmptyCalls();
            }
        }

        private void MakeEmptyCalls()
        {
            EmptyOne();
            EmptyOne();
            EmptyOne();
            EmptyOne();
            EmptyOne();
            EmptyOne();
        }

        private void EmptyOne()
        {
            EmptyTwo();
            EmptyTwo();
            EmptyTwo();
            EmptyTwo();
            EmptyTwo();
            EmptyTwo();
            EmptyTwo();
            EmptyTwo();
            EmptyTwo();
        }

        private void EmptyTwo()
        {
            EmptyThree();
            EmptyThree();
            EmptyThree();
            EmptyThree();
            EmptyThree();
            EmptyThree();
            EmptyThree();
            EmptyThree();
            EmptyThree();
            EmptyThree();
        }

        private void EmptyThree()
        {
            return;
        }

        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            const double NUM_OPS = 30000000; //20000000000;
            double split = NUM_OPS / numThreads;
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = (object)split;
            }
            return info;
        }
    }
}
