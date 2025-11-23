using System.IO;
using Tyuiu.KochetovKO.Sprint5.Task2.V23.Lib;
namespace Tyuiu.KochetovKO.Sprint5.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"C:\Users\yapre\source\repos\Tyuiu.KochetovKO.Sprint5\Tyuiu.KochetovKO.Sprint5.Task2.V23\bin\Debug\net8.0\OutPutFileTask2.csv";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(true, fileExists);

        }
    }
}
