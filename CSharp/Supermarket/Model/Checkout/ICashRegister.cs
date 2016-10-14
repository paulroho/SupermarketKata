using Supermarket.Model.Core;

namespace Supermarket.Model.Checkout
{
    public interface ICashRegister
    {
        void Scan(EAN ean);
        Receipt CreateReceipt();
    }
}