using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BrovkinAA.Sprint6.Task4.V18.Lib
{
    public class DataService : ISprint6Task4V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                int temp = startValue;
                startValue = stopValue;
                stopValue = temp;
            }

            double[] results = new double[Math.Abs(stopValue - startValue) + 1];

            for (int i = 0; i < results.Length; i++)
            {
                if (double.IsNaN(Math.Cos(startValue) + startValue) || double.IsInfinity(Math.Cos(startValue) + startValue))
                {
                    results[i] = 0;
                    continue;
                }

                results[i] = (2.0 * startValue - 3.0) / (Math.Cos(startValue) + startValue) + 5.0;
                results[i] = Math.Round(results[i], 2);

                startValue++;
            }

            return results;
        }
    }
}
