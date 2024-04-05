using System;
using System.Diagnostics;

class Counter {
    public int Number { get; set; }

    public void Increase()
    {
        Number += 1;
        Console.WriteLine("Счетчик изменен");
    }
    public void Decrease()
    {
        Number -= 1;
        Console.WriteLine("Счетчик изменен");
    }
    public void PrintCount()
    {
        Console.WriteLine($"Текущее состояние счетчика: {Number}");
    }
    public void ChangeNumber(int NewNum)
    {
        Number = NewNum;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите опцию:");
        Console.WriteLine("1 - Увеличить счетчик на 1"  );
        Console.WriteLine("2 - Уменьшить счетчик на 1");
        Console.WriteLine("3 - Изменить значение");
        Console.WriteLine("4 - Вывести значение");
        Console.WriteLine("5 - Выйти");
        
        Counter counter = new Counter
        {
            Number = 0
        };
        
        bool yes = true;
        while (yes)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    counter.Increase();
                    break;
                case 2:
                    counter.Decrease();
                    break;
                case 3:
                    Console.WriteLine($"Введите новое значение: ");
                    int NewNum = int.Parse(Console.ReadLine());
                    counter.ChangeNumber(NewNum);
                    Console.WriteLine("Значение счетчика изменено");
                    break;
                case 4:
                    counter.PrintCount();
                    break;
                case 5:
                    yes = false;
                    break;
            }
        }
    }
}