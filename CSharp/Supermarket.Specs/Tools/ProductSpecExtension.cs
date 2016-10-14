using Supermarket.Model.Core;

namespace Supermarket.Specs.Tools
{
    public static class ProductSpecExtension
    {
        public static EAN GetEANFromHash(this Product product)
        {
            var hash = GetAllDigitHash(product.Name, 9);
            return EAN.NewEAN(hash);
        }

        private static string GetAllDigitHash(string text, int numDigits)
        {
            var shorthash = text.GetHashCode()%10^numDigits;
            if (shorthash < 0) shorthash *= -1;
            return shorthash.ToString(new string('0', numDigits));
        }
    }
}