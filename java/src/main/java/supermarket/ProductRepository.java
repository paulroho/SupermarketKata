package supermarket;

import java.util.ArrayList;
import java.util.Collection;
import java.util.List;

import supermarket.model.core.EAN;
import supermarket.model.core.Product;

public class ProductRepository implements IProductRepository {
	private List<Product> products;

	public ProductRepository() {
		this.products = new ArrayList<Product>();
	}

	public Product getProductByNumber(final EAN number) {
		if (number == null) {
			throw new IllegalArgumentException();
		}
		return products.stream()//
				.filter(product -> number.equals(product.getNumber()))//
				.findAny()//
				.orElse(null);
	}

	public Product getProductByName(String name) {
		return products.stream() //
				.filter(product -> name.equals(product.getName()))//
				.findAny()//
				.orElse(null);
	}

	public void add(Product product) {
		products.add(product);
	}

	public void addAll(Collection<Product> additionalProducts) {
		products.addAll(additionalProducts);
	}

}
