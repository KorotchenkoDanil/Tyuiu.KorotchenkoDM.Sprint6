using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorotchenkoDM.Sprint6.Task4.V28.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -11.223;
            valueWaitArray[1] = -8.65;
            valueWaitArray[2] = -4.758;
            valueWaitArray[3] = -6.472;
            valueWaitArray[4] = -2.977;
            valueWaitArray[5] = 1.0;
            valueWaitArray[6] = 1.824;
            valueWaitArray[7] = 3.548;
            valueWaitArray[8] = 6.986;
            valueWaitArray[9] = 7.738;
            valueWaitArray[10] = 9.033;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
