using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        // An implicit conversion is permitted from array S to array T if the following are all true:
        // 1. the arrays have the same number of dimensions	
        // 2. the elements of  S have an implicit reference conversion to the element type of T
        // 3. both  S and T are reference types.
        public static void PrintArray(object[] arr)
        {
            foreach (object obj in arr)
            {
                Console.WriteLine("Word: {0}", obj);
            }
        }

        public static void Main()
        {
            string s = "I will not buy this record, it is scratched.";
            char[] separators = { ' ' };
            string[] words = s.Split(separators);
            // In this example, the string array of words can be passed as an objectarray, 
            // because each string element can be converted to object through a reference conversion.
            PrintArray(words);

            Console.ReadKey();
        }
    }
}
