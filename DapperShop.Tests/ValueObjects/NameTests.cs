using DapperShop.Domain.StoreContext.Entities;
using DapperShop.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dappershop.tests
{
    [TestClass]
    public class NameTests
    {
        private Name validName;
        private Name invalidName;
        public NameTests()
        {
            validName = new Name("John", "Doe");
            invalidName = new Name("", "Who");
        }

        [TestMethod]
        public void ShouldReturnFalseWhenNameIsInvalid()
        {
            Assert.AreEqual(invalidName.IsValid, false);
        }

        [TestMethod]
        public void ShouldReturnTrueWhenNameIsValid()
        {
            Assert.AreEqual(validName.IsValid, true);
        }
    }
}
