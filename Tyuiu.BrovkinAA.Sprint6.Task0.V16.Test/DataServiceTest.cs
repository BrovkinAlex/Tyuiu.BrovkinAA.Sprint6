using Tyuiu.BrovkinAA.Sprint6.Task0.V16;
using Tyuiu.BrovkinAA.Sprint6.Task0.V16.Lib;
namespace Tyuiu.BrovkinAA.Sprint6.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(2);
            double wait = 2.25;

            Assert.AreEqual(wait, result);
        }
    }
}