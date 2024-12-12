using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BrovkinAA.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string path)
        {
            string[] words;
            string resString = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    resString += line.Trim().Split(' ')[3] + " ";
                }
            }

            return resString.Trim();
        }
    }
}
