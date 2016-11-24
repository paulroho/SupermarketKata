using System.Linq;
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
            var products = table.CreateSet<ProductInfo>()
                .Select(pi => new Product(pi.Name, pi.Name.GetEANFromProductName())
                {
                    UnitPrice = pi.UnitPrice,
                    TaxRate = pi.TaxRate
                });
                

            _driver.AddProducts(products);
        }

        private class ProductInfo
        {
            public string Name { get; set; }
            public decimal UnitPrice { get; set; }
            public int TaxRate { get; set; }
        }
    }
}