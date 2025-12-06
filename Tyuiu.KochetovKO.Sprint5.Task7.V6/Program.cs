using System.Diagnostics;
using Tyuiu.KochetovKO.Sprint5.Task7.V6.Lib;
namespace Tyuiu.KochetovKo.Sprint5.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V6.txt";
            string pathSaveFile = @"C:\DataSprint5\InPutDataFileTask7V6.txt";
            Console.Title = "Спринт #5 | Выполнил: Кочетов Кирилл Олегович | ИсПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                            *");
            Console.WriteLine("* Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");


            Console.WriteLine(" ***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);

            Console.ReadKey();


            Console.ReadKey();
        }
    }
}
