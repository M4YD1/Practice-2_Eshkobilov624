using System;
using System.Diagnostics;

class Worker
{
    private string name = "Иван";
    private string surname= "Булкин";
    private int rate = 500;
    private int days = 31;

    public string GetName()
    {
        return name;
    }

    public string GetSurName()
    {
        return surname;
    }

    public int GetRate()
    {
        return rate;
    }

    public int GetDays()
    {
        return days;
    }
    public int GetSalary()
    {
        int salary = rate * days;
        Console.WriteLine($"Зарплата работника: {salary}");
        return salary;
    }
}
class Program
{
    static void Main()
    {
        Worker worker = new Worker();
        Console.WriteLine("Выберите опцию:");
        Console.WriteLine("1 - Вывести зарплату работника");
        Console.WriteLine("2 - Выйти");
        
        bool yes = true;
        while (yes)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    
                    worker.GetSalary();
                    break;
                case 2:
                    yes = false;
                    break;
            }
        }
    }
}