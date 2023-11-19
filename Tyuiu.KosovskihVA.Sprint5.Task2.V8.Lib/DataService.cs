using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KosovskihVA.Sprint5.Task2.V8.Lib
{
    public class DataService : ISprint5Task2V8
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.txt";
            string buffer = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int count = 0, j = 0; j < matrix.GetLength(1); j++, count++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                    else if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    if (count != 2)
                    {
                        buffer += matrix[i, j].ToString() + "\t";
                    }
                    else
                    {
                        buffer += matrix[i, j].ToString() + "\n";
                    }
                }
                File.WriteAllText(path, buffer);
            }
            return path;
        }
    }
}
