package supermarket

import (
	"fmt"
	"strconv"
	"strings"

	"./model/core"

	"github.com/DATA-DOG/godog"
	"github.com/DATA-DOG/godog/gherkin"
)

var driver *CashSpecsDriver

func FeatureContext(s *godog.Suite) {
	s.Step(`^we have the following products in stock:$`, weHaveTheFollowingProductsInStock)
	s.Step(`^I scan the following products at the cash desk:$`, iScanTheFollowingProductsAtTheCashDesk)
	s.Step(`^I check out$`, iCheckOut)
	s.Step(`^the receipt contains this information:$`, theReceiptContainsThisInformation)

	s.BeforeScenario(func(interface{}) {
		driver = NewCashSpecsDriver()
	})
}

func weHaveTheFollowingProductsInStock(productTable *gherkin.DataTable) error {
	var products []core.Product
	for index, row := range productTable.Rows {
		if !isHeader(index, row) {
			nameString := row.Cells[0].Value
			unitPriceString := row.Cells[1].Value
			unitPrice, _ := strconv.ParseFloat(unitPriceString[0:strings.Index(unitPriceString, "€")], 10)
			taxRateString := row.Cells[2].Value
			taxRate, _ := strconv.ParseInt(taxRateString[0:strings.Index(taxRateString, "%")], 10, 32)

			var product core.Product
			product.Name = nameString
			product.UnitPrice.SetFloat64(unitPrice)
			product.TaxRate = int(taxRate)
			product.Number = EANFromHash(product)
			products = append(products, product)
		}
	}
	driver.AddProducts(products)

	return nil
}

func iScanTheFollowingProductsAtTheCashDesk(nameTable *gherkin.DataTable) error {
	var productNames []string
	for index, row := range nameTable.Rows {
		if !isHeader(index, row) {
			nameString := row.Cells[0].Value
			productNames = append(productNames, nameString)
		}
	}
	driver.ScanProductsByName(productNames)

	return nil
}

func isHeader(index int, row *gherkin.TableRow) bool {
	return index == 0
}

func iCheckOut() error {
	driver.Checkout()

	return nil
}

func theReceiptContainsThisInformation(expected *gherkin.DocString) (result error) {
	printer := NewTestingReceiptPrinter()
	receipt := driver.Receipt()
	resultText := printer.Print(receipt)
	if expected.Content != resultText {
		result = fmt.Errorf("Retrieved: \n\"\"\"\n%s\n\"\"\"\n", resultText)
	}

	return
}
