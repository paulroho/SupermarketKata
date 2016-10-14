using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supermarket.Model.Checkout;

namespace Supermarket.Specs.Tools
{
    public static class ReceiptSpecExtensions
    {
        public static void ShouldBeRepresentedBy(this Receipt receipt, string expectedReceiptAsString)
        {
            var actualReceiptAsString = GetReceiptAsString(receipt);
            var actual = Normalize(actualReceiptAsString);
            var expected = Normalize(expectedReceiptAsString);
            Assert.AreEqual(expected, actual);
        }

        private static string GetReceiptAsString(Receipt receipt)
        {
            var printer = new ReceiptPrinter();
            return printer.Print(receipt);
        }

        private static string Normalize(string receiptAsString)
        {
            var whiteSpacesCompressed = Regex.Replace(receiptAsString, " {2,}", " ");
            return Regex.Replace(whiteSpacesCompressed, "-*", "");
        }
    }
}