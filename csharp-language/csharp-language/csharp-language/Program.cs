using System;
using System.Collections.Generic;
using System.Text;
using Kdnc.App.Arrays;
using Kdnc.App.Delegates.AnonymousMethods;
using Kdnc.App.Delegates.InstanceMembers;
using Kdnc.App.Delegates.StaticMembers;

namespace Kdnc.App
{
    class Program
    {
        public static void Main()
        {
//            ArrayInitialization.Run();
//            MultiDimensionalArray.Run();
//            JaggedArray.Run();
//            ArrayConversion.Run();

            DelegatesAsInstanceMembers.Run();
            DelegatesAsStaticMembers.Run();
            DelegatesAsAnonymousMembers.Run();
        }
    }
}
