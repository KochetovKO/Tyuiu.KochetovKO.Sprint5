
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KochetovKO.Sprint5.Task1.V5.Lib
{
    public class DataService : ISprint5Task1V5
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        { 
            string path = Path.ChangeExtension(Path.GetTempFileName(), ".csv");

            FileInfo fileinfo = new FileInfo(path);
            bool FileExists = fileinfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(5 - 3 * x + (1 + Math.Sin(x)) / (2 * x - 0.5), 2);
                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);

                }
                else
                {
                    File.AppendAllText(path, strY);
                }
                
            
            
            
            }
            
            
            
            return path;
        
        
        
        
        
        
        
        }
    }
}
