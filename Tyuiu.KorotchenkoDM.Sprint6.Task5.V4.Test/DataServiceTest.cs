using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KorotchenkoDM.Sprint6.Task5.V4.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedLoadFromDataFile()
        {
            string path = @"C:\Users\ДАНИЛ\source\repos\Tyuiu.KorotchenkoDM.Sprint6\Tyuiu.KorotchenkoDM.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
