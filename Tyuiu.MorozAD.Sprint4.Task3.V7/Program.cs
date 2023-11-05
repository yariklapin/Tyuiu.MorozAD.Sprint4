using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint4.Task3.V7.Lib;

namespace Tyuiu.MorozAD.Sprint4.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = new int[5, 5] { { 9, 6, 9, 3, 7, },
                                          { 3, 3, 3, 8, 2, },
                                          { 2, 1, 3, 5, 2, },
                                          { 6, 2, 3, 2, 5, },
                                          { 4, 5, 6, 9, 5, } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                            *");
            Console.WriteLine("******************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Результат                                                                  *");
            Console.WriteLine("******************************************************************************");
            int res = ds.Calculate(mtrx);

            Console.WriteLine("Коллво нечетных элементов = " + res);
            Console.ReadKey();

        }
    }
}
