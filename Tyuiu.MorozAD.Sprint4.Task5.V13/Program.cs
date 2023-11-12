using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint4.Task5.V13.Lib;

namespace Tyuiu.MorozAD.Sprint4.Task5.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Введите коллво строк в массиве : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите коллво столбцов в массиве : ");
            int col = Convert.ToInt32(Console.ReadLine());


            int[,] mtrx = new int[rows, col];
            
            Console.WriteLine("******************************************************************************");

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < rows; j++)
                {
                    mtrx[i, j] = rnd.Next(-2,5);
                }

            Console.WriteLine("\nМассив");
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Результат:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("aye " + ds.Calculate(mtrx));
            Console.ReadKey();

        }
    }
}
