using System.Collections.Generic;
using System.Linq;
using Supermarket.Model.Core;

namespace Supermarket.Tests.Tools
{
    public static class ProductRepositoryTestExtensions
    {
        private static void Seed(this ProductRepository repository, int count)
        {
            repository.AddRange(GetProductList(count));
        }

        private static List<Product> GetProductList(int count)
        {
            return Enumerable.Range(1, count)
                             .Select(CreateAProduct)
                             .ToList();
        }

        private static Product CreateAProduct(int i)
        {
            return new Product
            {
                Name = $"Product {i}",
                UnitPrice = i * 11,
                Discount = (Discount)(i % 3),
                VATRate = i % 2 == 0 ? 10 : 20
            };
        }

        public static List<Product> GetNonDiscountedProductsByVAT(this ProductRepository rep, int vatPercentage)
        {
            return rep.Products.Where(item => item.VATRate == vatPercentage && item.Discount == Discount.None).ToList();
        }

        public static List<Product> GetNonDiscountedProducts(this ProductRepository rep)
        {
            return rep.Products.Where(item => item.Discount == Discount.None).ToList();
        }

        public static List<Product> GetAllProducts(this ProductRepository rep)
        {
            return rep.Products.ToList();
        }
    }
}