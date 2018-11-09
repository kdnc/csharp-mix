using System;
using System.Collections.Generic;
using System.Text;
using Kdnc.App.Delegates.StaticMembers;

namespace Kdnc.App.Delegates.AnonymousMethods
{
    class DelegatesAsAnonymousMembers
    {

        public static void Run()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("John", 33, 22000m));
            employees.Add(new Employee("Eric", 42, 18000m));
            employees.Add(new Employee("Michael", 33, 19500m));

            //            EmployeeFilterByAge filterByAge = new EmployeeFilterByAge(40);
            //            int index = employees.FindIndex(filterByAge.OlderThan);

            int index = employees.FindIndex(
                delegate (Employee employee) { return employee.Age > 40; });

            Console.WriteLine("Found index : {0}", index);

            Console.ReadKey();
        }
    }
}
