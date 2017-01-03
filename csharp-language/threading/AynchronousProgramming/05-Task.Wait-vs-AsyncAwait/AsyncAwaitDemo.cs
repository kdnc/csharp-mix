using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class AsyncAwaitDemo
    {
        public async Task DoStuffAsAsync()
        {
//            Launches a long running operation called LongRunningOperation()
            await Task.Run(() =>
            {
                LongRunningOperation();
            });
        }

        public void DoStuffAsTask()
        {
//            Launches a long running operation called LongRunningOperation()
            Task t = Task.Run(() =>
            {
                LongRunningOperation();
            });
            t.Wait();
        }

        private async Task<string> LongRunningOperation()
        {
            int counter;

            for (counter = 0; counter < 5000; counter++)
            {
                Console.WriteLine(counter);
            }

            return "Counter = " + counter;
        }
    }
}
