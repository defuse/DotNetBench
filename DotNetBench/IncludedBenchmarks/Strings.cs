using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetBench.IncludedBenchmarks
{
    class Strings : IBenchmark
    {
        public string TestName
        {
            get { return "Strings"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            int numOps = (int)info;
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                s.Append(@"JSDKFLSDJALASDJFLEJ(U#$@*@($&*@#()$@#$JSDFDSKfjsdlFJKKLJAFADSLKF#$QTQ#JTIJLADADLKFJDSAFJDALKFJDS");
            }
            for(int i = 0; i <= numOps; i++)
            {
                string x = s.ToString();
                string[] a = x.Split('@');
                x.PadLeft(s.Length + 500);
                x.PadRight(s.Length + 500);
                x.Remove(239, 2334);
                x.Substring(x.IndexOf("JSDKFLSDJALASD"),x.IndexOf("ALKF"));
                x.Contains("THISDOESNTEXISTINTHESTRING"); // force that bitch to look in teh string everWHERE WHHAHHAHAHA
                x.ToUpper();
                x.ToLower();
                x.CompareTo(x);
            }
        }

        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            const int NUM_OPS = 17000;
            int split = NUM_OPS / numThreads;
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = (object)split;
            }
            return info;
        }
    }
}
