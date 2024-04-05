using System;
using System.Diagnostics;

class Numbers {
    public int Num1 { get; set; }
    public int Num2 { get; set; }
    public void PrintNums()
    {
        Console.WriteLine($"Число 1: {Num1}");
        Console.WriteLine($"Число 2: {Num2}");
    }
    public void ChangeNum1(int NewNum1)
    {
        Num1 = NewNum1;
    }
    public void ChangeNum2(int NewNum2)
    {
        Num2 = NewNum2;
    }

    public void Sum()
    {
        int sum = Num1 + Num2;
        Console.WriteLine($"Сумма: {sum}");
    }

    public void Max()
    {
        if (Num1 > Num2)
        {
            int max = Num1;
            Console.WriteLine($"Наибольшее значение: {max}");
        }
        else if(Num1<Num2)
        {
            int max = Num2;
            Console.WriteLine($"Наибольшее значение: {max}");
        }
        else
        {
            Console.WriteLine($"Числа равны");
        }
    }
}

class Program
{
    static void Main()
    {
        Numbers nums = new Numbers
        {
            Num1 = 19,
            Num2 = 25
        };
        nums.PrintNums();
        Console.WriteLine("Выберите опцию:");
        Console.WriteLine("1 - Изменить числа"  );
        Console.WriteLine("2 - Найти сумму чисел");
        Console.WriteLine("3 - Найти наибольшее значение");
        Console.WriteLine("4 - Выйти");
        bool yes = true;
        while (yes)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"Введите новое Число 1: ");
                    int NewNum1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Введите новое Число 2: ");
                    int NewNum2 = int.Parse(Console.ReadLine());
                    nums.ChangeNum1(NewNum1);
                    nums.ChangeNum2(NewNum2);
                    break;
                case 2:
                    nums.Sum();
                    break;
                case 3:
                    nums.Max();
                    break;
                case 4:
                    yes = false;
                    break;
            }
        }
    }
}