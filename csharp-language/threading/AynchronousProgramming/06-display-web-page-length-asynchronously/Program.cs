using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;

namespace test
{
    static class Program
    {
        static void Main()
        {
            /* 
            CODE BLOCK EXPLANATION - 1
            * If you run the async version (ideally over a slow network connection), 
            you’ll see that the UI is responsive—you can still
            move the window around while the web page is fetching.
            */
            Application.Run(new AsyncForm());

            /* 
            CODE BLOCK EXPLANATION - 2
            * In particular, if you remove the async and awaitcontextual keywords, change HttpClient to WebClient, 
            and change GetStringAsync to DownloadString, the code will still compile and work… but the UI will freeze
            while it fetches the contents of the page.
            */
            //            Application.Run(new NonAsyncForm());
        }
    }
}
