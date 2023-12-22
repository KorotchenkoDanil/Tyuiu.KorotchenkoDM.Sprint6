using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task2.V3.Lib
{
    public class DataService : ISprint6Task2V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue + 1);
            valueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.2 == 0)
                {
                    valueArray[count] = 0;
                    continue;
                }
                double y = Math.Round(Math.Sin(x) / (x + 1.2) + Math.Cos(x) * 7 * x - 2, 2);
                valueArray[count] = y;
                count++;

            }
            return valueArray;
        }
    }
}
