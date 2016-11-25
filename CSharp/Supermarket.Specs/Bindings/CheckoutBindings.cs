using System.Linq;
using Supermarket.Specs.Tools;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Supermarket.Specs.Bindings
{
    [Binding]
    public class CheckoutBindings
    {
        private readonly CashDeskSpecsDriver _driver;

        public CheckoutBindings(CashDeskSpecsDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I scan the following products at the cash desk:")]
        public void GivenIScanTheFollowingProductsAtTheCashDesk(Table table)
        {
            var productNames = table.CreateSet<ProductInfo>().Select(pi => pi.Product);
            _driver.ScanProductsByName(productNames);
        }

        [When(@"I check out")]
        public void WhenICheckOut()
        {
            var receipt = _driver.Checkout();
            _driver.Receipt = receipt;
        }

        [Then(@"the receipt contains this information:")]
        public void ThenTheReceiptContaintsThisInformation(string receiptAsString)
        {
            _driver.Receipt.ShouldBeRepresentedBy(receiptAsString);
        }

        private class ProductInfo
        {
#pragma warning disable 649
            public string Product;
#pragma warning restore 649
        }
    }

}