using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BrovkinAA.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] row = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                row[i] = matrix[i, 3];
            }

            Array.Sort(row);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 3] = row[i];
            }

            return matrix;
        }
    }
}
