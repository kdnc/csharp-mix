using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        public const int Repetitions = 1000;
        public static void Main()
        {
            /* 
            CODE BLOCK EXPLANATION - 1
            * This avoids the significant cost of starting and tearing down threads. 
            * In addition, thread pooling avoids the creation of too many threads, such 
            * that the system spends more time switching threads than running them.
            */
            ThreadPool.QueueUserWorkItem(DoWork, '.');

            for (int count = 0; count < Repetitions; count++)
            {
                Console.Write('-');
            }

            // Pause until the thread completes
            // This is for illustrative purposes; do not
            // use Thread.Sleep for synchronization in 
            // production code.
            Thread.Sleep(1000);
        }
        public static void DoWork(object state)
        {
            for (int count = 0; count < Repetitions; count++)
            {
                Console.Write(state);
            }
        }
    }
}
