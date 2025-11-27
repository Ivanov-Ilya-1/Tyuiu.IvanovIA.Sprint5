using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovIA.Sprint5.Task4.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            NumberFormatInfo info = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX, info);
            double res = (Math.Pow(x,3) + Math.Sin(x)) * Math.Cos(x);
            return Math.Round(res, 3);
        }
    }
}
