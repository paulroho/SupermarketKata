using Supermarket.Model.Core;
using Supermarket.Specs.Tools;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Supermarket.Specs.Bindings
{
    [Binding]
    public class CommonBindings
    {
        private readonly CashDeskSpecsContext _context;

        public CommonBindings(CashDeskSpecsContext context)
        {
            _context = context;
        }

        [Given(@"we have the following products in stock:")]
        public void GivenWeHaveTheFollowingProductsInStock(Table table)
        {
            table.MapValue("Unit Price", c => c.TrimEnd('€'));
            table.MapValue("VAT Rate", c => c.TrimEnd('%'));
            var products = table.CreateSet<Product>().ForEach(p => p.Number = p.GetEANFromHash());

            _context.AddProducts(products);
        }
    }
}