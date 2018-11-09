using System;
using System.Collections.Generic;
using System.Text;

namespace Kdnc.App.Delegates.InstanceMembers
{
    public class User
    {
        string m_name;

        public User(string name)
        {
            m_name = name;
        }

        public void Process(string message)
        {
            Console.WriteLine("{0}: {1}", m_name, message);
        }
    }
}
