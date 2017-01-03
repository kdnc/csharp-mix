using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
//        https://stephenhaunts.com/2014/10/10/simple-async-await-example-for-asynchronous-programming/
//        http://stackoverflow.com/questions/9519414/whats-the-difference-between-task-start-wait-and-async-await
        static void Main(string[] args)
        {
//            ExecuteTaskWaitExample();

            ExecuteAsyncAwaitExample();
        }

        static void ExecuteTaskWaitExample()
        {

//            Task.Wait blocks the main thread until the particular task is completed. 
//            So that the infinite loop cannot be executed until the task counts up to 5000
            var demo = new AsyncAwaitDemo();
            demo.DoStuffAsTask();

            while (true)
            {
                Console.WriteLine("Doing Stuff on the Main Thread...................");
            }
            Console.ReadKey();
        }

        static void ExecuteAsyncAwaitExample()
        {
//            Infinite while loop is executing, but the long running task we kick off 
//            is also running in the background and counting up to 5000.
            var demo = new AsyncAwaitDemo();
            demo.DoStuffAsAsync();

            while (true)
            {
                Console.WriteLine("Doing Stuff on the Main Thread...................");
            }
            Console.ReadKey();
        }
    }
}
