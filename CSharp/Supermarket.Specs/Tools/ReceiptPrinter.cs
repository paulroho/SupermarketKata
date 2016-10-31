using System;
using System.Globalization;
using System.Text;
using Supermarket.Model.Checkout;

namespace Supermarket.Specs.Tools
{
    public class ReceiptPrinter
    {
        public string Print(Receipt receipt)
        {
            if (receipt == null)
                throw new ArgumentNullException(nameof(receipt));

            var sb = new StringBuilder();

            AppendBookingLines(receipt, sb);
            AppendTotal(receipt, sb);
            AppendTaxLines(receipt, sb);

            return sb.ToString();
        }

        private static void AppendTaxLines(Receipt receipt, StringBuilder sb)
        {
            foreach (var line in receipt.TaxLines)
            {
                sb.AppendLine($"Incl. {line.Rate / 100:P} VAT {DecimalToString(line.Amount)}");
            }
        }

        private static void AppendTotal(Receipt receipt, StringBuilder sb)
        {
            sb.AppendLine("-----------------------");
            sb.AppendLine($"Total {DecimalToString(receipt.Total)}");
        }

        private static void AppendBookingLines(Receipt receipt, StringBuilder sb)
        {
            foreach (var line in receipt.Bookings)
            {
                sb.AppendLine($"{line.Text} {DecimalToString(line.Price)}");
            }
        }

        private static string DecimalToString(decimal dec)
        {
            return dec.ToString("C", new CultureInfo("en-US"));
        }
    }
}