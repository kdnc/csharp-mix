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
            thread.Join();
            Console.WriteLine("Thread Joined");
            Console.ReadKey();
        }
    }
}
