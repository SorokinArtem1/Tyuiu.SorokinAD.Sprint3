using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinAD.Sprint3.Task0.V22.Lib;

namespace Tyuiu.SorokinAD.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 6;
            int startValue = 1;
            int stopValue = 2;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 48.009;

            Assert.AreEqual(wait, res);
        }
    }
}
