using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        delegate void ProcessHandler(string message);

        public static void Main()
        {
            User user = new User("George");
            ProcessHandler handler = new ProcessHandler(user.Process);
            handler("Wake Up!");
            Console.ReadKey();
        }
    }
}
