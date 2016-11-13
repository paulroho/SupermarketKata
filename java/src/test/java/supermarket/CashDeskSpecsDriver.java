package supermarket;

import java.util.List;

import supermarket.model.checkout.CashRegister;
import supermarket.model.checkout.ICashRegister;
import supermarket.model.checkout.Receipt;
import supermarket.model.core.EAN;
import supermarket.model.core.Product;

public class CashDeskSpecsDriver {
	private IProductRepository repository;
	private ICashRegister cashRegister;
	private Receipt receipt;

	public CashDeskSpecsDriver(ProductRepository repository, CashRegister cashRegister) {
		this.repository = repository;
		this.cashRegister = cashRegister;
	}

	public Receipt getReceipt() {
		return receipt;
	}

	public void setReceipt(Receipt receipt) {
		this.receipt = receipt;
	}

	public void addProducts(List<Product> products) {
		repository.addAll(products);
	}

	public void scanProductsByName(List<String> productNames) {
		for (String name : productNames) {
			Product product = repository.getProductByName(name);
			EAN ean = EANGenerator.getEANFromHash(product);

			// TODO: Add code to scan the product with the cash register
			// cashRegister...
		}
	}

	public Receipt checkout() {
		// TODO: Add code to get the receipt from the cash register
		// return cashRegister...
		throw new RuntimeException("Not yet implemented now");
	}

}
