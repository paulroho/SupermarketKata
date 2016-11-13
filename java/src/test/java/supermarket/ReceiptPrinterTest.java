package supermarket;

import static org.junit.Assert.assertThat;

import java.math.BigDecimal;

import org.hamcrest.CoreMatchers;
import org.junit.Test;

import supermarket.model.checkout.BookingLine;
import supermarket.model.checkout.TaxLine;

public class ReceiptPrinterTest {
	@Test
	public void formatCurrency() throws Exception {
		ReceiptPrinter receiptPrinter = new ReceiptPrinter();

		String result = receiptPrinter.formatCurrency(new BigDecimal("1.8022"));
		assertThat(result, CoreMatchers.is("1.80€"));
	}
	
	@Test
	public void formatTax() throws Exception {
		ReceiptPrinter receiptPrinter = new ReceiptPrinter();

		TaxLine taxLine = new TaxLine();
		taxLine.setAmount(new BigDecimal("0.8022"));
		taxLine.setRate(10);
		String result = receiptPrinter.format(taxLine);
		assertThat(result, CoreMatchers.is("        Incl. 10% VAT            0.80€"));
	}
	@Test
	public void formatBooking() throws Exception {
		ReceiptPrinter receiptPrinter = new ReceiptPrinter();

		BookingLine taxLine = new BookingLine();
		taxLine.setPrice(new BigDecimal("1.80"));
		taxLine.setText("Butter 250g");
		String result = receiptPrinter.format(taxLine);
		assertThat(result, CoreMatchers.is("        Butter 250g               1.80€"));
	}

}
