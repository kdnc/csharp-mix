using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("John", 33, 22000m));
            employees.Add(new Employee("Eric", 42, 18000m));
            employees.Add(new Employee("Michael", 33, 19500m));

//            EmployeeFilterByAge filterByAge = new EmployeeFilterByAge(40);
//            int index = employees.FindIndex(filterByAge.OlderThan);

            int index = employees.FindIndex(
                delegate(Employee employee) { return employee.Age > 40; });

            Console.WriteLine("Found index : {0}", index);

            Console.ReadKey();
        }
    }
}