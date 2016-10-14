namespace Supermarket.Model.Checkout
{
    public class VATLine
    {
        public int Percentage { get; set; }
        public decimal Amount { get; set; }

        public override string ToString() => $"VAT {Percentage/100:P0}: {Amount:C}";
    }
}