using System;
using System.Threading;

namespace _03_joining_threads
{
    class ThreadSleeper
    {
        int m_seconds;
        private ThreadSleeper(int seconds)
        {
            m_seconds = seconds;
        }
        public void Nap()
        {
            Console.WriteLine("Napping {0} seconds", m_seconds);
            Thread.Sleep(m_seconds * 1000);
        }
        public static Thread DoSleep(int seconds)
        {
            ThreadSleeper threadSleeper = new ThreadSleeper(seconds);
            Thread thread = new Thread(new ThreadStart(threadSleeper.Nap));
            thread.Start();
            return (thread);
        }
    }
}