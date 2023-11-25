using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KosovskihVA.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            int y = 0;
            foreach (char c in content)
            {
                if (c == Char.ToLower(c))
                {
                    y++;
                }
            }
            return y;
        }
    }
}
