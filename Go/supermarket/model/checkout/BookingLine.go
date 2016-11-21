package checkout

import (
	"fmt"
	"math/big"
)

type BookingLine struct {
	Text  string
	Price big.Int
}

func (line BookingLine) String() string {
	return fmt.Sprintf("%v: %v", line.Text, line.Price)
}
