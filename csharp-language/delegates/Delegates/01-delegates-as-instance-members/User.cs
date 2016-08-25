using System;

namespace test
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