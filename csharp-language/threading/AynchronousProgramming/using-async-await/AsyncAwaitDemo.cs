using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
//            Launches a long running operation called LongRunningOperation()
            await Task.Run(() =>
            {
                LongRunningOperation();
            });
        }

        private static async Task<string> LongRunningOperation()
        {
            int counter;

            for (counter = 0; counter < 50000; counter++)
            {
                Console.WriteLine(counter);
            }

            return "Counter = " + counter;
        }
    }
}
