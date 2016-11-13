package supermarket;

import java.io.PrintWriter;
import java.io.StringWriter;
import java.math.BigDecimal;
import java.text.DecimalFormat;
import java.text.NumberFormat;
import java.util.Locale;

import supermarket.model.checkout.BookingLine;
import supermarket.model.checkout.Receipt;
import supermarket.model.checkout.TaxLine;

public class ReceiptPrinter {

	public String print(Receipt receipt) {
		if (receipt == null) {
			throw new IllegalArgumentException();
		}

		StringWriter stringWriter = new StringWriter();
		PrintWriter printWriter = new PrintWriter(stringWriter);

		appendBookingLines(receipt, printWriter);
		appendTotal(receipt, printWriter);
		appendTaxLines(receipt, printWriter);

		return printWriter.toString();
	}

	private void appendTaxLines(Receipt receipt, PrintWriter sb) {
		for (TaxLine taxline : receipt.getTaxLines()) {
			sb.println(format(taxline));
		}
	}

	private void appendTotal(Receipt receipt, PrintWriter sb) {
		sb.println(String.format("%-33s", " ").replace(' ', '-'));
		sb.append(String.format("        %-25s %s", "Total", formatCurrency(receipt.getTotal())));
	}

	private void appendBookingLines(Receipt receipt, PrintWriter sb) {
		for (BookingLine booking : receipt.getBookings()) {
			sb.println(format(booking));
		}
	}

	public String formatCurrency(BigDecimal amount) {
		NumberFormat numberFormat = DecimalFormat.getInstance(Locale.ENGLISH);
		numberFormat.setMinimumFractionDigits(2);
		numberFormat.setMaximumFractionDigits(2);
		return String.format("%s€", numberFormat.format(amount));
	}

	private String formatPercentage(int rate) {
		NumberFormat numberFormat = NumberFormat.getPercentInstance();
		return numberFormat.format((double) rate / 100);
	}

	public String format(TaxLine taxLine) {
		return String.format("        Incl. %s VAT            %s", formatPercentage(taxLine.getRate()),
				formatCurrency(taxLine.getAmount()));
	}

	public String format(BookingLine booking) {
		return String.format("        %-25s %s", booking.getText(), formatCurrency(booking.getPrice()));
	}

}
