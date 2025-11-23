using System;
using System.IO;
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

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }


            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (int x = startValue; x <= stopValue; x++)
                {

                    if (Math.Abs(2 * x - 0.5) < 0.0001)
                    {
                        throw new ArgumentException("Деление на ноль при x = " + x);
                    }

                    double y = Math.Round(5 - 3 * x + (1 + Math.Sin(x)) / (2 * x - 0.5), 2);
                    string strY = y.ToString();

                    if (x != stopValue)
                    {
                        writer.WriteLine(strY);
                    }
                    else
                    {
                        writer.Write(strY);
                    }
                }
            }

            return path;
        }
    }
}
        
        
        
        
        
        
  