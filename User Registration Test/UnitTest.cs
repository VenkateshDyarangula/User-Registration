using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();
        [TestMethod]
        public void Given_First_Name_Should_Returrns_True()
        {
            bool result = pattern.isValidFirstName("Venky");
            Assert.AreEqual(true, result);
        }
    }
}
