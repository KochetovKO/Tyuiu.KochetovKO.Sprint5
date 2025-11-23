using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KochetovKO.Sprint5.Task3.V19.Lib
{
    public class DataService : ISprint5Task3V19
    {
        public string SaveToFileTextData(int x)
        {

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo FileInfo = new FileInfo(path);
            bool fileExists = FileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y = (2 * Math.Pow(x, 2) - 1) / Math.Sqrt(Math.Pow(x, 2) - 2);
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File
                    .Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }
            return path;
        }
    }
}