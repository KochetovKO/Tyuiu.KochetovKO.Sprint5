using System.Diagnostics;
using Tyuiu.KochetovKO.Sprint5.Task7.V6.Lib;
namespace Tyuiu.KochetovKo.Sprint5.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Кочетов Кирилл Олегович | ИсПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #6                                                            *");
            Console.WriteLine("* Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Дан файл С:\\DataSprint5\\InPutDataFileTask7V6.txt (файл взять из архива со*");
            Console.WriteLine("*огласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопиро*");
            Console.WriteLine("*овать в неё файл) в котором есть набор символьных данных.Заменить все лат*");
            Console.WriteLine("*тинские буквы на #.Полученный результат сохранить в файл OutPutDataFileTa*");
            Console.WriteLine("*ask7V6.txt.                                                              *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string inputpath = @"C:\DataSprint5\InPutDataFileTask7V6.txt";
            DataService ds = new DataService();
            string result = ds.LoadDataAndSave(inputpath);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
