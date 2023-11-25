using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.KosovskihVA.Sprint5.Task7.V29.Lib;

namespace Tyuiu.KosovskihVA.Sprint5.Task7.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task7                                                           *");
            Console.WriteLine("*Вариант #29                                                              *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            // Место решения задания
            DataService service1 = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V29.txt";
            Console.WriteLine("File path: ");
            Console.WriteLine(path);
            Console.WriteLine("data is: ");
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("File is written, path: ");
            string outputpath = service1.LoadDataAndSave(path);
            Console.WriteLine(outputpath);
            Console.WriteLine(File.ReadAllText(outputpath));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
