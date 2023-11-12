using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint4.Task7.V22.Lib;
namespace Tyuiu.MorozAD.Sprint4.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 5;
            int col = 3;
            int[,] mtrx = new int[rows, col];
            string str = "695324951753684";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, col, str);
            int wait = 9216;

            Assert.AreEqual(wait, res);
        }
    }
}
