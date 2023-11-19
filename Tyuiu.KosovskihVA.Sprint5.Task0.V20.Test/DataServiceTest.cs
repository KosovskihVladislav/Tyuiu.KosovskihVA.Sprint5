using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint5.Task0.V20.Lib;
using System.IO;

namespace Tyuiu.KosovskihVA.Sprint5.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Bebra\source\repos\Tyuiu.KosovskihVA.Sprint5\Tyuiu.KosovskihVA.Sprint5.Task0.V20\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
            Assert.AreEqual("29,36", File.ReadAllText(path));
        }
    }
}
