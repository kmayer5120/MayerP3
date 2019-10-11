using Microsoft.VisualStudio.TestTools.UnitTesting;
using MayerP3.Models;

namespace UnitTestMayerP3
{
    [TestClass]
    public class InvestmentCalcTest
    {
        [TestMethod]
        public void TestCalcMethodInvestmentCalc1()
        {
            InvestmentCalc inv = new InvestmentCalc(5000.0, 10, 5, 12);
            double expected = 8235.05;
            double actual = inv.FutureValue;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalcMethodInvestmentCalc2()
        {
            InvestmentCalc inv = new InvestmentCalc(12000.0, 30, 40, 2);
            double expected = 676170172.24;
            double actual = inv.FutureValue;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalcMethodInvestmentCalc3()
        {
            InvestmentCalc inv = new InvestmentCalc(2000000.0, 5, 100, 2);
            double expected = 115330078.13;
            double actual = inv.FutureValue;
            Assert.AreEqual(expected, actual);
        }
    }
}
