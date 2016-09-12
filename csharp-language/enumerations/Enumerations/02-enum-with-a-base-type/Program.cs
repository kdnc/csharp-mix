using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    //    Each enumeration has an underlying type that specifies how much storage is allocated 
    //    for that enumeration. The valid base types for enumeration are 
    //    byte, sbyte, short, ushort, int, uint, long, and ulong. 
    internal enum SmallEnum : byte
    {
        A,
        B,
        C,
        D
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}