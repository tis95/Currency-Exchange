using System;
using System.ComponentModel;
using Currency_Exchange;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestInvalidOldCoin_shouldThrow()
        {
            Assert.ThrowsException<NullReferenceException>(() => RatesAPI.GetRateFromAPI("JJJ", "ILS"));
        }
        [TestMethod]
        public void TestInvalidNewCoin_shouldThrow()
        {
            Assert.ThrowsException<NullReferenceException>(() => RatesAPI.GetRateFromAPI("ILS", "JJJ"));
        }
        [TestMethod]
        public void TestRateSameCoin_shouldReturn1()
        {
            Assert.AreEqual(1, RatesAPI.GetRateFromAPI("NIS", "NIS"));
        }
        [TestMethod]
        public void TestRateHigher_shouldReturnMoreThan1()
        {
            Assert.IsTrue(RatesAPI.GetRateFromAPI("USD", "NIS") > 1);
        }
        [TestMethod]
        public void TestRateLower_shouldReturnLessThan1()
        {
            Assert.IsTrue(RatesAPI.GetRateFromAPI("NIS", "USD") < 1);
        }
    }
}