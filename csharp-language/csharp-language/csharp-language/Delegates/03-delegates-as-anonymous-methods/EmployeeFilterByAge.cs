using System;
using System.Collections.Generic;
using System.Text;

namespace Kdnc.App.Delegates.AnonymousMethods
{
    class EmployeeFilterByAge
    {
        int m_age;
        public EmployeeFilterByAge(int age)
        {
            m_age = age;
        }
        public bool OlderThan(Employee employee)
        {
            return employee.Age > m_age;
        }
    }
}
