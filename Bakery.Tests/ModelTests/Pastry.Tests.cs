using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]

    public class PastryTests
    {
    [TestMethod]
        public void PastryPrice_ShowCostFor1Pastry_1()
        {
        Assert.AreEqual(2, Pastry.PastryCost(1));

        }
    [TestMethod]
        public void PastryPrice_ShowCostForThreePastry_3()
        {
        Assert.AreEqual(100, Pastry.PastryCost(3));

        }
    }
} 