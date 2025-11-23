using System;
using System.IO;
using System.Text;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KochetovKO.Sprint5.Task1.V5.Lib
{
    public class DataService : ISprint5Task1V5
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask1.txt");

            // Создаем директорию если не существует
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Очищаем файл если существует
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            StringBuilder fileContent = new StringBuilder();

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = CalculateFunction(x);
                string strY = FormatNumber(y);

                // Добавляем в StringBuilder для файла
                if (x != stopValue)
                {
                    fileContent.AppendLine(strY);
                }
                else
                {
                    fileContent.Append(strY);
                }
            }

            // Записываем все содержимое одним вызовом
            File.WriteAllText(path, fileContent.ToString(), Encoding.UTF8);

            return path;
        }

        private double CalculateFunction(int x)
        {
            // Проверка деления на ноль
            double denominator = 2 * x - 0.5;

            if (Math.Abs(denominator) < 0.0001)
            {
                return 0;
            }

            // Вычисление функции F(x) = 5 - 3x + (1 + Math.Sin(x)) / (2x - 0.5)
            double result = 5 - 3 * x + (1 + Math.Sin(x)) / denominator;
            return Math.Round(result, 2);
        }

        // Метод для форматирования числа согласно ожидаемому формату
        private string FormatNumber(double number)
        {
            // Округляем до 2 знаков после запятой
            double rounded = Math.Round(number, 2);

            // Если число целое - возвращаем без десятичной части
            if (Math.Abs(rounded - Math.Round(rounded)) < 0.001)
            {
                return Math.Round(rounded).ToString();
            }
            else
            {
                // Используем CultureInfo.InvariantCulture чтобы точка была разделителем
                return rounded.ToString("0.00", CultureInfo.InvariantCulture)
                             .Replace(".", ","); // Заменяем точку на запятую
            }
        }

        // Метод для получения таблицы значений
        public string GetFunctionTable(int startValue, int stopValue)
        {
            StringBuilder table = new StringBuilder();
            table.AppendLine("Таблица значений функции F(x) = 5 - 3x + (1 + sin(x))/(2x - 0.5)");
            table.AppendLine("Диапазон: [" + startValue + "; " + stopValue + "]");
            table.AppendLine(new string('=', 45));
            table.AppendLine("   x   |   f(x)   ");
            table.AppendLine(new string('-', 45));

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = CalculateFunction(x);
                string formattedY = FormatNumber(y);
                table.AppendLine($"  {x,4} | {formattedY,8}");
            }

            table.AppendLine(new string('=', 45));
            return table.ToString();
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

        // Метод для получения результата в том же формате, что ожидается
        public string GetExpectedOutput(int startValue, int stopValue)
        {
            StringBuilder result = new StringBuilder();

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = CalculateFunction(x);
                string strY = FormatNumber(y);

                if (x != stopValue)
                {
                    result.AppendLine(strY);
                }
                else
                {
                    result.Append(strY);
                }
            }

            return result.ToString();
        }
    }
}