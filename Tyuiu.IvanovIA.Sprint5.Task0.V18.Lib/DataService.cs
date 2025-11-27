using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovIA.Sprint5.Task0.V18.Lib
{
    public class DataService : ISprint5Task0V18
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutputFileTask0.txt" });
            double y = x / (Math.Sqrt(Math.Pow(x,2) + x));
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
