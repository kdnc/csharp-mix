using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        public static void Main()
        {
            Task<string> task =
                Task.Run<string>(
                    () => PiCalculator.Calculate(500));

            foreach(
                char busySymbol in Utility.BusySymbols())
            {
                /* 
                CODE BLOCK EXPLANATION - 1
                *  The IsCompleted property is set to true when a task completes whether it completed normally 
                or faulted. More detailed information on the status of a task can be determined by reading the 
                Status property, which returns a value of type TaskStatus.
                */
                if(task.IsCompleted)
                {
                    Console.Write('\b');
                    break;
                }
                Console.Write(busySymbol);
            }

            Console.WriteLine();

            /* 
            CODE BLOCK EXPLANATION - 2
            * Note that there is no call to Wait(). Instead, reading from the Result property 
            automatically causes the current thread to wait until the result is available, 
            if it isn’t already; in this case we know that it will already be complete when the result is fetched.
            */
            Console.WriteLine(task.Result);
            System.Diagnostics.Trace.Assert(
                task.IsCompleted);

            Console.ReadKey();
        }
    }
}
