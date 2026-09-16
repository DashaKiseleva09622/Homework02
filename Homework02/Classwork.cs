using System;
class Progmam
{
    static void Main()

    {
        //Задание 0

        byte oxygenLevel = 250;
        byte extraOxygen = 10;
        byte result = (byte)(oxygenLevel + extraOxygen);
        Console.WriteLine("Значение oxygenLevel:" + oxygenLevel);
        Console.WriteLine("Значение extraOxygen:" + extraOxygen);
        Console.WriteLine("Значение result:" + result);
        Console.WriteLine("Значение + oxygenLevel без приведения к bute:" + (oxygenLevel + extraOxygen));
        Console.WriteLine("Почему result равно 4, а не 260?");
        Console.WriteLine("Тип byte хранит значения от 0 до 255. При приведении 260 к byte происходит переполнение, поэтому получается 4.");
        Console.WriteLine("В каком случае int-версия показала бы правильный ответ?");
        Console.WriteLine("Если использовать тип int, значение 260 сохранится без переполнения.");
        int correctResult = oxygenLevel + extraOxygen;
        Console.WriteLine("Правильный результат:" + correctResult);
        Console.WriteLine("Какой тип нужно использовать, чтобы вместить 260?");
        Console.WriteLine("Тип int.");
    }
}

class Cosmonaut
{
    public string Name;
    public int Age;
    public double Height;
    public double Weight;
    public string FavoriteFilm;

    static void Main()
    {
        //Задание 1 "Анкета космонавта"

        Console.WriteLine();
        string name = Console.ReadLine();
        Console.WriteLine();
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine();
        double height = int.Parse(Console.ReadLine());
        Console.WriteLine();
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine();
        string film = Console.ReadLine();
        Console.WriteLine() ;
        Console.WriteLine("Имя:" + name);
        Console.WriteLine("Возраст:" + age);
        Console.WriteLine("Рост:" +height);
        Console.WriteLine("Вес:" + weight);
        Console.WriteLine("Любимый фильм:"+ film);
    }
}
enum CarriageType
{
    Плацкарт,
    Купе,
    СВ,
    Люкс
}
class TrainTicket
{
    public string PassengerName;
    public int TrainNumber;
    public DateTime DepartureDate;
    public TimeSpan DepartureTime;
    public CarriageType Carriage;
    public decimal Price;

    static void Main()
    { 
        //Задание 2 "Билет на поезд"

        TrainTicket ticket = new TrainTicket();
        Console.WriteLine("Введите ФИО пассажира");
        ticket.PassengerName = Console.ReadLine();
        Console.WriteLine("Введите номер поезда:");
        ticket.TrainNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите дату отправления (дд.мм.ггг):");
        ticket.DepartureDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Введите время отправления (чч:мм:");
        ticket.DepartureTime = TimeSpan.Parse(Console.ReadLine());
        Console.WriteLine("Выберите тип вагона:");
        Console.WriteLine("0 - Плацкарт");
        Console.WriteLine("1 - Купе");
        Console.WriteLine("2 - СВ");
        Console.WriteLine("3 - Люкс");
        int carriageNumber = int.Parse(Console.ReadLine());
        ticket.Carriage = (CarriageType)carriageNumber;
        Console.WriteLine("Введите цену билета:");
        ticket.Price = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Билет на поезд");
        Console.WriteLine("ФИО пассажира:" + ticket.PassengerName);
        Console.WriteLine("Номер поезда:" + ticket.TrainNumber);
        Console.WriteLine("Дата отправления:" + ticket.DepartureDate);
        Console.WriteLine("Время отправления:" + ticket.DepartureTime);
        Console.WriteLine("Тип вагона:" + ticket.Carriage);
        Console.WriteLine("Цена билета" + ticket.Price + "рублей");
    }
}
enum CarClass
{
    Эконом,
    Комфорт,
    Бизнес,
    Премиум
}
class CarRental
{
    public string ClientName;
    public string carBrand;
    public CarClass Class;
    public DateTime RentaiStartDate;
    static void Main()
    {
        //Задание 3 "Арена автомобиля"

        CarRental rental = new CarRental();
        Console.WriteLine("Введите имя клиената:");
        rental.ClientName = Console.ReadLine();
        Console.WriteLine("Введите марку автомобиля:");
        rental.carBrand = Console.ReadLine();
        Console.WriteLine("Выберите класс автомобиля:");
        Console.WriteLine("0 - Эконом");
        Console.WriteLine("1 - Комфорт");
        Console.WriteLine("2 - Бизнес");
        Console.WriteLine("3 - Премиум");
        int classNumber = int.Parse(Console.ReadLine());
        rental.Class = (CarClass)classNumber;
        Console.WriteLine("Введите дату начала аренды (дд.мм.гггг");
        rental.RentaiStartDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("АРЕНДА АВТОМОБИЛЯ");
        Console.WriteLine("Имя клиента:" + rental.ClientName);
        Console.WriteLine("Марка автомобиля:" + rental.carBrand);
        Console.WriteLine("Класс автомобиля:" + rental.Class);
        Console.WriteLine("Дата начала аренды:" + rental.RentaiStartDate.ToString("дд.мм.гггг"));
    }
}