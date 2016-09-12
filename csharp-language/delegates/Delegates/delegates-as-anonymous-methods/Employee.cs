namespace test
{
    class Employee
    {
        public Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}