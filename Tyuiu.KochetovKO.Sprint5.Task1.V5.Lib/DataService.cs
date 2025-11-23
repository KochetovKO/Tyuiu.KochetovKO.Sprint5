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
            string path = "";

            try
            {
                // Пробуем разные расположения для файла
                path = GetSafeFilePath();

                Console.WriteLine($"Пытаемся сохранить файл по пути: {path}");

                // Очищаем файл если существует
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
                {
                    for (int x = startValue; x <= stopValue; x++)
                    {
                        double y = CalculateFunction(x);
                        string strY = y.ToString("F2");

                        if (x != stopValue)
                            writer.WriteLine(strY);
                        else
                            writer.Write(strY);
                    }
                }

                Console.WriteLine($"Файл успешно создан: {path}");
                return path;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Ошибка доступа: {ex.Message}");
                // Пробуем альтернативное расположение
                return SaveToAlternativeLocation(startValue, stopValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Общая ошибка: {ex.Message}");
                return SaveToAlternativeLocation(startValue, stopValue);
            }
        }

        private string GetSafeFilePath()
        {
            // Пробуем разные расположения в порядке приоритета
            string[] possiblePaths = {
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OutPutFileTask1.txt"),
                Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt"),
                Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask1.txt"),
                "OutPutFileTask1.txt" // Просто в текущей рабочей директории
            };

            foreach (string path in possiblePaths)
            {
                string directory = Path.GetDirectoryName(path);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    try
                    {
                        Directory.CreateDirectory(directory);
                    }
                    catch
                    {
                        continue; // Пробуем следующий путь
                    }
                }

                // Проверяем возможность записи
                if (CanWriteToPath(path))
                    return path;
            }

            throw new InvalidOperationException("Не удалось найти доступное для записи расположение");
        }

        private bool CanWriteToPath(string path)
        {
            try
            {
                using (var fs = File.Create(Path.Combine(Path.GetDirectoryName(path),
                       Path.GetRandomFileName()), 1, FileOptions.DeleteOnClose))
                { }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string SaveToAlternativeLocation(int startValue, int stopValue)
        {
            // Используем временную директорию, которая всегда доступна
            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask1.txt");

            Console.WriteLine($"Используем временную директорию: {path}");

            using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double y = CalculateFunction(x);
                    string strY = y.ToString("F2");

                    if (x != stopValue)
                        writer.WriteLine(strY);
                    else
                        writer.Write(strY);
                }
            }

            return path;
        }

        private double CalculateFunction(int x)
        {
            // Проверка деления на ноль
            double denominator = 2 * x - 0.5;

            if (Math.Abs(denominator) < 0.0001)
            {
                Console.WriteLine($"Внимание: деление на ноль при x = {x}, возвращаем 0");
                return 0;
            }

            // Вычисление функции F(x) = 5 - 3x + (1 + Math.Sin(x)) / (2x - 0.5)
            double result = 5 - 3 * x + (1 + Math.Sin(x)) / denominator;
            return Math.Round(result, 2);
        }

        // Метод для получения значений функции без сохранения в файл
        public string GetFunctionTable(int startValue, int stopValue)
        {
            StringBuilder table = new StringBuilder();
            table.AppendLine("Таблица значений функции F(x) = 5 - 3x + (1 + sin(x))/(2x - 0.5)");
            table.AppendLine("Диапазон: [" + startValue + "; " + stopValue + "]");
            table.AppendLine(new string('=', 40));
            table.AppendLine("   x   |   f(x)   ");
            table.AppendLine(new string('-', 40));

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = CalculateFunction(x);
                table.AppendLine($"  {x,4} | {y,8:F2}");
            }

            table.AppendLine(new string('=', 40));
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
    }
}