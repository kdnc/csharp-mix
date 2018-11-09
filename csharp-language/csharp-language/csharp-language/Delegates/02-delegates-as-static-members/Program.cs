using System;
using System.Collections.Generic;
using System.Text;

namespace Kdnc.App.Delegates.StaticMembers
{
    class DelegatesAsStaticMembers
    {

        public static void Run()
        {
            Container employees = new Container();
            // create and add some employees here
            employees.Sort(Employee.SortByName);
            // employees is now sorted by name

            Console.ReadKey();
        }
    }
}
