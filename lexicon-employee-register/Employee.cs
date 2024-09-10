namespace Employee
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public decimal Salary;

        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public string GetInfo()
        {
            return $"Name: {FirstName} {LastName}, Salary: {Salary:C}";
        }
    }
}
