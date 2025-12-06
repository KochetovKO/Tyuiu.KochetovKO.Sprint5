using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KochetovKO.Sprint5.Task6.V24.Lib
{
    public class DataService : ISprint5Task6V24
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] words = text.Split(' ');

            int count = 0;

            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    bool isAllDigits = true;
                    foreach (char c in word)
                    {
                        if (!char.IsDigit(c))
                        {
                            isAllDigits = false;
                            break;
                        }
                    }

                    if (isAllDigits)
                    {
                        count++;
                    }
                }
            }
            return count;

        }
    }    
}
