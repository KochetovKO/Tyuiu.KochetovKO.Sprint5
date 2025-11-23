using System.IO;
using Tyuiu.KochetovKO.Sprint5.Task1.V5.Lib;
namespace Tyuiu.KochetovKO.Sprint5.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\Users\yapre\source\repos\Tyuiu.KochetovKO.Sprint5\Tyuiu.KochetovKO.Sprint5.Task1.V5\bin\Debug\net8.0\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(true, fileExists);
        
        
        
        
        }
    }
}
