using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint4.Task7.V22.Lib;

namespace Tyuiu.MorozAD.Sprint4.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int col = 3;
            int[,] mtrx = new int[rows, col];
            string str = "695324951753684";

            DataService ds = new DataService();

            int index = 0;

            Console.WriteLine("\nМассив");
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Результат:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("произведение четных чисел : " + ds.Calculate(rows,col,str));
            Console.ReadKey();
        }
    }
}
