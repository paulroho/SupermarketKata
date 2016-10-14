using TechTalk.SpecFlow;

namespace Supermarket.Specs.Bindings
{
    [Binding]
    public class CheckoutBindings
    {
        [Given(@"I scan the following products at the cash desk:")]
        public void GivenIScanTheFollowingProductsAtTheCashDesk(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I check out")]
        public void WhenICheckOut()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the receipt contains this information:")]
        public void ThenTheReceiptContaintsThisInformation(string multilineText)
        {
            ScenarioContext.Current.Pending();
        }
    }
}