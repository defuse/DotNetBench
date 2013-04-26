using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetBench.IncludedBenchmarks
{
    class ListTest : IBenchmark 
    {
        public string TestName
        {
            get { return "List"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            double numOps = (double)info;
            List<string> test = new List<string>();

            for (double i = 0; i < numOps; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    test.Add("STRINGSasdfjkj#@(@*$(ADFJakfjadlsfa" + i);
                }
                
                test.RemoveAt(323);
                test.Reverse();
                string[] x = test.ToArray();
                test.Insert(324, "INSERTEIAUIOFSDF8907834782374238974892342342343432478AFDHDJAFAFASD");
                test.Contains("hjsda");
                test.Remove("STRINGSasdfjkj#@(@*$(ADFJakfjadlsfa47");
                test.Remove("nothere");
                test.Sort();
                test.Add("aerewrwerwerew");
                test.Add("z3425423sdfsdfsd");
                test.Sort();
                test.IndexOf("asdf");
                test.IndexOf("STRINGSasdfjkj#@(@*$(ADFJakfjadlsfa300");
            }
        }

        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            const double NUM_OPS = 348;
            double split = NUM_OPS / numThreads;
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = (object)split;
            }
            return info;
        }
    }
}
