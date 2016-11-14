package supermarket;

import java.util.Collection;

import supermarket.model.core.EAN;
import supermarket.model.core.Product;

public interface IProductRepository {
	
	Product getProductByNumber(EAN number);

	Product getProductByName(String name);

	void add(Product product);

	void addAll(Collection<Product> products);

}
