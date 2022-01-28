namespace ConsoleUI
{
    public class EmployeeValidator
    {
        public static bool Validate(Employee employee)
        {
            // Check given information
            if (string.IsNullOrWhiteSpace(employee.FirstName))
            {
                Console.WriteLine("You have to enter a valid first name!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(employee.LastName))
            {
                Console.WriteLine("You have to enter a valid last name!");
                return false;
            }

            return true;
        }
    }
}
