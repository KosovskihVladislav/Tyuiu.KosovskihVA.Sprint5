using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KosovskihVA.Sprint5.Task1.V29.Lib;

namespace Tyuiu.KosovskihVA.Sprint5.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Bebra\source\repos\Tyuiu.KosovskihVA.Sprint5\Tyuiu.KosovskihVA.Sprint5.Task1.V29\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}
