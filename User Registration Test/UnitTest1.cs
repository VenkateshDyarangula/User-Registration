using Microsoft.VisualStudio.TestTools.UnitTesting;
using Valid_Last;

namespace UC2_ValidLastTest
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();
        [TestMethod]
        public void Given_First_Name()
        {
            bool result = pattern.isValidFirstName("Venky");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Given_Last_Name()
        {
            bool result = pattern.isValidLastName("Dyarangula");
            Assert.AreEqual(true, result);
        }
    }
}
