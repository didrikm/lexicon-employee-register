namespace Employee
{
    class Employee
    {
        private string firstname;
        private string lastname;
        private decimal salary;

        public Employee(string firstNameArg, string lastNameArg, decimal salaryArg)
        {
            firstname = firstNameArg;
            lastname = lastNameArg;
            salary = salaryArg;
        }

        public string GetInfo()
        {
            return $"Name: {firstname} {lastname}, Salary: {salary:C}";
        }
    }
}
