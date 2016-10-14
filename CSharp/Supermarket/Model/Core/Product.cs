namespace Supermarket.Model.Core
{
    public class Product
    {
        public EAN Number { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int VATPercentage { get; set; }
        public Discount Discount { get; set; }
    }
}