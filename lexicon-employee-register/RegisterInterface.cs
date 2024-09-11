namespace lexicon_employee_register
{
    public class RegisterInterface
    {
        static List<Employee> employees = new List<Employee>();

        public RegisterInterface()
        {
            while (true)
            {
                Console.Clear();
                PrintMenu();
#pragma warning disable CS8600
                string choice = Console.ReadLine();
#pragma warning disable CS8600

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        DeleteEmployee();
                        break;
                    case "3":
                        ShowAllEmployees();
                        break;
                    case "4":
                        Console.WriteLine("\nGoodbye!");
                        return;
                    default:
                        Console.WriteLine("\nInvalid input. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("\nEmployee Registry Menu");
            Console.WriteLine("\n1. Add employee");
            Console.WriteLine("2. Delete employee");
            Console.WriteLine("3. Show all employee records");
            Console.WriteLine("4. Quit");
            Console.Write("\nEnter your choice: ");
        }

        static void AddEmployee()
        {
            Console.Write("\nEnter first name: ");
            string firstName = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine() ?? string.Empty;

            decimal salary;
            while (true)
            {
                Console.Write("Enter salary: ");
                if (decimal.TryParse(Console.ReadLine(), out salary))
                {
                    break;
                }
                Console.WriteLine("\nInvalid salary. Please enter a valid number.");
            }

            employees.Add(new Employee(firstName, lastName, salary));
            Console.WriteLine("\nEmployee added successfully.");
        }

        static void DeleteEmployee()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("\nNo employees to delete.");
                return;
            }

            Console.WriteLine("\nCurrent employees:");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {employees[i].GetInfo()}");
            }

            Console.Write("\nEnter the number of the employee to delete: ");
            if (
                int.TryParse(Console.ReadLine(), out int index)
                && index > 0
                && index <= employees.Count
            )
            {
                employees.RemoveAt(index - 1);
                Console.WriteLine("\nEmployee deleted successfully.");
            }
            else
            {
                Console.WriteLine("\nInvalid input. No employee deleted.");
            }
        }

        static void ShowAllEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("\nNo employees in the registry.");
                return;
            }

            Console.WriteLine("\nEmployee Records:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.GetInfo());
            }
        }
    }
}
