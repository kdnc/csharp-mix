namespace test
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