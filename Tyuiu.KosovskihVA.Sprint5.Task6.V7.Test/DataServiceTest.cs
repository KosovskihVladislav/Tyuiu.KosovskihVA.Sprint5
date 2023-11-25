using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KosovskihVA.Sprint5.Task6.V7.Lib;

namespace Tyuiu.KosovskihVA.Sprint5.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private static readonly string path = @"C:\DataSprint5\InPutDataFileTask6V7.txt";
        [TestMethod]
        public void TestMethod1()
        {
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}
