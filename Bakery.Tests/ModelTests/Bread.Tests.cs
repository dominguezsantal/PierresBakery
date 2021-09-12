using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
 
    [TestMethod]
    public void BreadCost_ShowCostforOneLoaf_1()
    {
      Assert.AreEqual(5, Bread.BreadCost(1));
    }

    [TestMethod]
      public void BreadPrice_ShowPriceForThreeLoavesOfBread_3()
      {
        Assert.AreEqual(25, Bread.BreadPrice(3));
      }
  }
}