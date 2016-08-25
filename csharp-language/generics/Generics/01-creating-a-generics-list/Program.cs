using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_generics_new_constraint;

namespace _01_creating_a_generics_list
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> l = new MyList<int>(5);
            Console.ReadKey();
        }
    }
}
