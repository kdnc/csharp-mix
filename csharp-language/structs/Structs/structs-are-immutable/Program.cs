using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structs.v1;

namespace structs_are_immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(10, 15);
            PointHolder pointHolder = new PointHolder(point);
            Console.WriteLine(pointHolder.Current); // (10, 15)

            // Because Point is defined as a struct, when it is assigned into the Currentvariable,
            // the whole value is copied, and any changes to Current do not change pointHolder.Current.
            Point current = pointHolder.Current;
            current.m_x = 500;
            Console.WriteLine(pointHolder.Current); // (10, 15)
        }
    }
}
