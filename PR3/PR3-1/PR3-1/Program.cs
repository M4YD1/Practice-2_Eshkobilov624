using System;
using System.Diagnostics;

class Worker {
    public string name { get; set; }
    public string surname { get; set; }
    public int rate { get; set; }
    public int days { get; set; }
    public void GetSalary()
    {
        int salary = rate * days;
        Console.WriteLine($"Зарплата работника: {salary}");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите опцию:");
        Console.WriteLine("1 - Вывести зарплату работника");
        Console.WriteLine("2 - Выйти");
        Worker worker = new Worker
        {
            name = "Иван",
            surname = "Булкин",
            rate = 500,
            days = 31
        };
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