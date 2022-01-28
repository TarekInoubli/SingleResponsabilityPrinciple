namespace ConsoleUI
{
    public class AccountManager
    {
        public static void CreateAccount(Employee employee)
        {
            Console.WriteLine($"Account successfully created! Your yousername is {employee.FirstName.Substring(0, 1)}{employee.LastName}");
        }
    }
}
