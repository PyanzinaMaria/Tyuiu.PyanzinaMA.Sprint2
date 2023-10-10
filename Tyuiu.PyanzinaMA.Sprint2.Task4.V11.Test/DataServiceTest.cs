using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint2.Task4.V11.Lib;

namespace Tyuiu.PyanzinaMA.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 889.463;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = -180;
            double res = ds.Calculate(x, y);
            double wait = -180.000;
            Assert.AreEqual(wait, res);
        }
    }
}