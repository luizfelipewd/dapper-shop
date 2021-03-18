using DapperShop.Domain.StoreContext.Entities;
using DapperShop.Domain.StoreContext.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dappershop.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("John", "Doe");
            var document = new Document("12345678910");
            var email = new Email("johndoe@nomail.com");
            var customer = new Customer(name, document, email, "31987654321");

            var mouse = new Product("Mouse", "Mouse gamer", "image.png", 59.99m, 5);
            var cadeira = new Product("Cadeira", "Cadeira gamer", "image.png", 839.99m, 5);
            var teclado = new Product("Teclado", "Teclado gamer", "image.png", 89.99m, 5);

            var order = new Order(customer);
            order.AddItem(new OrderItem(mouse, 5));
            order.AddItem(new OrderItem(cadeira, 5));
            order.AddItem(new OrderItem(teclado, 5));

            order.Place();

            var valid = order.IsValid;

            order.Pay();
            order.Ship();
            order.Cancel();

            Assert.AreEqual(valid, true);
        }
    }
}
