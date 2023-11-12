using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint4.Task5.V13.Lib;

namespace Tyuiu.MorozAD.Sprint4.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { 0, 0, 0, 0, -9 },
                                            { -7, 0, 0, 0, -9 },
                                            { 0, -7, -9, 0, -5 },
                                            { -7, -5, -7, -7, 0 },
                                            { 0, 0, 0, -7, -9 } };
            int[,] res = ds.Calculate(matrix);

            int[,] wait = new int[5, 5] { { 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 },
                                          { 0, 0, 0, 0, 0 } }; ;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
    