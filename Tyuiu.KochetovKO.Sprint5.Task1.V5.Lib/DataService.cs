using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KochetovKO.Sprint5.Task1.V5.Lib
{
    public class DataService : ISprint5Task1V5
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask1.txt");

            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            StringBuilder sb = new StringBuilder();

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = CalculateFunction(x);
                string strY = y.ToString("F2");

                sb.AppendLine($"x = {x,3} | f(x) = {strY}");

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("------------------------");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("------------------------");
            Console.WriteLine($"Результат сохранен в файл: {path}");

            return path;
        }

        private double CalculateFunction(int x)
        {
            try
            {
                double denominator = 2 * x - 0.5;

                if (Math.Abs(denominator) < 0.0001)
                {
                    Console.WriteLine($"Внимание: деление на ноль при x = {x}, возвращаем 0");
                    return 0;
                }

                double result = 5 - 3 * x + (1 + Math.Sin(x)) / denominator;
                return Math.Round(result, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при вычислении f({x}): {ex.Message}");
                return 0;
            }
        }


        public double[] GetFunctionValues(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] values = new double[count];

            for (int i = 0; i < count; i++)
            {
                int x = startValue + i;
                values[i] = CalculateFunction(x);
            }

            return values;
        }
    }
}