using System.Linq;
using Supermarket.Model.Checkout;
using Supermarket.Specs.Tools;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Supermarket.Specs.Bindings
{
    [Binding]
    public class CheckoutBindings
    {
        private readonly CashDeskContext _context;

        public CheckoutBindings(CashDeskContext context)
        {
            _context = context;
        }

        [Given(@"I scan the following products at the cash desk:")]
        public void GivenIScanTheFollowingProductsAtTheCashDesk(Table table)
        {
            var productNames = table.CreateSet<ProductInfo>().Select(pi => pi.Product);
            _context.ScanProductsByName(productNames);
        }

        [When(@"I check out")]
        public void WhenICheckOut()
        {
            Receipt receipt = null; // TODO: Get the receipt
            // ReSharper disable once ExpressionIsAlwaysNull
            _context.Receipt = receipt;
        }

        [Then(@"the receipt contains this information:")]
        public void ThenTheReceiptContaintsThisInformation(string receiptAsString)
        {
            _context.Receipt.ShouldBeRepresentedBy(receiptAsString);
        }
    }

    public class ProductInfo
    {
        public string Product;
    }
}