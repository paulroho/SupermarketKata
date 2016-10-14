using System.Collections.Generic;
using Supermarket.Model.Checkout;
using Supermarket.Model.Core;

namespace Supermarket.Specs.Bindings
{
    public class CashDeskContext
    {
        private readonly IProductRepository _repository;

        public CashDeskContext(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddProducts(IEnumerable<Product> products)
        {
            _repository.AddRange(products);
        }

        public void ScanProductsByName(IEnumerable<string> productNames)
        {
            foreach (var productName in productNames)
            {
                // ReSharper disable once UnusedVariable
                var product = _repository.GetProductByName(productName);
                // TODO: Add code to scan the product
            }
        }

        public Receipt Receipt { get; set; }
    }
}