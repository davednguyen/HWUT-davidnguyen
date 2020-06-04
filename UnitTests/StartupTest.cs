using HWUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StartupTest
    {
        [TestMethod]
        public void Startup_Constructor_Default_Should_Pass()
        {
            var result = new Startup(null);
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void Startup_Configuration_Default_Should_Pass()
        {
            var result = new Startup(null);
            Assert.AreEqual(null, result.Configuration);
        }

        [TestMethod]
        public void Startup_Configure_Default_Should_Pass()
        {
            var result = new Startup(null);
            result.Configure(null, null);
            Assert.AreEqual(null, result);
        }
    }
}
