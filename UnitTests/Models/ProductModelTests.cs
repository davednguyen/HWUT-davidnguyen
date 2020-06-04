using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json.Serialization;
using System.Text.Json;
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
            Assert.AreEqual("12345", result.Id = "12345");
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            var result = new ProductModel();
            result.Maker = "SpaceX";
            Assert.AreEqual("SpaceX", result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass()
        {
            string expectImage = "http://img-s-msn-com.akamaized.net/tenant/amp/entityid/BBWPuIz.img?ocid=msaut1";

            var result = new ProductModel();
            result.Image = "http://img-s-msn-com.akamaized.net/tenant/amp/entityid/BBWPuIz.img?ocid=msaut1";
            
            Assert.AreEqual(expectImage, result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_URL_Default_Should_Pass()
        {
            var result = new ProductModel();

            Assert.AreEqual("https://www.tesla.com/", result.Url = "https://www.tesla.com/");
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            var result = new ProductModel();

            Assert.AreEqual("Model 3", result.Title = "Model 3");
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            string des = "322mi Range 145mph Top Speed 4.4s 0 - 60 mph";

            var result = new ProductModel();
            result.Description = "322mi Range 145mph Top Speed 4.4s 0 - 60 mph";

            Assert.AreEqual(des, result.Description);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass()
        {
            var result = new ProductModel();

            Assert.AreEqual("1", result.Sequence = "1");
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            var result = new ProductModel();

            Assert.AreEqual("test@test.info", result.Email = "test@test.info");
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            var result = new ProductModel();

            Assert.AreEqual("1", result.Logistics = "1");
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            var result = new ProductModel();
            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Get_ToString_Should_Pass()
        {
            var result = new ProductModel();
            var json = JsonSerializer.Serialize<ProductModel>(result);
            Assert.AreEqual(json, result.ToString());
        }

        [TestMethod]
        public void ProductModel_Get_ProductModel_Should_Fail()
        {
            var result = new ProductModel();
            //check email
            Assert.AreEqual("test@info.test", result.Email);
        }
    }
}
