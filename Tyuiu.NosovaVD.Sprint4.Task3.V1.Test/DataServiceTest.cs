﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint4.Task3.V1.Lib;
namespace Tyuiu.NosovaVD.Sprint4.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 3, 4, 3, 4, 1},
                                        { 8, 1, 6, 6, 9 },
                                        { 9, 8, 5, 1, 3 },
                                        { 1, 8, 7, 1, 2 },
                                        { 9, 9, 7, 5, 6 }};
            int res = ds.Calculate(array);
            int wait = 21;
            Assert.AreEqual(wait, res);            
        }
    }
}
