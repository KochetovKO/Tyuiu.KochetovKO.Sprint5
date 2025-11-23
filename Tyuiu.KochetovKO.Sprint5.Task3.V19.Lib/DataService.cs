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

            string path = Path.ChangeExtension(Path.GetTempFileName(), ".csv");
            
            double y;
           
            y = (2 * x * x - 1) / Math.Sqrt(x * x - 2);

            y = Math.Round(y, 2);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}
