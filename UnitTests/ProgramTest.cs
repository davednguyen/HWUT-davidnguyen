using HWUT;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void Program_Constructor_Default_Should_Pass()
        {
            var result = new Program();
            Assert.IsNotNull(result);
        }       
    }
}
