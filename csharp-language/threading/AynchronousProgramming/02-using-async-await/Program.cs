using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
//            Infinite while loop is executing, but the long running task we kick off 
//            is also running in the background and counting up to 50000.
            var demo = new AsyncAwaitDemo();
            demo.DoStuff();

            while (true)
            {
                Console.WriteLine("Doing Stuff on the Main Thread...................");
            }
            Console.ReadKey();
        }
    }
}
