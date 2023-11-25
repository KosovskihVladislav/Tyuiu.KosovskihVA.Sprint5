using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KosovskihVA.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            string[] strNumbs = File.ReadAllLines(path);
            double x = 0, y = 0;
            foreach (string number in strNumbs)
                if (number.Contains(','))
                {
                    if (double.Parse(number) < 0)
                    {
                        x += double.Parse(number);
                    }
                    else if (double.Parse(number) > 0)
                    {
                        y += double.Parse(number);
                    }
                }
            return Math.Round(x - y, 3);
        }
    }
}
