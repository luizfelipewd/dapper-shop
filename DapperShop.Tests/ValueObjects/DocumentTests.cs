using DapperShop.Domain.StoreContext.Entities;
using DapperShop.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dappershop.tests
{
    [TestClass]
    public class DocumentTests
    {
        private Document validDocument;
        private Document invalidDocument;
        public DocumentTests()
        {
            validDocument = new Document("94351935014");
            invalidDocument = new Document("12345678911");
        }

        [TestMethod]
        public void ShouldReturnFalseWhenDocumentIsInvalid()
        {
            Assert.AreEqual(invalidDocument.IsValid, false);
        }

        [TestMethod]
        public void ShouldReturnTrueWhenDocumentIsValid()
        {
            Assert.AreEqual(validDocument.IsValid, true);
        }
    }
}
