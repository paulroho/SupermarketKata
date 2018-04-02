package checkout

import (
	"math/big"
)

type Receipt struct {
	Bookings []BookingLine
	TaxLines []TaxLine
	Total    big.Float
}
