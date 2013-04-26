using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DotNetBench.IncludedBenchmarks
{
    class GUI : IBenchmark 
    {
        public string TestName
        {
            get { return "GUI"; }
        }

        public void StartBenchmark(object info, int threadNum)
        {
            double numOps = (double)info;
            Form frm = new Form();
            frm.Width = 600;
            frm.Height = 600;
            frm.Show();

            for(int i = 0; i < numOps; i++)
            {
                frm.Text += i;

                int x = 0;
                int y = 0;

                MainMenu newMenu = new MainMenu();
                
               
                frm.Menu = newMenu;
                frm.Update();

                for (int j = 0; j < 30; j++)
                {
                    newMenu.MenuItems.Add("TESTMENU" + j);
                    frm.Update();
                }

                for (int j = 0; j < 10; j++)
                {
                    Button newBox = new Button();
                    newBox.Text = "Button" + j;
                    newBox.Left = x;
                    newBox.Top = y;
                    x += newBox.Width;
                    if (frm.Width < x)
                    {
                        y += newBox.Height;
                        x = 0;
                    }
                    frm.Controls.Add(newBox);
                    frm.Update();
                }
                x = 0;
                ListBox newList = new ListBox();
                newList.Top = y;
                x += newList.Width;

                frm.Controls.Add(newList);
                frm.Update();
                for (int j = 0; j < 1000; j++ )
                {
                    newList.Items.Add("TESTITEM");
                    newList.Update();
                }

                TextBox testBox = new TextBox();
                testBox.Multiline = true;
                testBox.Height = 500;
                testBox.Width = 500;
                testBox.Top = y;
                testBox.Left = x;
                frm.Controls.Add(testBox);
                frm.Update();
                for (int j = 0; j < 100; j++)
                {
                    testBox.Text += "SOMETEXT" + j;
                    testBox.Update();
                }



                frm.Controls.Clear();
                frm.Update();
             }
            frm.Close();
            frm = null;
        }



        public object[] GetThreadInfo(int numThreads)
        {
            object[] info = new object[numThreads];
            const double NUM_OPS = 60;
            double split = NUM_OPS / numThreads;
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = (object)split;
            }
            return info;
        }
    }
}
