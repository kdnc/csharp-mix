using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_generics_new_constraint
{
    class Program
    {
        static void Main(string[] args)
        {
            MyConstructedList<Car> m = new MyConstructedList<Car>(5);
            Console.ReadKey();
        }
    }
}
