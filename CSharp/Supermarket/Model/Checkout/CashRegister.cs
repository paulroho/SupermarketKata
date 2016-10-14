using Supermarket.Model.Core;

namespace Supermarket.Model.Checkout
{
    public class CashRegister : ICashRegister
    {
        public void Scan(EAN ean)
        {
            throw new System.NotImplementedException();
        }

        public Receipt CreateReceipt()
        {
            throw new System.NotImplementedException();
        }
    }
}