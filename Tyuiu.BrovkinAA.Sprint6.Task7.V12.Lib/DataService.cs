using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BrovkinAA.Sprint6.Task7.V12.Lib
{
    public class DataService : ISprint6Task7V12
    {
        public int[,] GetMatrix(string path)
        {
            int rows = 0;
            int cols = 0;
            using(StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (line.Length > 0)
                        rows++;
                    if (rows == 1)
                        cols = line.Split(';').Length;
                }
            }

            int[,] matrix = new int[rows, cols];
           
            using (StreamReader sr = new StreamReader(path))
            {
                string[] line = new string[cols];
                for (int i = 0; i < rows; i++)
                {
                    line = sr.ReadLine().Split(';');
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = Convert.ToInt32(line[j]);
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, 8] != 10)
                    matrix[i, 8] = 0;
            }

            return matrix;
        }
    }
}
