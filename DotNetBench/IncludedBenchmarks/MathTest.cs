using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetBench.IncludedBenchmarks
{
    class MathTest : IBenchmark 
    {
        public string TestName
        {
            get { return "Math"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            double numOps = (double)info;
            for (double i = 0; i < numOps; i++)
            {

                //double math
                double x = 23498;
                x = Math.Pow(x, 2);
                x = x * 30;
                x = x / 328;
                x = (long)x ^ 2348923083;
                x = x + 2398023846 / (3249823943 / x) ;
                x = Math.Sqrt(x);
                x = Math.Exp(x);
                x = Math.Cosh(x);
                x = Math.Floor(x);
                x += 0.5;
                x = Math.Ceiling(x);
                x = Math.Log(x);
                x = Math.Exp(x);

                //integer math
                long y = 2398423908;
                y += 23984329;
                y = y / 23984329;
                y = (long)Math.Pow(y, 3);
                y = y * 20;
                y = y / (y + 300 / 1000);
                y = y ^ 329048329048;
                y = y + y + y + y + y;

                x = Math.Pow(y, 2);
                x = x * 30;
                x = x / 328;
                x = (long)x ^ 2348923083;
                x = x + 2398023846 / (3249823943 / x);

            }
        }

        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            const double NUM_OPS = 20000000;
            double split = NUM_OPS / numThreads;
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = (object)split;
            }
            return info;
        }
    }
}
