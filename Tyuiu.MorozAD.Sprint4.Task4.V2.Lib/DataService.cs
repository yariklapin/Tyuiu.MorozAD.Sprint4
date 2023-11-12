﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MorozAD.Sprint4.Task4.V2.Lib
{
    public class DataService : ISprint4Task4V2
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length/rows;

            int l = 0;

            for (int i = 0; i < rows; i++)
                for(int j = 0; j < columns; j++)
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                        l += matrix[i, j];
                    }
                
            
            return l;

        }
    }
}
