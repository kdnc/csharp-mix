using System;

namespace test
{
    internal class Employee
    {
        private string m_name;
        private int m_id;

        public Employee(string name, int id)
        {
            m_name = name;
            m_id = id;
        }

        public static readonly Container.CompareItemsCallback SortByName =
            new Container.CompareItemsCallback(CompareName);

        public static readonly Container.CompareItemsCallback SortById =
            new Container.CompareItemsCallback(CompareId);

        public static int CompareName(object obj1, object obj2)
        {
            Employee emp1 = (Employee) obj1;
            Employee emp2 = (Employee) obj2;
            return (String.Compare(emp1.m_name, emp2.m_name));
        }

        public static int CompareId(object obj1, object obj2)
        {
            Employee emp1 = (Employee) obj1;
            Employee emp2 = (Employee) obj2;

            if (emp1.m_id > emp2.m_id)
            {
                return (1);
            }
            else if (emp1.m_id < emp2.m_id)
            {
                return (-1);
            }
            else
            {
                return (0);
            }
        }

        
    }
}