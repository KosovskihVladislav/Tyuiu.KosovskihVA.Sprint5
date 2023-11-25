using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.KosovskihVA.Sprint5.Task6.V7.Lib;

namespace Tyuiu.KosovskihVA.Sprint5.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task6                                                           *");
            Console.WriteLine("*Вариант #07                                                              *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            // Место решения задания
            DataService service1 = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V7.txt";
            Console.WriteLine("File path: " + path);
            Console.WriteLine("data is: ");
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Result: ");
            Console.WriteLine(service1.LoadFromDataFile(path));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
