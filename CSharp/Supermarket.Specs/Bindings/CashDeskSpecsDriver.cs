using System;
using System.Collections.Generic;
using Supermarket.Model.Checkout;
using Supermarket.Model.Core;

namespace Supermarket.Specs.Bindings
{
    public class CashDeskSpecsDriver
    {
        private readonly IProductRepository _repository;
        private readonly ICashRegister _cashRegister;

        public CashDeskSpecsDriver(IProductRepository repository, ICashRegister cashRegister)
        {
            _repository = repository;
            _cashRegister = cashRegister;
        }

        public void AddProducts(IEnumerable<Product> products)
        {
            _repository.AddRange(products);
        }

        public void ScanProductsByName(IEnumerable<string> productNames)
        {
            foreach (var productName in productNames)
            {
                var product = _repository.GetProductByName(productName);
                var ean = product.Number;

                // TODO: Add code to scan the product with the cash register
                // _cashRegister...
            }
        }

        public Receipt Receipt { get; set; }

        public Receipt Checkout()
        {
            // TODO: Add code to get the receipt from the cash register
            // return _cashRegister...
            throw new NotImplementedException();
        }
    }
}