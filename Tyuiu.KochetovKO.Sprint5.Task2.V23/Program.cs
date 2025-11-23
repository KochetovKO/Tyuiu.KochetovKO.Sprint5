using System;
using System.IO;
using Tyuiu.KochetovKO.Sprint5.Task2.V23.Lib;

namespace Tyuiu.KochetovKO.Sprint5.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Кочентов К. О. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #23                                                              *");
            Console.WriteLine("* Выполнил: Кочентов Кирилл Олегович | ИИПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mtrx = new int[3, 3] {  { 7, 2, 8 },

                                           { 6, 9, 1 },

                                           { 2, 3, 5} };

            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.WriteLine($"{mtrx[i, j]} \t");

                }
            
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);
           
            Console.WriteLine("Файл : " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
