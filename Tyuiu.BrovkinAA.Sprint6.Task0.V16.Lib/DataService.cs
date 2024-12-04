using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BrovkinAA.Sprint6.Task0.V16.Lib
{
    public class DataService : ISprint6Task0V16
    {
        public double Calculate(int x)
        {
            double result = (1.0 + Math.Pow(x, 3)) / (double)Math.Pow(x, 2);
            return Math.Round(result, 3);
        }
    }
}
