using Tyuiu.BrovkinAA.Sprint6.Task4.V18.Lib;
namespace Tyuiu.BrovkinAA.Sprint6.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double[] values = ds.GetMassFunction(-1, 1);
            double[] wait = { 15.88, 2, 4.35 };

            CollectionAssert.AreEqual(wait, values);
        }
    }
}
