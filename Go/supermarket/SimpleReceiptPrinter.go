package supermarket

import (
	"./model/checkout"
)

type SimpleReceiptPrinter struct {
}

func NewSimpleReceiptPrinter() ReceiptPrinter {
	return new(SimpleReceiptPrinter)
}

func (printer *SimpleReceiptPrinter) Print(receipt checkout.Receipt) string {
	return ""
}
