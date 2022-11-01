using Project_1b.Entities;
using System.Collections.Generic;

List<Employee> employees = new List<Employee>();

System.Console.Write("Enter the number of employees: ");
int numberEmployees = int.Parse(Console.ReadLine());

for (int i = 0; i < numberEmployees; i++)
{
    System.Console.WriteLine();
    System.Console.WriteLine($"Employee #{i+1} data: ");
    System.Console.Write("Outsourced (y/n)? ");
    char outsourced = char.Parse(Console.ReadLine());
    System.Console.Write("Name: ");
    string name = Console.ReadLine();
    System.Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    System.Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());
    double addionalCharge = 0.0;

    if (outsourced == 'y')
    {
        System.Console.Write("Additional charge: ");
        addionalCharge = double.Parse(Console.ReadLine());
        employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, addionalCharge));
    }
    else
    {
        employees.Add(new Employee(name, hours, valuePerHour));
    }

}

System.Console.WriteLine();
System.Console.WriteLine("PAYMENTS:");
foreach (Employee item in employees)
    {
        System.Console.WriteLine(item);
    }
