package supermarket.model.checkout;

import java.math.BigDecimal;
import java.util.List;

public class Receipt {
	private List<BookingLine> bookings;
	private List<TaxLine> taxLines;
	private BigDecimal total;

	public List<BookingLine> getBookings() {
		return bookings;
	}

	public void setBookings(List<BookingLine> bookings) {
		this.bookings = bookings;
	}

	public List<TaxLine> getTaxLines() {
		return taxLines;
	}

	public void setTaxLines(List<TaxLine> taxLines) {
		this.taxLines = taxLines;
	}

	public BigDecimal getTotal() {
		return total;
	}

	public void setTotal(BigDecimal total) {
		this.total = total;
	}
}
