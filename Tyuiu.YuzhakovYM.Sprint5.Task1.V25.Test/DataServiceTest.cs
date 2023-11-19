using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.YuzhakovYM.Sprint5.Task1.V25.Lib;

namespace Tyuiu.YuzhakovYM.Sprint5.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\iLLusion\source\repos\Tyuiu.YuzhakovYM.Sprint5\Tyuiu.YuzhakovYM.Sprint5.Task1.V25\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
