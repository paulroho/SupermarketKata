package supermarket.model.checkout;

import java.math.BigDecimal;

public class TaxLine {
	private int rate;
	private BigDecimal amount;

	public int getRate() {
		return rate;
	}

	public void setRate(int rate) {
		this.rate = rate;
	}

	public BigDecimal getAmount() {
		return amount;
	}

	public void setAmount(BigDecimal amount) {
		this.amount = amount;
	}

	@Override
	public String toString() {
		return String.format("VAT %i: %d", getRate() / 100, amount);
	}

}
