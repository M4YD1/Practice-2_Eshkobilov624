using System;
using System.Diagnostics;

class Student {
    
        public string surname { get; set; }
        public DateOnly birthDate { get; set; }
        public int GroupNumber { get; set; }
        public int[] AcademPerfomance { get; set; }

        public void ChangeSurname(string NewSurname)
        {
            surname = NewSurname;
        }
        public void ChangebirthDate(DateOnly NewbirthDate)
        {
            birthDate = NewbirthDate;
        }
        public void ChangeGroupNumber(int NewGroupNumber)
        {
            GroupNumber = NewGroupNumber;
        }
        public void PrintInfo(string SearchSurname, DateOnly SearchBirthDate)
        {
            if (SearchSurname == surname && SearchBirthDate == birthDate)
            {
                Console.WriteLine($"Фамилия: {surname}");
                Console.WriteLine($"Дата рождения: {birthDate}");
                Console.WriteLine($"Номер группы: {GroupNumber}");
                Console.WriteLine($"Успеваемость: ");
                foreach (var num in AcademPerfomance)
                {
                    Console.Write($"{num} ");
                }  
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Студент не найден");
            }
        }
    }

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            surname = "Пирожков",
            birthDate = new DateOnly(2006, 1, 6),
            GroupNumber = 624,
            AcademPerfomance = new int[] { 5, 5, 4, 5, 3 }
        };
        Console.WriteLine("Выберите опцию: ");
        Console.WriteLine("1 - Вывести информацию о студенте"  );
        Console.WriteLine("2 - Изменить информацию о студенте");
        Console.WriteLine("(Нажмите 3, чтобы выйти)");
        bool yes = true;
        while (yes)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"Введите фамилию: ");
                    string SearchSurname = Console.ReadLine();
                    Console.WriteLine($"Введите Дату рождения (гггг-мм-дд): ");
                    DateOnly SearchBirthDate = DateOnly.Parse(Console.ReadLine());
                    student.PrintInfo(SearchSurname,SearchBirthDate );
                    break;
                case 2:
                    Console.WriteLine($"Введите новую фамилию: ");
                    string NewSurname = Console.ReadLine();
                    Console.WriteLine($"Введите новую Дату рождения(гггг-мм-дд): ");
                    DateOnly NewbirthDate = DateOnly.Parse(Console.ReadLine());
                    Console.WriteLine($"Введите новый номер группы: ");
                    int NewGroupNumber = int.Parse(Console.ReadLine());
                    student.ChangeSurname(NewSurname);
                    student.ChangebirthDate(NewbirthDate);
                    student.ChangeGroupNumber(NewGroupNumber);
                    break;
                case 3:
                    yes = false;
                    break;
            }
        }
    }
}