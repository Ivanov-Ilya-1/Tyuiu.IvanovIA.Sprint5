using Tyuiu.IvanovIA.Sprint5.Task1.V20.Lib;


internal class Program
{
    private static void Main(string[] args)
    {
        int startvalue = -5;
        int stopvalue = 5;
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Иванов И.А. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Иванов Илья Анатольевич | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение и сохраняет результат   *");
        Console.WriteLine("* в текстовый файл                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("startValue = " + startvalue);
        Console.WriteLine("stopValue = " + stopvalue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(startvalue, stopvalue);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
    }
}