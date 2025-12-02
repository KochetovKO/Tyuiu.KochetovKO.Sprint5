using System;
using System.IO;
using Tyuiu.KochetovKO.Sprint5.Task0.V18.Lib;

namespace Tyuiu.KochetovKO.Sprint5.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | выполнил: Кочетов К.О. | ИСПБ-25-1";

            try
            {
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("Спринт №5                                                                     ");
                Console.WriteLine("Тема: Класс File. Запись данных в текстовый файл                              ");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("Задание №0                                                                    ");
                Console.WriteLine("Вариант №18                                                                   ");
                Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                 ");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                              ");
                Console.WriteLine("******************************************************************************");

                int x = 3;
                Console.WriteLine($"x = {x}");

                Console.WriteLine("******************************************************************************");
                Console.WriteLine("РЕЗУЛЬТАТ:                                                                    ");
                Console.WriteLine("******************************************************************************");

                using (DataService ds = new DataService())
                {
                    string res = ds.SaveToFileTextData(x);

                    if (File.Exists(res))
                    {
                        Console.WriteLine("Файл: " + res);
                        Console.WriteLine("Создан успешно!");
                        Console.WriteLine("Содержимое файла:");
                        Console.WriteLine(File.ReadAllText(res));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: файл не был создан!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
                Console.WriteLine("Подробности: " + ex.StackTrace);
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}using System;
using System.IO;
using Tyuiu.KochetovKO.Sprint5.Task0.V18.Lib;

namespace Tyuiu.KochetovKO.Sprint5.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | выполнил: Кочетов К.О. | ИСПБ-25-1";

            try
            {
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("Спринт №5                                                                     ");
                Console.WriteLine("Тема: Класс File. Запись данных в текстовый файл                              ");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("Задание №0                                                                    ");
                Console.WriteLine("Вариант №18                                                                   ");
                Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                 ");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                              ");
                Console.WriteLine("******************************************************************************");

                int x = 3;
                Console.WriteLine($"x = {x}");

                Console.WriteLine("******************************************************************************");
                Console.WriteLine("РЕЗУЛЬТАТ:                                                                    ");
                Console.WriteLine("******************************************************************************");

                using (DataService ds = new DataService())
                {
                    string res = ds.SaveToFileTextData(x);

                    if (File.Exists(res))
                    {
                        Console.WriteLine("Файл: " + res);
                        Console.WriteLine("Создан успешно!");
                        Console.WriteLine("Содержимое файла:");
                        Console.WriteLine(File.ReadAllText(res));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: файл не был создан!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
                Console.WriteLine("Подробности: " + ex.StackTrace);
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}using System;
using System.IO;
using Tyuiu.KochetovKO.Sprint5.Task0.V18.Lib;

namespace Tyuiu.KochetovKO.Sprint5.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 5 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            
            try
            {
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("Спринт №5                                                                     ");
                Console.WriteLine("Тема: Класс File. Запись данных в текстовый файл                              ");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("Задание №0                                                                    ");
                Console.WriteLine("Вариант №18                                                                   ");
                Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                 ");
                Console.WriteLine("******************************************************************************");
                Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                              ");
                Console.WriteLine("******************************************************************************");

                int x = 3;
                Console.WriteLine($"x = {x}");

                Console.WriteLine("******************************************************************************");
                Console.WriteLine("РЕЗУЛЬТАТ:                                                                    ");
                Console.WriteLine("******************************************************************************");

                using (DataService ds = new DataService())
                {
                    string res = ds.SaveToFileTextData(x);
                    
                    if (File.Exists(res))
                    {
                        Console.WriteLine("Файл: " + res);
                        Console.WriteLine("Создан успешно!");
                        Console.WriteLine("Содержимое файла:");
                        Console.WriteLine(File.ReadAllText(res));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: файл не был создан!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
                Console.WriteLine("Подробности: " + ex.StackTrace);
            }
            
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}