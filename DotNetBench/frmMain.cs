using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DotNetBench
{
    public partial class frmMain : Form
    {
        private Benchmark tester;
        public frmMain()
        {
            InitializeComponent();
            tester = new Benchmark();
            tester.OnThreadComplete += new ThreadCompleteEvent(tester_OnThreadComplete);
            tester.TestComplete += new BenchTestCompleteEvent(tester_TestComplete);
        }

        private void btnTestInfo_Click(object sender, EventArgs e)
        {
            frmInfo info = new frmInfo();
            info.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtThreadCount.Text = Environment.ProcessorCount.ToString();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int threadCount;
            try
            {
                threadCount = Convert.ToInt32(txtThreadCount.Text);
            }
            catch 
            { 
                threadCount = 0;
            }
            if (threadCount > 0)
            {
                string tag = (string)((Button)sender).Tag;
                IBenchmark test = null;
                switch (tag)
                {
                    case "prime":
                        test = new IncludedBenchmarks.PrimeNumbers();
                        break;
                    case "string":
                        test = new IncludedBenchmarks.Strings();
                        break;
                    case "sqrt":
                        test = new IncludedBenchmarks.SquareRoot();
                        break;
                    case "loop":
                        test = new IncludedBenchmarks.Loop();
                        break;
                    case "gui":
                        test = new IncludedBenchmarks.GUI();
                        break;
                    case "empty":
                        test = new IncludedBenchmarks.EmptyCalls();
                        break;
                    case "list":
                        test = new IncludedBenchmarks.ListTest();
                        break;
                    case "burn":
                        test = new IncludedBenchmarks.Infinate();
                        break;
                    case "ram":
                        test = new IncludedBenchmarks.RAM();
                        break;
                    case "math":
                        test = new IncludedBenchmarks.MathTest();
                        break;
                    case "rc4":
                        test = new IncludedBenchmarks.RC4();
                        break;
                    case "aes":
                        test = new IncludedBenchmarks.AES();
                        break;
                }
                if (test != null)
                {
                    txtResults.Text += "Running " + test.TestName + " test on " + threadCount + " thread(s)" + "..." + Environment.NewLine;
                    progressBar1.Visible = true;
                    tester.RunBenchmark(test, threadCount);
                }
            }
            else
            {
                MessageBox.Show("Invalid Thread Count.");
            }
        }

        void tester_OnThreadComplete(object sender, ThreadCompleteEventArgs e)
        {
            if(chkShowThreadInfo.Checked)
                ChangeTextBoxText(txtResults, txtResults.Text + "Thread " + e.ThreadNumber + "/" + e.ThreadCount  + " complete after: " + e.FormattedTime  + Environment.NewLine);
        }

        void tester_TestComplete(object sender, BenchTestCompleteEventArgs e)
        {
            ChangeTextBoxText(txtResults, txtResults.Text + e.ConsoleMessage + Environment.NewLine);
            HideProg();
        }



        private delegate void UpdateTextCallback(TextBox txt, string text);
        public void ChangeTextBoxText(TextBox txt, string text)
        {
            if (txt.InvokeRequired)
            {
                txt.BeginInvoke(new UpdateTextCallback(ChangeTextBoxText), new object[] { txt, text });
            }
            else
            {
                txt.Text = text;
            }
        }

        private delegate void UpdateProgCallback();
        private void HideProg()
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.BeginInvoke(new UpdateProgCallback(HideProg));
            }else
            {
                progressBar1.Visible = false;
            }
        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {
            txtResults.SelectionStart = txtResults.Text.Length ;
            txtResults.ScrollToCaret();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (tester != null)
            {
                tester.EndThreads();
            }
            Application.Exit();
        }

        private void btnStopTests_Click(object sender, EventArgs e)
        {
            if (tester != null)
            {
                tester.StopTest();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResults.Text = "";
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tester != null)
            {
                tester.EndThreads();
            }
        }



    }
}
