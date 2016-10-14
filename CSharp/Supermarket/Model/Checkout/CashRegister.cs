using Supermarket.Model.Core;

namespace Supermarket.Model.Checkout
{
    public interface ICashRegister
    {
        void Scan(EAN ean);
        Receipt CreateReceipt();
    }

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