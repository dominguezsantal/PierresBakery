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
      public void BreadCost_ShowCostForThreeLoavesOfBread_3()
      {
        Assert.AreEqual(10, Bread.BreadCost(3));
      }
      
      [TestMethod]
      public void BreadCost_ShowCostForFiveLoavesOfBread_5()
      {
        Assert.AreEqual(20, Bread.BreadCost(5));
      }
  }
}