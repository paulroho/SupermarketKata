package supermarket.model.core;

import java.math.BigDecimal;

public class Product
{
	private EAN number;
	private String name;
	private BigDecimal unitPrice;
	private int taxRate;

	
	
    public EAN getNumber() {
		return number;
	}

	public void setNumber(EAN number) {
		this.number = number;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public BigDecimal getUnitPrice() {
		return unitPrice;
	}

	public void setUnitPrice(BigDecimal unitPrice) {
		this.unitPrice = unitPrice;
	}

	public int getTaxRate() {
		return taxRate;
	}

	public void setTaxRate(int taxRate) {
		this.taxRate = taxRate;
	}

    @Override
    public String toString() {
    	return String.format("%s %d", name, unitPrice);
    }
}