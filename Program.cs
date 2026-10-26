using System;

class Program
{
    static void Main()
    {
        Employee employee = new Employee();

        employee.FIO = "Иванов";
        employee.Salary = 63500;

        employee.Show();

        double annualSalary = employee.CalculateAnnualSalary();
        Console.WriteLine($"Годовая зарплата: {annualSalary:F0} руб.");

        Console.ReadKey();
    }
}

class Employee
{
    public string FIO = "";
    public double Salary;

    public void Show()
    {
        Console.WriteLine($"ФИО сотрудника: {FIO}");
        Console.WriteLine($"Месячная зарплата: {Salary:F0} руб.");
    }

    public double CalculateAnnualSalary()
    {
        return Salary * 12;
    }
}
