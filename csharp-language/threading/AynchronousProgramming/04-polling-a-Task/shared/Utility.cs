using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Utility
    {
        public static IEnumerable<char> BusySymbols()
        {
            string busySymbols = @"-\|/-\|/";
            int next = 0;
            while (true)
            {
                yield return busySymbols[next];
                next = (next + 1)%busySymbols.Length;
                yield return '\b';
            }
        }
    }
}
