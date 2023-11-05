using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint4.Task2.V10.Lib;

namespace Tyuiu.MorozAD.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            int[] numsArray = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.Calculate(numsArray);
            int wait = 297675;
            Assert.AreEqual(res, wait);
        }
    }
}
