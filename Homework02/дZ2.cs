using System;
using System.ComponentModel.Design;
class Programmm
{
    static void Main()
    {
        //Задание #1
        Console.WriteLine("Тип данных - максимальное значение - минимальное значение");
        Console.WriteLine($"byte -{byte.MaxValue} - {byte.MinValue}");
        Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
        Console.WriteLine($" short - {short.MaxValue} - {short.MinValue}");
        Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
        Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
        Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
        Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
        Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue} ");
        Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
        Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
        Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");

        //Задание #2

        Console.WriteLine("Введите имя:");
        string name = Console.ReadLine();
        Console.WriteLine("Введите город:");
        string city = Console.ReadLine();
        Console.WriteLine("Введите возраст");
        int age = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine("Введите PIN-код");
        string pin = Console.ReadLine();
        Console.WriteLine("Информация о пользователе");
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Город: {city}");
        Console.WriteLine($"Возраст:{age} ");
        Console.WriteLine($"PIN-код:{pin} ");

        //Задание #3
        
        Console.WriteLine();
        string text = Console.ReadLine();
        string result = "";
        foreach (char c in text)
        {
            if (char.IsUpper(c))
                result += char.ToLower(c);
            else if (char.IsLower(c)) ;
            result += char.ToUpper(c);
        }

        Console.WriteLine("Результат:");
        Console.WriteLine(result);

        //Задание #4

        Console.WriteLine("Введите строку:");
        string textt = Console.ReadLine() ;
        Console.WriteLine("Введите подстроку:");
        string substring = Console.ReadLine() ;
        int count = 0;
        int position = 0;
        while((position = textt.IndexOf(substring, position)) != -1)
        {
            count ++;
            position += substring.Length;
        }
        Console.WriteLine($"Количество вхождений:");

        //Задание #5
        

        int normPrice = Convert.ToInt32(Console.ReadLine());
        int salePrice = Convert.ToInt32(Console.ReadLine());
        int holidayPrice = Convert.ToInt32(Console.ReadLine());

        int saving = normPrice * salePrice / 100;
        int bottles = holidayPrice / saving;

            Console.WriteLine(bottles);
    }
}
