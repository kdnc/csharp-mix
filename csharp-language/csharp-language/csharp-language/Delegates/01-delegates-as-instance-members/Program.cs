using System;
using System.Collections.Generic;
using System.Text;

namespace Kdnc.App.Delegates.InstanceMembers
{
    class DelegatesAsInstanceMembers
    {
        delegate void ProcessHandler(string message);

        public static void Run()
        {
            User user = new User("George");
            ProcessHandler handler = new ProcessHandler(user.Process);
            handler("Wake Up!");
            Console.ReadKey();
        }
    }
}
