using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint4.Task2.V20.Lib;
namespace Tyuiu.NosovaVD.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 6, 6, 4, 7, 4, 5, 5, 6, 6, 4, 6, 4, 6, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 56;
            Assert.AreEqual(wait, res);
        }
    }
}
