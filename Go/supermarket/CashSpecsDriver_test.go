package supermarket

import (
	"./model/checkout"
	"./model/core"
)

type CashSpecsDriver struct {
	repository   ProductRepository
	cashRegister checkout.CashRegister
	receipt      checkout.Receipt
}

func NewCashSpecsDriver() *CashSpecsDriver {
	return &CashSpecsDriver{
		repository: NewSimpleProductRepository()}
}

func (driver *CashSpecsDriver) AddProducts(products []core.Product) {
	driver.repository.AddAll(products)
}

func (driver *CashSpecsDriver) ScanProductsByName(productNames []string) {
	for _, name := range productNames {
		driver.repository.ProductByName(name) // use returned product

		// TODO: Add code to scan the product with the cash register
		// cashRegister...
	}
}

func (driver *CashSpecsDriver) Checkout() {
	// TODO: Add code to get the receipt from the cash register
	// driver.receipt = driver.cashRegister...
}

func (driver *CashSpecsDriver) Receipt() checkout.Receipt {
	return driver.receipt
}
