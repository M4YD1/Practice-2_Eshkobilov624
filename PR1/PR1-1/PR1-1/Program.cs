using System;
class HelloWorld {
    static void Main() {
        Console.WriteLine("Введите строку J: ");
        string J = Console.ReadLine();
        Console.WriteLine("Введите строку S: ");
        string S = Console.ReadLine();
        bool[] jewels = new bool[200];
        int count = 0;
        foreach (char jewel in J)
        {
            jewels[jewel] = true;
        }
        foreach (char stone in S)
        {
            if (jewels[stone])
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}