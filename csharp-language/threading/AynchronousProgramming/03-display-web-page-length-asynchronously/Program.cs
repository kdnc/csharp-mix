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
//            Application.Run(new NonAsyncForm());
            Application.Run(new AsyncForm());
        }
    }
}
