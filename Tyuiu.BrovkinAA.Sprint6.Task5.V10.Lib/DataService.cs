using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BrovkinAA.Sprint6.Task5.V10.Lib
{
    public class DataService : ISprint6Task5V10
    {
        public double[] LoadFromDataFile(string path)
        {
            int len = 0;

            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len += line.Split(' ').Length;
                }
            }

            double[] data = new double[len];

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int arrIndex = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim().Replace('.', ',');
                    string[] splitLine = line.Split(" ");
                    for (int i = 0; i < splitLine.Length; i++)
                    {
                        data[arrIndex++] = Convert.ToDouble(splitLine[i]);
                    }
                }
            }

            data = data.Where(x => x != 0).ToArray();

            return data;
        }
    }
}
