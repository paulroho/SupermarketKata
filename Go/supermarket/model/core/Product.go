package core

import (
	"fmt"
	"math/big"
)

type Product struct {
	Number    EAN
	Name      string
	UnitPrice big.Float
	TaxRate   int
}

func (product Product) String() string {
	return fmt.Sprintf("%v %v", product.Name, product.UnitPrice)
}
