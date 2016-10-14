using System.Collections.Generic;

namespace Supermarket.Model.Checkout
{
    public class Receipt
    {
        public List<BookingLine> Bookings { get; set; }
        public List<VATLine> VATLines { get; set; }
        public decimal Total { get; set; }
    }
}