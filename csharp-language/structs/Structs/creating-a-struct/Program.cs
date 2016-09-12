using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structs.v1;

namespace creating_a_struct
{
    class Program
    {
        public static void Main()
        {
            // Method 1 - Creating a struct
            Point start;
            start.m_x = 10;
            start.m_y = 10;
            Console.WriteLine("Start: {0}", start);

            // Method 2 - Creating a struct
            Point start2 = new Point(5, 5);
            Console.WriteLine("Start 2: {0}", start2);
        }
    }
}
