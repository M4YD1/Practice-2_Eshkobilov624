using System;
using System.Diagnostics;

class NewClass {
    public int property1 { get; set; }
    public string property2 { get; set; }

    public NewClass(int Property1,string Property2 )
    {
        property1 = Property1;
        property2 = Property2;
    }
    
    public NewClass()
    {
        property1 = 1;
        property2 = "Свойство";
    }

    ~NewClass()
    {
        Console.WriteLine($"{property1} было удалено");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите опцию:");
        Console.WriteLine("1 - Ввести параметры");
        Console.WriteLine("2 - Показать свойства");
        Console.WriteLine("3 - Удалить объект");
        Console.WriteLine("4 - Выйти");
        NewClass class = new NewClass();
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
                    Console.WriteLine($"Введите значение 1 свойства: ");
                    int Property1 = int.Parse(Console.ReadLine());
                    
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