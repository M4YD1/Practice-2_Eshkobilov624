namespace GarageConsoleApp;

public class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Выберите функцию:");
        Console.WriteLine("1 - Просмотр и добавление данных о типах автомобилей");
        Console.WriteLine("2 - Просмотр и добавление данных о водителях и их прав");
        Console.WriteLine("3 - Просмотр и добавление данных о машинах");
        Console.WriteLine("4 - Просмотр и добавление данных о маршрутах");
        Console.WriteLine("5 - Просмотр и удаление данных о рейсах");
        Console.WriteLine("6 - Выйти");
        
        bool menu = true;
        while (menu)
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    bool menu1 = true;
                    while (menu1)
                    {
                        int Menu1num = StringToInt(NotEmptyLine("1 - Добавить данные \n 2 - Вывести данные \n 3 - Назад"));
                        switch (Menu1num)
                        {
                            case 1:
                                string typeName = NotEmptyLine("Введите тип автомобиля: ");
                                DatabaseRequests.AddTypeCarQuery(typeName);
                                break;
                            case 2:
                                DatabaseRequests.GetTypeCarQuery();
                                Console.WriteLine();
                                break;
                            case 3: 
                                menu1 = false;
                                break;
                        }
                    }
                    break;
                
                case 2:
                    bool menu2 = true;
                    while (menu2)
                    {
                        int Menu2num = StringToInt(NotEmptyLine("1 - Добавить данные \n 2 - Вывести данные \n 3 - Назад"));
                        switch (Menu2num)
                        {
                            case 1:
                                int subMenu2num = StringToInt(NotEmptyLine("1 - Добавить категорию прав \n 2 - Добавить категорию прав водителя \n 3 - Добавить водителя"));
                                switch (subMenu2num)
                                {
                                    case 1:
                                        string Category = NotEmptyLine("Введите категорию прав: ");
                                        DatabaseRequests.AddRightsCategoryQuery(Category);
                                        break;
                                    case 2:
                                        int idCategory = StringToInt(NotEmptyLine(("Введите id категории прав: ")));
                                        int idDriver = StringToInt(NotEmptyLine("Введите id водителя: "));
                                        DatabaseRequests.AddDriverRightsCategoryQuery(idDriver, idCategory);
                                        break;
                                    case 3:
                                        string name = NotEmptyLine("Введите имя водителя: ");
                                        string surname = NotEmptyLine("Введите фамилию водителя: ");
                                        string Birth = NotEmptyLine("Введите день рождения водителя: (дд.мм.гггг): ");
                                        try
                                        {
                                            DateTime birthdate = DateTime.Parse(Birth);
                                            DatabaseRequests.AddDriverQuery(name, surname, birthdate);
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Ошибка!");
                                            break;
                                        }
                                        break;
                                   case 4:
                                       menu2 = false;
                                       break;
                                }
                                Console.WriteLine();
                                break;
                            case 2:
                                DatabaseRequests.GetDriverQuery();
                                Console.WriteLine();
                                int driverID = StringToInt(NotEmptyLine("Введите id водителя: "));
                                DatabaseRequests.GetDriverRightsCategoryQuery(driverID);
                                Console.WriteLine();
                                break;
                            case 3:
                                menu2 = false;
                                break;
                        }
                    }
                    break;
                
                case 3:
                    bool menu3 = true;
                    while (menu3)
                    {
                        int Menu3num = StringToInt(NotEmptyLine("1 - Добавить данные \n 2 - Вывести данные \n 3 - Назад"));
                        switch (Menu3num)
                        {
                            case 1:
                                int idTypeCar = StringToInt(NotEmptyLine("Введите тип автомобиля: "));
                                string nameCar = NotEmptyLine("Введите название автомобиля: ");
                                string stateNumber = NotEmptyLine("Введите государственный номер автомобиля: ");
                                int numberPassengers = StringToInt(NotEmptyLine("Введите количество пассажиров: "));
                                DatabaseRequests.AddCarQuery(idTypeCar, nameCar, stateNumber, numberPassengers);
                                break;
                            case 2:
                                DatabaseRequests.GetCarQuery();
                                Console.WriteLine();
                                break;
                            case 3:
                                menu3 = false;
                                break;
                        }
                    }
                    break;
                
                case 4:
                    bool menu4 = true;
                    while (menu4)
                    {
                        int Menu4num = StringToInt(NotEmptyLine("1 - Добавить данные \n 2 - Вывести данные \n 3 - Назад"));
                        switch (Menu4num)
                        {
                            case 1:
                                string itineraryName = NotEmptyLine("Введите название маршрута: ");
                                DatabaseRequests.AddItineraryQuery(itineraryName);
                                Console.WriteLine();
                                break;
                            case 2:
                                DatabaseRequests.GetItineraryQuery();
                                Console.WriteLine();
                                break;
                            case 3:
                                menu4 = false;
                                break;
                        }
                    }
                    break;
                   
                case 5:
                    bool menu5 = true;
                    while (menu5)
                    {
                        int Menu5num = StringToInt(NotEmptyLine("1 - Добавить данные \n 2 - Вывести данные \n 3 - Назад"));
                        switch (Menu5num)
                        {
                            case 1:
                                int idDriverR = StringToInt(NotEmptyLine("Введите id водителя: "));
                                int idCarR = StringToInt(NotEmptyLine("Введите id автомобиля: "));
                                int idItineraryR = StringToInt(NotEmptyLine("Введите id маршрута: "));
                                int numberPassengersR = StringToInt(NotEmptyLine("Введите количество пассажиров: "));
                                DatabaseRequests.AddRouteQuery(idDriverR, idCarR, idItineraryR, numberPassengersR);
                                Console.WriteLine();
                                break;
                            case 2:
                                DatabaseRequests.GetRouteQuery();
                                Console.WriteLine();
                                break;
                            case 3:
                                menu5 = false;
                                break;
                        }
                    }
                    break;
                
                case 6:
                    menu = false;
                    break;
            }
        }
    }
    
    public static string NotEmptyLine(string text)
    {
        string Num = "";
        bool work = true;
        while (work)
        {
            Console.WriteLine(text);
            Num = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(Num))
            {
                break;
            }
        }
        return Num;
    }
    public static int StringToInt(string text)
    {
        int Numero = 0;
        try
        {
            Numero = int.Parse(text);
        }
        catch(FormatException)
        {
            Console.WriteLine("Ошибка!");
        }

        return Numero;
    }
}
