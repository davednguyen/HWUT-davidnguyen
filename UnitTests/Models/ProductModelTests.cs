using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_ID_Default_Should_Pass()
        {
            var result = new ProductModel();
            result.Id = "12345";
            Assert.AreEqual("12345", result.Id);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            var result = new ProductModel();
            result.Maker = "SpaceX";
            Assert.AreEqual("SpaceX", result.Maker);
        }
    }
}
