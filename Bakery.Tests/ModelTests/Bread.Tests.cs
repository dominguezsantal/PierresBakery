using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    //[TestMethod]
    //public void GetBread_CreateInstanceOfBread_Bread()
    //{
        //Bread newBread = new Bread(0, 0);
        //Assert.AreEqual(typeof(Bread), newBread.GetType());
    //}
    [TestMethod]
    public void BreadCost_ShowCostforOneLoaf_1()
    {
      Assert.AreEqual(5, Bread.BreadCost(1));
    }
  }
}