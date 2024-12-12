using Tyuiu.BrovkinAA.Sprint6.Task6.V30.Lib;
namespace Tyuiu.BrovkinAA.Sprint6.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidText()
        {
            DataService ds = new DataService();
            string row = ds.CollectTextFromFile(@"D:\Downloads\InPutDataFileTask6V30.txt");
            string wait = "PAlR qdsTS zgGQ XVZeHq dwMQ";
        }
    }
}
