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
            * The code that is to run in a new thread is defined in the delegate 
            (of type Action in this case) passed to the Task.Run() method.
             
            * Notice that following the call to Task.Run() the Action passed as 
            the argument immediately starts executing.
            */
            Task taskA = Task.Run(() => Console.WriteLine("Hello from taskA."));

            // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.",
                              Thread.CurrentThread.Name);
            taskA.Wait();

            Console.ReadKey();
        }
    }
}
/* 
CODE BLOCK EXPLANATION - 2
The example displays output like the following:
   Hello from thread 'Main'.
   Hello from taskA.
*/