using System;
using System.Diagnostics;

class Train {
    
        public string DestinationName { get; set; }
        public int TrainNum { get; set; }
        public TimeOnly Time { get; set; }
        public void PrintInfo(int SearchTrainNum)
        {
            if (SearchTrainNum == TrainNum)
            {
                Console.WriteLine($"Пункт назначения: {DestinationName}");
                Console.WriteLine($"Номер поезда: {TrainNum}");
                Console.WriteLine($"Время отправления: {Time}");
            }
        }
    }

class Program
{
    static void Main()
    {
        Train train1 = new Train
        {
            DestinationName  = "Москва",
            TrainNum = 5004,
            Time = new TimeOnly(19,38),
        };
        Train train2 = new Train
        {
            DestinationName  = "Волгоград",
            TrainNum = 5104,
            Time = new TimeOnly(17,15),
        };
        Train train3 = new Train
        {
            DestinationName  = "Новосибирск",
            TrainNum = 5002,
            Time = new TimeOnly(14,10),
        };
        Console.WriteLine("Выберите опцию: ");
        Console.WriteLine("1 - Вывести информацию о поезде"  );
        Console.WriteLine("2 - выйти");
        bool yes = true;
        while (yes)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"Введите номер поезда: ");
                    int SearchTrainNum = int.Parse(Console.ReadLine());
                    train1.PrintInfo(SearchTrainNum);
                    train2.PrintInfo(SearchTrainNum);
                    train3.PrintInfo(SearchTrainNum);
                    break;
                case 2:
                    yes = false;
                    break;
            }
        }
    }
}