package supermarket

import (
	"./model/checkout"
)

type ReceiptPrinter interface {
	Print(receipt checkout.Receipt) string
}
