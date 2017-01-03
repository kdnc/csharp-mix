using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_joining_threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = ThreadSleeper.DoSleep(5);
            Console.WriteLine("Waiting for thread to join");
            /* 
            CODE BLOCK EXPLANATION - 1
            * You can cause one thread to wait for another with Join().
            * This tells the operating system to suspend execution of the 
            * current thread until the other thread is terminated. 
            */
            thread.Join();
            Console.WriteLine("Thread Joined");
            Console.ReadKey();
        }
    }
}
