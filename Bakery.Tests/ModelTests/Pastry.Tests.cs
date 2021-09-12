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
        Assert.AreEqual(5, Pastry.PastryCost(3));

        }

     [TestMethod]
      public void SetObj_SetObj_Pastry()
      {
        int quant = 0;
            int cost = 0;
            Pastry newPastry = new Pastry(quant, cost);

            int updatedQuant = 2;
            newBread.Quant = updatedQuant;
            int finalQu = newPastry.Quant;
            int updatedCost = 2;
            newPastry.Cost = updatedCost;
            int finalCo = newPastry.Cost;

            
            Assert.AreEqual(regQuant, finalQu);
            Assert.AreEqual(updatedCost, finalCo);
      }   
    }
} 