using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosovskihVA.Sprint5.Task3.V25.Lib;
using System.IO;

namespace Tyuiu.KosovskihVA.Sprint5.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Косовских В. А. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #Task3                                                           *");
            Console.WriteLine("*Вариант #25                                                              *");
            Console.WriteLine("*Выполнил: Косовских Владислав Алексеевич | ПКТб 23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            // Место решения задания
            DataService service1 = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = 3                                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string path = service1.SaveToFileTextData(3);
            Console.WriteLine("File is written                                                           *");
            Console.WriteLine("***************************************************************************");
            double text;
            using (var reader = new BinaryReader(File.Open(path, FileMode.Open), Encoding.UTF8))
            {
                text = reader.ReadDouble();
            }
            Console.WriteLine(text.ToString());
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
