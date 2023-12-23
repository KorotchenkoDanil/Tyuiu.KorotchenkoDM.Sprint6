using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint6.Task7.V23.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3] { { 6, 15, -9 },
                                      { 18, -8, 6 },
                                      { -5, -8, 12 } };
            int[,] res = ds.GetMatrix(mtrx);
            int[,] wait = new int[3, 3] { { 6, 15, 2 },
                                      { 18, -8, 6 },
                                      { -5, -8, 12 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
