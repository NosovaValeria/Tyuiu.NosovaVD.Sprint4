using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint4.Task5.V22.Lib;
namespace Tyuiu.NosovaVD.Sprint4.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { -4, 3, -7, 5, 8},
                                        { 1, 4, -2, 0, 5 },
                                        { -4, 4, 6, 4, -1 },
                                        { -5, 8, 4, -6, 5 },
                                        { 3, 8, 1, 4, 7 }};
            int res = ds.Calculate(matrix);
            int wait = 7;
            Assert.AreEqual(wait, res);
        }
    }
}
