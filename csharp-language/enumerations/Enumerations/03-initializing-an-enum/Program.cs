using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
// By default, the value of the first enum member is set to 0 and incremented for each 
// subsequent member. Specific values may be specified along with the member name.
    internal enum Values
    {
        A = 1,
        B = 5,
        C = 3,
        D = 42
    }

// Computed values can also be used, as long as they depend only on values 
// already defined in the enum. 
    internal enum Values2
    {
        A = 1,
        B = 2,
        C = A + B,
        D = A*C + 33
    }
}