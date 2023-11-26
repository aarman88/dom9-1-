using System;

public class Employee
{
    protected string name;
    protected int age;
    protected double salary;

    public Employee(string name, int age, double salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    // Метод для вывода информации о сотруднике
    public void GetInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Зарплата: {salary}");
    }

    // Метод для расчета годовой зарплаты
    public virtual double CalculateAnnualSalary()
    {
        return salary * 12;  // Простой расчет годовой зарплаты (без учета налогов и бонусов)
    }
}

class Program
{
    static void Main()
    {
        // Пример использования базового класса Employee
        Employee employee = new Employee("John Doe", 30, 50000);
        employee.GetInfo();

        double annualSalary = employee.CalculateAnnualSalary();
        Console.WriteLine($"Годовая зарплата: {annualSalary}");
    }
}
