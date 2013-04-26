using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DotNetBench //TODO: i think time is wrong, if a new hour comes, will it add 1 hour?
{
    delegate void BenchTestCompleteEvent(object sender, BenchTestCompleteEventArgs e);
    delegate void ThreadCompleteEvent(object sender, ThreadCompleteEventArgs e);

    class Benchmark
    {
        public event BenchTestCompleteEvent TestComplete;
        public event ThreadCompleteEvent OnThreadComplete;

        private DateTime _startTime;
        private IBenchmark _test;
        Thread[] t;
        int _threadsFinished = 0;

        public void RunBenchmark(IBenchmark test, int threadCount)
        {
            _test = test;
            object[] info = test.GetThreadInfo(threadCount);
            t = new Thread[info.Length];
            _threadsFinished = 0;
            _startTime = DateTime.Now;
            for (int i = 0; i < info.Length; i++)
            {
                t[i] = new Thread(new ParameterizedThreadStart(Start));
                object[] args = new object[2];
                args[0] = info[i];
                args[1] = i;
                t[i].Start(args);
            }
        }

        private void Start(object info)
        {
            object[] splitInfo = (object[])info;
            object realInfo = splitInfo[0];
            int threadNum = (int)splitInfo[1];

            _test.StartBenchmark(realInfo, threadNum);
            ThreadComplete(threadNum);
        }

        private void ThreadComplete(int threadNum)
        {
            _threadsFinished++;
            if (OnThreadComplete != null)
            {
                DateTime threadFinish = DateTime.Now;
                ThreadCompleteEventArgs e = new ThreadCompleteEventArgs();
                e.Time = TimeDifference(_startTime, threadFinish);
                e.FormattedTime = FormatTime(_startTime, threadFinish);
                e.ThreadNumber = threadNum + 1;
                e.ThreadCount = t.Length;
                e.TestName = _test.TestName;
                if(_threadsFinished != 1 )
                    Thread.Sleep(10);
                OnThreadComplete(this, e);
            }
            if (_threadsFinished >= t.Length)
            {
                DateTime finish = DateTime.Now;
                RaiseComplete(true, _startTime, finish, _test, t.Length);
                EndThreads();
            }
        }

        public void RaiseComplete(bool completedAll, DateTime start, DateTime finish, IBenchmark test, int threadCount)
        {
            string message = "";
            double time = TimeDifference(start,finish);
            string dispTime = FormatTime(start, finish);
            if (completedAll)
            {
                message += test.TestName + " test completed in: ";
            }
            else
            {
                message += test.TestName + " test was canceled after: ";
            }
            message += dispTime + " on " + threadCount + " thread(s).";
            
            BenchTestCompleteEventArgs e = new BenchTestCompleteEventArgs();
            e.ConsoleMessage = message;
            e.TotalTime = time;
            e.ThreadCount = threadCount;
            e.TestName = test.TestName;
            if (TestComplete != null)
                TestComplete(this, e);
        }

        public void StopTest()
        {
            DateTime finish = DateTime.Now;
            RaiseComplete(false, _startTime, finish, _test, t.Length);
            EndThreads();
        }

        public void EndThreads()
        {
            try
            {
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != null)
                    {
                        t[i].Abort();
                        t[i] = null;
                    }
                }
            }
            catch { }
        }

        private double TimeDifference(DateTime start, DateTime end)
        {
            TimeSpan duration = end - start;
            return duration.TotalMilliseconds; 
        }

        private string FormatTime(DateTime start, DateTime end)
        {

            TimeSpan duration = end - start;
            string formatted = "";
            if(duration.Hours > 0)
                formatted += PadZero(duration.Hours.ToString()) + ":";
            if(duration.Minutes > 0)
                formatted += PadZero(duration.Minutes.ToString()) + ":";
            formatted += PadZero(duration.Seconds.ToString()) + ":";
            formatted += PadZero((duration.Milliseconds / 10).ToString());
            return formatted;
        }

        private string PadZero(string num)
        {
            if (num.Length == 1)
            {
                num = "0" + num;
            }
            return num;
        }
    }

    class BenchTestCompleteEventArgs
    {
        public string ConsoleMessage = "";
        public double TotalTime;
        public int ThreadCount;
        public string TestName;
    }

    class ThreadCompleteEventArgs
    {
        public int ThreadNumber;
        public double Time;
        public string FormattedTime;
        public int ThreadCount; 
        public string TestName; 
    }
}
