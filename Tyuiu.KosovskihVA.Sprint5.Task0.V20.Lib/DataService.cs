using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KosovskihVA.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double x1 = Math.Round(2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x, 3);
            File.WriteAllText(path, x1.ToString());
            return path;
        }
    }
}
