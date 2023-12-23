using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KorotchenkoDM.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            int ColNum = columns - 1;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, ColNum] < 2)
                    matrix[i, ColNum] = 2;
            }
            return matrix;
        }
    }
}
