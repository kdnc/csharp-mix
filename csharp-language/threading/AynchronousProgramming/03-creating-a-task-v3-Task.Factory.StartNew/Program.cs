using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        public static void Main()
        {
            Thread.CurrentThread.Name = "Main";

            /* 
            CODE BLOCK EXPLANATION - 1
            * Create and start the task in one operation. 
             
            * Use Task.Factory.StartNew<string>() for TPL prior to .NET 4.5
            */
            Task taskA = Task.Factory.StartNew(() => Console.WriteLine("Hello from taskA."));

            // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.",
                              Thread.CurrentThread.Name);
            taskA.Wait();

            Console.ReadKey();
        }
    }
}
// The example displays output like the following:
//       Hello from thread 'Main'.
//       Hello from taskA.