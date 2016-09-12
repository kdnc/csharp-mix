using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Repetitions = 10000;
            var intcount = 0;
            var count = 0;

//            The code that is to run in a new thread is defined in the delegate ((in the 
//            form of a lambda expression) passed to the Task.Run() method.
            Task task = Task.Run(() =>
            {
                for (intcount = 0; count < Repetitions; count++)
                {
                    Console.Write('-');
                }
            });

            for (intcount = 0; count < Repetitions; count++)
            {
                Console.Write('+');
            }
//            The call to Wait() forces the main thread to 
//            wait until all the work assigned to the task has completed executing.
            task.Wait();

            Console.ReadKey();
        }
    }
}