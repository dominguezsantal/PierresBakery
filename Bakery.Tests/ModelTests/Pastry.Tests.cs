using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]

    public class PastryTests
    {
    [TestMethod]
        public void GetBread_CreatesInstanceOfPastry_Pastry()
        {
            Pastry newPastry = new Pastry(0, 0);
            Assert.AreEqual(typeof(Pastry), regPastry.GetType());
        }
    }
} 