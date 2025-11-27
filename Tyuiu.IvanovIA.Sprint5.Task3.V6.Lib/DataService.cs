using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.IvanovIA.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });
            double numerator = x;
            double denominator = Math.Sqrt(Math.Pow(x,2) + x);
            double z = numerator / denominator;
            z = Math.Round(z, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
