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
            // string collection
            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"
            };

            // LINQ Method Syntax
            var result = stringList.Where(s => s.Contains("Tutorials"));

            var resultList = result.ToList(); // "C# Tutorials", "VB.NET Tutorials", "MVC Tutorials"

            Console.ReadKey();
        }
    }
}