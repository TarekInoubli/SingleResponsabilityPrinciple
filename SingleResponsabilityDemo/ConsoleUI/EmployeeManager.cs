namespace ConsoleUI
{
    public class EmployeeManager
    {
        public static Employee SetData()
        {
            // Ask for employee information
            Employee employee = new Employee();

            Console.WriteLine("Enter your first name:");
            employee.FirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            employee.LastName = Console.ReadLine();

            return employee;
        }
    }
}
