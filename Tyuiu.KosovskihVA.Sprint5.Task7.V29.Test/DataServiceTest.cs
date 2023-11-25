using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KosovskihVA.Sprint5.Task7.V29.Lib;

namespace Tyuiu.KosovskihVA.Sprint5.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService service = new DataService();
        private static readonly string InputPath = @"C:\DataSprint5\InPutDataFileTask7V29.txt";

        [TestMethod]
        public void FileExsistenceTest()
        {
            FileInfo fileInfoInput = new FileInfo(InputPath);
            FileInfo fileInfoOutput = new FileInfo(service.LoadDataAndSave(InputPath));
            Assert.IsTrue(fileInfoInput.Exists);
            Assert.IsTrue(fileInfoOutput.Exists);
        }
    }
}
