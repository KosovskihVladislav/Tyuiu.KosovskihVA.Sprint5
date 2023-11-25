using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint5.Task4.V30.Lib;
using System.IO;

namespace Tyuiu.KosovskihVA.Sprint5.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private static readonly string path = @"C:\DataSprint5\InPutDataFileTask4V30.txt";
        [TestMethod]
        public void FileExsistenceTest()
        {
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}
