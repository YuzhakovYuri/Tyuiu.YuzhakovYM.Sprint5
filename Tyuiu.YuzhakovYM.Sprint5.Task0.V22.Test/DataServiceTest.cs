using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.YuzhakovYM.Sprint5.Task0.V22.Lib;

namespace Tyuiu.YuzhakovYM.Sprint5.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\iLLusion\source\repos\Tyuiu.YuzhakovYM.Sprint5\Tyuiu.YuzhakovYM.Sprint5.Task0.V22\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
