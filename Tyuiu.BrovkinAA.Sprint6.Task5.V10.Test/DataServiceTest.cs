using Tyuiu.BrovkinAA.Sprint6.Task5.V10.Lib;
namespace Tyuiu.BrovkinAA.Sprint6.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoad()
        {
            DataService ds = new DataService();
            double[] nums = ds.LoadFromDataFile(@"D:\Documents\VS22\source\repos\Tyuiu.BrovkinAA.Sprint6\Tyuiu.BrovkinAA.Sprint6.Task5.V10\bin\Debug\net8.0-windows\govno.txt");
            double[] wait = { 7.21, 9.11, 8.68, 2.37 };
            
            CollectionAssert.AreEqual(wait, nums);
        }
    }
}
