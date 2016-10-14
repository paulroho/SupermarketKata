using System.Collections.Generic;
using System.Linq;
using Supermarket.Model.Core;

namespace Supermarket
{
    public static class ProductRepositoryExtensions
    {
        public static List<Product> GetNonDiscountedProductsByVAT(this ProductRepository rep, int vatPercentage)
        {
            return rep.Products.Where(item => item.VATPercentage == vatPercentage && item.Discount == Discount.None).ToList();
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