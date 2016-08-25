using System;
using System.Threading;

namespace _01_broken_thread_example
{
    class Val
    {
        int number = 1;
        public void Bump()
        {
            int temp = number;
            Thread.Sleep(1);
            number = temp + 2;
            Console.WriteLine("number = {0}", number);
        }
        public override string ToString()
        {
            return (number.ToString());
        }
        public void DoBump()
        {
            for (int i = 0; i < 5; i++)
            {
                Bump();
            }
        }
    }
}