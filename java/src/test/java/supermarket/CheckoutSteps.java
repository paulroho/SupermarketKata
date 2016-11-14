package supermarket;

import static org.junit.Assert.assertThat;

import java.util.List;

import cucumber.api.java.en.Given;
import cucumber.api.java.en.Then;
import cucumber.api.java.en.When;
import supermarket.model.checkout.Receipt;

public class CheckoutSteps {
	private CashDeskSpecsDriver cashDeskSpecsDriver;
	private Receipt receipt;

	public CheckoutSteps(CashDeskSpecsDriver cashDeskSpecsDriver) {
		this.cashDeskSpecsDriver = cashDeskSpecsDriver;
	}

	@Given("^I scan the following products at the cash desk:$")
	public void GivenIScanTheFollowingProductsAtTheCashDesk(List<String> productNames) throws Throwable {
		cashDeskSpecsDriver.scanProductsByName(productNames.subList(1, productNames.size()));
	}

	@When("^I check out$")
	public void WhenICheckOut() throws Throwable {
		receipt =cashDeskSpecsDriver.checkout();
	}

	@Then("^the receipt contains this information:$")
	public void ThenTheReceiptContainsThisInformation(String receiptText) throws Throwable {
		assertThat(receipt, ReceiptMatcher.matches(receiptText));
	}

}
