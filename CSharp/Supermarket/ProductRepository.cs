using System;
using System.Collections.Generic;
using System.Linq;
using Supermarket.Model.Core;

namespace Supermarket
{
    public class ProductRepository
    {
        public ProductRepository()
        {
            Products = GetProductList();
        }

        public List<Product> Products { get; }

        private List<Product> GetProductList()
        {
            const int productCount = 15;

            return Enumerable.Range(1, productCount)
                             .Select(CreateAProduct)
                             .ToList();
        }

        private static Product CreateAProduct(int i)
        {
            var dicount = i%3;
            var vat = i%2;
            var product = new Product
            {
                Name = $"Product {i}",
                UnitPrice = i*11,
                Discount = dicount == 0 ? Discount.None : dicount == 1 ? Discount.Take3Pay2 : Discount.Take5Pay4,
                VATPercentage = vat == 0 ? 10 : 20
            };
            return product;
        }

        public Product GetProductByNumber(EAN number)
        {
            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }
            return Products.SingleOrDefault(item => item.Number.Code == number.Code);
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }
    }
}