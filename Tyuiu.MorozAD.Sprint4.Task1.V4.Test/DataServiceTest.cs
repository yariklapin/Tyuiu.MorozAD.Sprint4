﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MorozAD.Sprint4.Task1.V4.Lib;
namespace Tyuiu.MorozAD.Sprint4.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int[] numsArray = { 1, 2, 5, 3, 4, 7, 8, 8, 3, 9 };
            int res = ds.Calculate(numsArray);
            int wait = 2835;
            Assert.AreEqual(res, wait);
        }
    }
}
