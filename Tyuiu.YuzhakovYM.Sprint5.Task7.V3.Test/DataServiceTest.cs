using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint5.Task7.V3.Lib;
using System.IO;

namespace Tyuiu.YuzhakovYM.Sprint5.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\iLLusion\source\repos\Tyuiu.YuzhakovYM.Sprint5\Tyuiu.YuzhakovYM.Sprint5.Task7.V3\bin\Debug\InPutDataFileTask7V3.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
