using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.KosovskihVA.Sprint5.Task2.V8.Lib;

namespace Tyuiu.KosovskihVA.Sprint5.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task2                                                           *");
            Console.WriteLine("*Вариант #8                                                               *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            // Место решения задания
            DataService service1 = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = { { -9, 4, -6 }, { 3, 9, 9 }, { -6, 7, 4 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0, count = 0; j < 3; j++, count++)
                {
                    if (count != 2)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\n");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string path = service1.SaveToFileTextData(matrix);
            Console.WriteLine("File is written                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
