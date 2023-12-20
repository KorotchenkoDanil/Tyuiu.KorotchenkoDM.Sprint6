using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KorotchenkoDM.Sprint6.TaskReview.V10.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int c, int k, int l)
        {            
            int minValue = int.MaxValue;
            for (int i = k; i <= l; i++)
            {
                if ((i % 2 == 0) && (array[i, c] < minValue))
                    minValue = array[i, c];
            }
            return minValue;
        }
    }
}
