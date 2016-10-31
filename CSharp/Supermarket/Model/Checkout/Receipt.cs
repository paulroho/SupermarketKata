using System.Collections.Generic;

namespace Supermarket.Model.Checkout
{
    public class Receipt
    {
        public List<BookingLine> Bookings { get; set; }
        public List<TaxLine> TaxLines { get; set; }
        public decimal Total { get; set; }
    }
}