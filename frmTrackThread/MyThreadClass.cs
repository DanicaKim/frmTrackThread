using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmTrackThread
{
    internal class MyThreadClass
    {
        public static string LoopCount { get; private set; }

        public static void Thread1()
        {
            for (int i = 0; i < 2; i++) {

                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i );
                Thread.Sleep(500);
            }
        }
        public static void Thread2()
        {
            for (int i = 0;i < 6 ;i++) {

                Thread thread1 = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread1.Name + " = " + i );
                Thread.Sleep(500);
            
            }
        }
    }
}
