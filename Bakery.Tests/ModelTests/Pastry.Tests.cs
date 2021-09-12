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
        Assert.AreEqual(0, Pastry.PastryCost(1));

        }
    }
} 