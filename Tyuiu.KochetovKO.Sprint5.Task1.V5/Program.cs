using System;
using System.IO;
using Tyuiu.KochetovKO.Sprint5.Task1.V5.Lib;

namespace Tyuiu.KochetovKO.Sprint5.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Кочентов К. О. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Кочентов Кирилл Олегович | ИИПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F(x) = 5 - 3x + (1 + sin(x))/(2x - 0.5)                  *");
            Console.WriteLine("* Произвести табулирование f(x) на диапазоне [-5; 5] с шагом 1.          *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt               *");
            Console.WriteLine("* и вывести на консоль в таблицу. Округлить до двух знаков после запятой.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            try
            {
                // Сначала выводим таблицу
                string table = ds.GetFunctionTable(startValue, stopValue);
                Console.WriteLine(table);

                // Пытаемся сохранить в файл
                string resultPath = ds.SaveToFileTextData(startValue, stopValue);

                Console.WriteLine($"\nРезультат сохранен в файл: {resultPath}");

                // Показываем содержимое файла
                if (File.Exists(resultPath))
                {
                    Console.WriteLine("\nСодержимое файла:");
                    Console.WriteLine(new string('-', 30));
                    string[] fileLines = File.ReadAllLines(resultPath);
                    for (int i = 0; i < fileLines.Length; i++)
                    {
                        Console.WriteLine($"y[{i}] = {fileLines[i]}");
                    }
                }

                // Дополнительная информация
                Console.WriteLine($"\nТекущая директория: {Directory.GetCurrentDirectory()}");
                Console.WriteLine($"Временная директория: {Path.GetTempPath()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                Console.WriteLine("Но таблица значений была выведена выше!");
            }

            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}