using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supermarket.Model.Checkout;
using Supermarket.Model.Core;

namespace Supermarket.Tests
{
    [TestClass]
    public class CashRegisterGuidingTests
    {
        [TestMethod]
        public void Feature_CheckingOutItemsWithSingleTax()
        {
            ICashRegister register = new CashRegister();

            var repo = new ProductRepository();
            var milkEAN = EAN.NewEAN("817312345");
            var milk = new Product {Name = "1l milk", Number = milkEAN, UnitPrice = 0.79M, TaxRate = 20};
            repo.Add(milk);

            // Act
            register.Scan(milkEAN);
            var receipt = register.CreateReceipt();

            Assert.AreEqual(1, receipt.Bookings.Count);
            Assert.AreEqual("1l milk", receipt.Bookings[0].Text);
            Assert.AreEqual(0.79M, receipt.Bookings[0].Price);

            Assert.AreEqual(1, receipt.TaxLines.Count);
            Assert.AreEqual(20, receipt.TaxLines[0].Rate);
            Assert.AreEqual(0.16M, receipt.TaxLines[0].Amount);

            Assert.AreEqual(0.79M, receipt.Total);
        }
    }
}
