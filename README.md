# SingleResponsabilityPrinciple
In this short example we will see the "Single Responsability" principle in C#

## Example
```C#
// See https://aka.ms/new-console-template for more information
using ConsoleUI;

Console.WriteLine("Welcome to my application!");

// Ask for employee information
Employee employee = new Employee();

Console.WriteLine("Enter your first name:");
employee.FirstName = Console.ReadLine();

Console.WriteLine("Enter your last name:");
employee.LastName = Console.ReadLine();

// Check given information
if (string.IsNullOrWhiteSpace(employee.FirstName))
{
    Console.WriteLine("You have to enter a valid first name!");
    Console.ReadLine();
    return;
}

if (string.IsNullOrWhiteSpace(employee.LastName))
{
    Console.WriteLine("You have to enter a valid last name!");
    Console.ReadLine();
    return;
}

// Create an account for the employee
Console.WriteLine($"Account successfully created! Your yousername is {employee.FirstName.Substring(0,1)}{employee.LastName}");

Console.ReadLine();
```
This is a simple project created in C#. The code I Have here is rather simple. A Console Application that asks for employee information(first name and last name) and the generates an account for this employee and returns a user name for the employee, if all given information are correct.\
**BUT**, in this code if we decide to change how we tolk to the employee, we have to change the class. We also have to change the class, if we decide to change how we capture the first and last name. If we change how to validate the entered information, this class has to change.\
There are several different changes that could affect this class!\
**Single Responsability Principle** says there is one reason to change per class.\
Let's look how we could do that:

***[See Solution](https://github.com/TarekInoubli/SingleResponsabilityPrinciple)*** ⬆️
