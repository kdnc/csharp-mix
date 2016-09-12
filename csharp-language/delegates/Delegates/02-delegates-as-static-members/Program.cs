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
            Container employees = new Container();
            // create and add some employees here
            employees.Sort(Employee.SortByName);
            // employees is now sorted by name

            Console.ReadKey();
        }
    }
}
