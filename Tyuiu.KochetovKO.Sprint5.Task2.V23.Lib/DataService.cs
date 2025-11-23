using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KochetovKO.Sprint5.Task2.V23.Lib
{
    public class DataService : ISprint5Task2V23
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            // полный путь (можно оставить просто имя файла, если так требуют)
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask2.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            // сначала меняем нечётные на 0
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            // потом записываем в файл
            for (int i = 0; i < rows; i++)
            {
                string str = "";

                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                        str += matrix[i, j] + ";";
                    else
                        str += matrix[i, j];
                }

                if (i != rows - 1)
                    File.AppendAllText(path, str + Environment.NewLine);
                else
                    File.AppendAllText(path, str);
            }

            return path;
        }
    }
}