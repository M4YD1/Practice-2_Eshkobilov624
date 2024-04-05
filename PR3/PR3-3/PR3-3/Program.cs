using System;
using System.Diagnostics;

class Calculation {
    public string calculationLine { get; set; }
    
    public void SetCalculationLine(string NewCalculationLine)
    {
        calculationLine = NewCalculationLine;
        Console.WriteLine($"Значение свойства успешно изменено");
    }

    public void SetLastSymbolCalculationLine(string symbol)
    {
        calculationLine += symbol;
        Console.WriteLine("Символ прибавлен");
    }

    public void GetCalculationLine()
    {
       Console.WriteLine(calculationLine); 
    }

    public void GetLastSymbol()
    {
        int LastSymbol = calculationLine.Length - 1;
        Console.WriteLine($"Последний символ: {calculationLine[LastSymbol]}");
    }

    public void DeleteLastSymbol()
    {
        int LastSymbol = calculationLine.Length - 1;
        calculationLine = calculationLine.Remove(LastSymbol);
        Console.WriteLine("Символ удален");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите опцию:");
        Console.WriteLine("1 - Вывести значение свойства");
        Console.WriteLine("2 - Изменить значение свойства");
        Console.WriteLine("3 - Прибавить символ в конец строки");
        Console.WriteLine("4 - Вывести последний символ");
        Console.WriteLine("5 - Удалить последний символ");
        Console.WriteLine("6 - Выйти");
        
        Calculation line = new Calculation
        {
            calculationLine = "Произвольный текст",
        };
        bool yes = true;
        while (yes)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    line.GetCalculationLine();
                    break;
                case 2:
                    Console.WriteLine("Введите новое значение: ");
                    string NewCalculationLine = Console.ReadLine();
                    line.SetCalculationLine(NewCalculationLine);
                    break;
                case 3:
                    Console.WriteLine("Введите символ: ");
                    string symbol = Console.ReadLine();
                    line.SetLastSymbolCalculationLine(symbol);
                    break;
                case 4:
                    line.GetLastSymbol();
                    break;
                case 5:
                    line.DeleteLastSymbol();
                    break;
                case 6:
                    yes = false;
                    break;
            }
        }
    }
}