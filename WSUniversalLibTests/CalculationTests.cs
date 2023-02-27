using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void GetQuantityForProductTest_NonExistentProductType()
        {
            //arrange
            int productType = 3;
            int materialType = 1;
            int count = 15;
            int width = 20;
            int lenght = 45;
            int expected = 114146;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}