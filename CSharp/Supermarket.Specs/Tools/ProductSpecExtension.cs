using Supermarket.Model.Core;

namespace Supermarket.Specs.Tools
{
    public static class ProductSpecExtension
    {
        private static int _modulusEan9 = (int)1E9;

        public static EAN GetEANFromProductName(this string name)
        {
            var hash = GetAllDigitHash(name, 9, _modulusEan9);
            return EAN.NewEAN(hash);
        }

        private static string GetAllDigitHash(string text, int numDigits, int modulus)
        {
            var shorthash = text.GetHashCode();
            if (shorthash < 0)
                shorthash *= -1;
            shorthash = shorthash % modulus;
            return shorthash.ToString(new string('0', numDigits));
        }
    }
}