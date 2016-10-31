using Supermarket.Model.Core;
using Supermarket.Specs.Tools;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Supermarket.Specs.Bindings
{
    [Binding]
    public class CommonBindings
    {
        private readonly CashDeskSpecsDriver _driver;

        public CommonBindings(CashDeskSpecsDriver driver)
        {
            _driver = driver;
        }

        [Given(@"we have the following products in stock:")]
        public void GivenWeHaveTheFollowingProductsInStock(Table table)
        {
            table.MapValue("Unit Price", c => c.TrimEnd('€'));
            table.MapValue("Tax Rate", c => c.TrimEnd('%'));
            var products = table.CreateSet<Product>().ForEach(p => p.Number = p.GetEANFromHash());

            _driver.AddProducts(products);
        }
    }
}