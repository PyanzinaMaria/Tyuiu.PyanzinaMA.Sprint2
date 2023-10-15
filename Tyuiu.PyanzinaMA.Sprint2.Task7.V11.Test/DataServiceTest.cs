using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PyanzinaMA.Sprint2.Task7.V11.Lib;

namespace Tyuiu.PyanzinaMA.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = -0.3;
            double y = 0.7;

            Assert.AreEqual(false, ds.CheckDotInShadedArea(x, y));
        }
    }
}
