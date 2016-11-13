package supermarket.model.checkout;

import java.math.BigDecimal;

public class BookingLine {
	private String text;
	private BigDecimal price;

	public String getText() {
		return text;
	}

	public void setText(String text) {
		this.text = text;
	}

	public BigDecimal getPrice() {
		return price;
	}

	public void setPrice(BigDecimal price) {
		this.price = price;
	}

	@Override
	public String toString() {
		return String.format("%s: %d", text, price);
	}
}
