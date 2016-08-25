using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(3, 1);
            Complex c2 = new Complex(1, 2);

            Console.WriteLine("c1 == c2: {0}", c1 == c2);
            Console.WriteLine("c1 != c2: {0}", c1 != c2);
            Console.WriteLine("c1 + c2 = {0}", c1 + c2);
            Console.WriteLine("c1 - c2 = {0}", c1 - c2);
            Console.WriteLine("c1 * c2 = {0}", c1 * c2);
            Console.WriteLine("c1 / c2 = {0}", c1 / c2);

            Console.ReadKey();
        }
    }
}
