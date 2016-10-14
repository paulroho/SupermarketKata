using System;
using System.Collections.Generic;
using System.Linq;
using Supermarket.Model.Core;

namespace Supermarket
{
    public interface IProductRepository
    {
        Product GetProductByNumber(EAN number);
        Product GetProductByName(string name);
        void Add(Product product);
        void AddRange(IEnumerable<Product> products);
    }

    public class ProductRepository : IProductRepository
    {
        public List<Product> Products { get; }

        public ProductRepository()
        {
            Products = new List<Product>();
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void AddRange(IEnumerable<Product> products)
        {
            Products.AddRange(products);
        }

        public Product GetProductByNumber(EAN number)
        {
            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }
            return Products.SingleOrDefault(item => item.Number.Code == number.Code);
        }

        public Product GetProductByName(string name)
        {
            return Products.FindLast(p => p.Name == name);
        }
    }
}