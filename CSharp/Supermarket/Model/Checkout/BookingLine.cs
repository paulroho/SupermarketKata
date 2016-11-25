namespace Supermarket.Model.Checkout
{
    public class BookingLine
    {
        public BookingLine(string text, decimal price)
        {
            Text = text;
            Price = price;
        }

        public string Text { get; }

        public decimal Price { get; }

        public override string ToString() => $"{Text}: {Price:C}";
    }
}