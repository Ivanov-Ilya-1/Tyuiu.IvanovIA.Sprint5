using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovIA.Sprint5.Task6.V4.Lib
{
    public class DataService : ISprint5Task6V4
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);

            MatchCollection matches = Regex.Matches(str, "[А-ЯЁ]");

            return matches.Count;
        }
    }
}
