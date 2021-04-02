using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC8_Password_Rule4;

namespace UC8_Password_Rule4_Test
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
        [TestMethod]
        public void Given_Valid_Email()
        {
            bool result = pattern.isValidEmail("Venkateshdyarangula@gmail.co.in");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Given_Valid_Phone()
        {
            bool result = pattern.isValidMobileNumber("91 7989798979");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Given_Valid_Password()
        {
            bool result = pattern.isValidPassword("VenkyPassword123$");
            Assert.AreEqual(true, result);
        }
    }
}

