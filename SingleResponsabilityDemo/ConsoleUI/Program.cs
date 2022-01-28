using ConsoleUI;

//Console.WriteLine("Welcome to my application!");
MessageManager.StartApplication();

Employee employee = EmployeeManager.SetData();

if (!EmployeeValidator.Validate(employee))
{
    MessageManager.EndApplication();
    return;
}

AccountManager.CreateAccount(employee);

MessageManager.EndApplication();

