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

        }

        public class MyThreadClass
        {
            public static void Thread1()
            {
                Thread thread = Thread.CurrentThread;
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(thread.Name + " prints number " + i);
                    Thread.Sleep(1500);
                }
            }

            public static void Thread2() 
            {
                
            }
        }
    }
}
