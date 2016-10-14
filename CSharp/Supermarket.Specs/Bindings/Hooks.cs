using BoDi;
using TechTalk.SpecFlow;

namespace Supermarket.Specs.Bindings
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeTestRun()
        {
            RegisterServices();
        }

        private void RegisterServices()
        {
            _objectContainer.RegisterTypeAs<ProductRepository, IProductRepository>();
        }
    }
}