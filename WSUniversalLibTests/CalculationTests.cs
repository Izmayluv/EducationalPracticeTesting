using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void GetQuantityForProductTest_CorrectData()
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

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectProductType()
        {
            //arrange
            int productType = 50;
            int materialType = 1;
            int count = 15;
            int width = 20;
            int lenght = 45;
            int expected = -1;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectMaterialType()
        {
            //arrange
            int productType = 3;
            int materialType = 11;
            int count = 15;
            int width = 20;
            int lenght = 45;
            int expected = -1;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectProductAndMaterialType()
        {
            //arrange
            int productType = 50;
            int materialType = 90;
            int count = 15;
            int width = 20;
            int lenght = 45;
            int expected = -1;
            //act
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, lenght);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest_IncorectCount()
        {
            //arrange
            int productType = 3;
            int materialType = 1;
            int count = 5;
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