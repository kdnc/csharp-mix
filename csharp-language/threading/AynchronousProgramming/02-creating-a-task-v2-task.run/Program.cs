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

            // Define and run the task.
            Task taskA = Task.Run(() => Console.WriteLine("Hello from taskA."));

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