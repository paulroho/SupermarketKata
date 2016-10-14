using TechTalk.SpecFlow;

namespace Supermarket.Specs.Bindings
{
    [Binding]
    public class CommonBindings
    {
        [Given(@"we have the following products in stock:")]
        public void GivenWeHaveTheFollowingProductsInStock(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}