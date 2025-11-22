using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint5.Task0.V18.Lib;

namespace Tyuiu.KochetovKO.Sprint5.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 5 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Спринт №5                                                                     ");
            Console.WriteLine("Тема: Класс File. Запись данных в текстовый файл                              ");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("Задание №0                                                                    ");
            Console.WriteLine("Вариант №18                                                                   ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                 ");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                             ");
            Console.WriteLine("******************************************************************************");

            int x = 3;

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                     ");
            Console.WriteLine("*******************************************************************************");

            string res = ds.SaveToFileTextData(x);


            Console.WriteLine("Файл : " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}