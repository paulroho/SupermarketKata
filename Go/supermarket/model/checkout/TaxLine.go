package checkout

import (
	"fmt"
	"math/big"
)

type TaxLine struct {
	Rate   int
	Amount big.Float
}

func (line TaxLine) String() string {
	return fmt.Sprintf("VAT %v: %v", line.Rate, line.Amount)
}
