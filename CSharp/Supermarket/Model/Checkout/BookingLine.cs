namespace Supermarket.Model.Checkout
{
    public class BookingLine
    {
        public string Text { get; set; }
        public decimal Price { get; set; }

        public override string ToString() => $"{Text}: {Price:C}";
    }
}