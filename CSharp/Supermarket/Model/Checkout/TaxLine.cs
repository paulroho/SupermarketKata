namespace Supermarket.Model.Checkout
{
    public class TaxLine
    {
        public TaxLine(int rate, decimal amount)
        {
            Rate = rate;
            Amount = amount;
        }
        public int Rate { get; }
        public decimal Amount { get; }

        public override string ToString() => $"VAT {Rate/100.0:P0}: {Amount:C}";
    }
}