using System.Collections.Generic;

namespace Supermarket.Model.Checkout
{
    public class Receipt
    {
        public Receipt(List<BookingLine> bookingLines, List<TaxLine> taxLines, decimal total)
        {
            Bookings = bookingLines;
            TaxLines = taxLines;
            Total = total;
        }

        public List<BookingLine> Bookings { get; }
        public List<TaxLine> TaxLines { get; }
        public decimal Total { get; }
    }
}