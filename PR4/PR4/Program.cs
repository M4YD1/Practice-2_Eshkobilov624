using System;
class Program {
    static void Main()
    {
        string RomNumbers = Console.ReadLine();
        int number = 0;
        int i = 0;
        while (i < RomNumbers.Length)
        {
            if (RomNumbers[i] == 'I')
            {
                if (i + 1 < RomNumbers.Length && RomNumbers[i + 1] == 'V')
                {
                    number += 4;
                    i += 2;
                }
                else if (i + 1 < RomNumbers.Length && RomNumbers[i + 1] == 'X')
                {
                    number += 9;
                    i += 2;
                }
                else
                {
                    number += 1;
                    i += 1;
                }
            }
            else if (RomNumbers[i] == 'V' )
            {
                number += 5;
                i += 1;
            }

            else if (RomNumbers[i] == 'X')
            {
                if (i + 1 < RomNumbers.Length && RomNumbers[i + 1] == 'L')
                {
                    number += 40;
                    i += 2;
                }
                else if (i + 1 < RomNumbers.Length && RomNumbers[i + 1] == 'C')
                {
                    number += 90;
                    i += 2;
                }
                else
                {
                    number += 10;
                    i += 1;
                }
            }

            else if (RomNumbers[i] == 'L')
            {
                number += 50;
                i += 1;
            }

            else if (RomNumbers[i] == 'C')
            {
                if (i + 1 < RomNumbers.Length && RomNumbers[i + 1] == 'D')
                {
                    number += 400;
                    i += 2;
                }
                else if (i + 1 < RomNumbers.Length && RomNumbers[i + 1] == 'M')
                {
                    number += 900;
                    i += 2;
                }
                else
                {
                    number += 100;
                    i += 1;
                }
            }

            else if (RomNumbers[i] == 'D')
            {
                number += 500;
                i += 1;
            }

            else if (RomNumbers[i] == 'M')
            {
                number += 1000;
                i += 1;
            }
        }
        Console.WriteLine(number);
    }
}