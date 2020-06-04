using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Services;

namespace UnitTests
{
    [TestClass]
    public class JsonFileProductServiceTest
    {
        [TestMethod]
        public void JsonFileProductService_Constructor_Default_Should_Pass()
        {
            var result = new JsonFileProductService(null);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void JsonFileProductService_GetProducts_Default_Should_Pass()
        {
            var result = new JsonFileProductService(null);
            Assert.IsNotNull(result.GetProducts());
        }

        [TestMethod]
        public void JsonFileProductService_AddRating_Default_Should_Pass()
        {
            var result = new JsonFileProductService(null);
            result.AddRating("Tesla Model 3", 5);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void JsonFileProductService_WebHostEnvironment_Default_Should_Pass()
        {
            var result = new JsonFileProductService(null);
            Assert.AreEqual(null,result.WebHostEnvironment);
        }
    }
}
