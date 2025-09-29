using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace frmTrackThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            MyThreadClass.frmTrackThread(threadlbl);
        }

        public class MyThreadClass
        {
            public static void Thread1()
            {
                Thread thread = Thread.CurrentThread;
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Name of thread: " + thread.Name + " = " + i);
                    Thread.Sleep(500);
                }
            }

            public static void Thread2() 
            {
                Thread thread = Thread.CurrentThread;
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Name of thread: " + thread.Name + " = " + i);
                    Thread.Sleep(1500);
                }

                
            }

            public static void frmTrackThread(Label lblthread) 
            {
                Thread ThreadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
                Thread ThreadB = new Thread(new ThreadStart(MyThreadClass.Thread2));
                Thread ThreadC = new Thread(new ThreadStart(MyThreadClass.Thread1));
                Thread ThreadD = new Thread(new ThreadStart(MyThreadClass.Thread2));

                ThreadA.Name = "Thread A";
                ThreadB.Name = "Thread B";
                ThreadC.Name = "Thread C";
                ThreadD.Name = "Thread D";

                ThreadA.Priority = ThreadPriority.Highest;
                ThreadB.Priority = ThreadPriority.Normal;
                ThreadC.Priority = ThreadPriority.AboveNormal;
                ThreadD.Priority = ThreadPriority.BelowNormal;

                ThreadA.Start();
                ThreadB.Start();
                ThreadC.Start();
                ThreadD.Start();

                ThreadA.Join();
                ThreadB.Join();
                ThreadC.Join();
                ThreadD.Join();

                Console.WriteLine("- End of Thread -");
                lblthread.Text = "- End of Thread -";
            }

           
        }
    }
}
