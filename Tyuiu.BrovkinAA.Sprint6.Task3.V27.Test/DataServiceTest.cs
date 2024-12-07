using Tyuiu.BrovkinAA.Sprint6.Task3.V27.Lib;
namespace Tyuiu.BrovkinAA.Sprint6.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] nums = { { 0, 0, 0, 5 }, { 0, 0, 0, 1 }, { 1, 2, 3, 4 } };

            nums = ds.Calculate(nums);
            int[,] wait = { { 0, 0, 0, 1 }, { 0, 0, 0, 4 }, { 1, 2, 3, 5 } };

            CollectionAssert.AreEqual(wait, nums);
        }
    }
}
