using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KochetovKO.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string inputData = File.ReadAllText(path);
            StringBuilder processedData = new StringBuilder();

            foreach (char c in inputData)
            {
                if (char.IsLetter(c) && ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                {
                    processedData.Append('#');
                }
                else
                {
                    processedData.Append(c);
                }
            }

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V6.txt");

            string directory = Path.GetDirectoryName(outputPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            File.WriteAllText(outputPath, processedData.ToString());

            return processedData.ToString();




        }
    }
}
