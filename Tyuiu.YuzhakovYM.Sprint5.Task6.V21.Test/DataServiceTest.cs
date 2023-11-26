using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YuzhakovYM.Sprint5.Task6.V21.Lib;
using System.IO;

namespace Tyuiu.YuzhakovYM.Sprint5.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\iLLusion\source\repos\Tyuiu.YuzhakovYM.Sprint5\Tyuiu.YuzhakovYM.Sprint5.Task6.V21\bin\Debug\InPutDataFileTask6V21.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\iLLusion\source\repos\Tyuiu.YuzhakovYM.Sprint5\Tyuiu.YuzhakovYM.Sprint5.Task6.V21\bin\Debug\InPutDataFileTask6V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
