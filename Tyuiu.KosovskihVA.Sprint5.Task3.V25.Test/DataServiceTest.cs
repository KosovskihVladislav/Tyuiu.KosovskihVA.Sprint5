using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint5.Task3.V25.Lib;
using System.IO;

namespace Tyuiu.KosovskihVA.Sprint5.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Bebra\source\repos\Tyuiu.KosovskihVA.Sprint5\Tyuiu.KosovskihVA.Sprint5.Task3.V25\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}
