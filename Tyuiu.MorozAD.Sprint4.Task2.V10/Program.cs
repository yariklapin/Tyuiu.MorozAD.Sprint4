using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint4.Task2.V10.Lib;

namespace Tyuiu.MorozAD.Sprint4.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                            *");
            Console.WriteLine("******************************************************************************");

            int len;
            Console.WriteLine("Enter how much values");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                numsArray[i] = rnd.Next(1,6);
            }

            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]+"\t");
            }

            Console.WriteLine("* Произведение не четных чисел                                               *");

            p = ds.Calculate(numsArray);

            Console.WriteLine(p);
            Console.ReadKey();



        }
    }
}
