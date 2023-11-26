using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint5.Task4.V15.Lib;
using System.IO;

namespace Tyuiu.YuzhakovYM.Sprint5.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\iLLusion\source\repos\Tyuiu.YuzhakovYM.Sprint5\Tyuiu.YuzhakovYM.Sprint5.Task4.V15\bin\Debug\InPutDataFileTask4V15.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
