namespace ConsoleUI
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email => $"{FirstName}.{LastName}@company.com";
    }
}
