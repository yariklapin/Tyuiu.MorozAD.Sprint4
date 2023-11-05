using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MorozAD.Sprint4.Task0.V19.Lib;

namespace Tyuiu.MorozAD.Sprint4.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            DataService ds = new DataService();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                            *");
            Console.WriteLine("******************************************************************************");

            int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("* Произведение не четных чисел                                               *");

            p = ds.GetMultOddArrEl(numsArray);

            Console.WriteLine(p);
            Console.ReadKey();
            


        }
    }
}
