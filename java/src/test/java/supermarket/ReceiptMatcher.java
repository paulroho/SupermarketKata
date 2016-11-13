package supermarket;

import org.hamcrest.Description;
import org.hamcrest.TypeSafeMatcher;

import supermarket.model.checkout.Receipt;

public class ReceiptMatcher extends TypeSafeMatcher<Receipt> {

	public static ReceiptMatcher matches(String receiptText) {
		return new ReceiptMatcher(receiptText);
	}

	private String expectedReceiptAsString;

	private ReceiptMatcher(String expectedReceiptAsString) {
		this.expectedReceiptAsString = expectedReceiptAsString;
	}

	@Override
	public void describeTo(Description description) {

	}

	@Override
	protected boolean matchesSafely(Receipt receipt) {
		String actualReceiptAsString = getReceiptAsString(receipt);
		String actual = normalize(actualReceiptAsString);
		String expected = normalize(expectedReceiptAsString);

		return actual.equals(expected);
	}

	private String getReceiptAsString(Receipt receipt) {
		return new ReceiptPrinter().print(receipt);
	}

	private String normalize(String receiptAsString) {
		return receiptAsString;
	}

}
