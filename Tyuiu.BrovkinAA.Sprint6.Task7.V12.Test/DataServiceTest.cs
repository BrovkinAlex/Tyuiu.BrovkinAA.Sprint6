using Tyuiu.BrovkinAA.Sprint6.Task7.V12.Lib;
namespace Tyuiu.BrovkinAA.Sprint6.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidMatrix()
        {
            DataService ds = new DataService();
            int[,] moreNums = ds.GetMatrix(@"D:\Downloads\InPutDataFileTask7V12.csv");
            int[] nums = new int[moreNums.GetUpperBound(0) + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = moreNums[i, 8];
            }

            int[] wait = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            CollectionAssert.AreEqual(wait, nums);
        }
    }
}
