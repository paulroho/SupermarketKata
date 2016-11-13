package supermarket;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;

import cucumber.api.DataTable;
import cucumber.api.java.en.Given;
import supermarket.model.core.Product;

public class CommonSteps {
	private CashDeskSpecsDriver cashDeskSpecsDriver;

	public CommonSteps(CashDeskSpecsDriver cashDeskSpecsDriver) {
		this.cashDeskSpecsDriver = cashDeskSpecsDriver;
	}

	@Given("^we have the following products in stock:$")
	public void GivenWeHaveTheFollowingProductsInStock(DataTable productTable) throws Throwable {
		List<Product> products = new ArrayList<>();

		for (List<String> row : productTable.raw()) {
			if (isHeader(row)) {
				continue;
			}

			Product product = new Product();
			product.setName(row.get(0));
			product.setUnitPrice(new BigDecimal(row.get(1).substring(0, row.get(1).indexOf('€'))));
			product.setTaxRate(Integer.valueOf(row.get(2).substring(0, row.get(2).indexOf('%'))));
			product.setNumber(EANGenerator.getEANFromHash(product));
			products.add(product);
		}
		cashDeskSpecsDriver.addProducts(products);
	}

	private boolean isHeader(List<String> row) {
		return row.get(0).startsWith("Name");
	}

}
