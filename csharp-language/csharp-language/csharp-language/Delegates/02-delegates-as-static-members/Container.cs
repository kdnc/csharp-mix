using System;
using System.Collections.Generic;
using System.Text;

namespace Kdnc.App.Delegates.StaticMembers
{
    class Container
    {
        public delegate int CompareItemsCallback(object obj1, object obj2);
        public void Sort(CompareItemsCallback compare)
        {
            // not a real sort, just shows what the
            // inner loop code might do
            int x = 0;
            int y = 1;
            object item1 = arr[x];
            object item2 = arr[y];
            int order = compare(item1, item2);
        }
        object[] arr = new object[] { new Employee("Nuwan", 2), new Employee("Chamara", 1) }; // items in the collection
    }
}
