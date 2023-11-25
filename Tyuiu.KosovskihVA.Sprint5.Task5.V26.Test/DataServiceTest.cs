using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint5.Task5.V26.Lib;
using System.IO;

namespace Tyuiu.KosovskihVA.Sprint5.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private static readonly string path = @"C:\DataSprint5\InPutDataFileTask5V26.txt";
        [TestMethod]
        public void TestMethod1()
        {
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}
