using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _01_broken_thread_example;

namespace _02_thread_example_with_locking
{
    class Program
    {
        static void Main(string[] args)
        {
            Val v = new Val();
            for (int threadNum = 0; threadNum < 5; threadNum++)
            {
                Thread thread = new Thread(new ThreadStart(v.DoBump));
                thread.Start();
            }
            Console.ReadKey();
        }
    }
}
