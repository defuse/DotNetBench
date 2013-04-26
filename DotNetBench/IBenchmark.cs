using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNetBench
{
    //public delegate void BenchmarkCompleteEvent(object sender, BenchmarkCompleteEventArgs e);

    public interface IBenchmark
    {
       // event BenchmarkCompleteEvent Complete;

        string TestName
        {
            get;
        }

        void StartBenchmark(object info, int threadNum);

        object[] GetThreadInfo(int numThreads);
    }

    //public class BenchmarkCompleteEventArgs
    //{
    //    public bool Errors;
    //    public string ExtraInfo = "";
    //    public string BenchmarkName = "";
    //}
}
