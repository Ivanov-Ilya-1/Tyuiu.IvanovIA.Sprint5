using Tyuiu.IvanovIA.Sprint5.Task2.V10.Lib;


internal class Program
{
    private static void Main(string[] args)
    {
        int rows = 3; int cols = 3;
        int[,] matrix = new int[rows, cols];

        DataService ds = new DataService();
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

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                while (true)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    if (int.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {
                        break;
                    }
                    Console.WriteLine("Ошибка! Введите целое число.");
                }
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(matrix);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
    }
}