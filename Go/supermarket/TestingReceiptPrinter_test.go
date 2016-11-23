package supermarket

import (
	"bytes"
	"fmt"
	"io"
	"math/big"
	"strings"
	"testing"

	"github.com/stvp/assert"

	"./model/checkout"
)

type TestingReceiptPrinter struct {
}

func NewTestingReceiptPrinter() *TestingReceiptPrinter {
	return new(TestingReceiptPrinter)
}

func (printer *TestingReceiptPrinter) Print(receipt checkout.Receipt) string {
	buf := bytes.NewBuffer(nil)

	printer.appendBookingLines(buf, &receipt)
	printer.appendTotal(buf, &receipt)
	printer.appendTaxLines(buf, &receipt)

	return string(buf.Bytes())
}

func (printer *TestingReceiptPrinter) appendBookingLines(buf io.Writer, receipt *checkout.Receipt) {
	for _, line := range receipt.Bookings {
		fmt.Fprintf(buf, "%s\n", printer.formatBookingLine(&line))
	}
}

func (printer *TestingReceiptPrinter) appendTotal(buf io.Writer, receipt *checkout.Receipt) {
	fmt.Fprintf(buf, "%s\n", strings.Repeat("-", 33))
	fmt.Fprintf(buf, "        %-25s %s\n", "Total", printer.formatCurrency(&receipt.Total))
}

func (printer *TestingReceiptPrinter) appendTaxLines(buf io.Writer, receipt *checkout.Receipt) {
	for _, line := range receipt.TaxLines {
		fmt.Fprintf(buf, "%s\n", printer.formatTaxLine(&line))
	}
}

func (printer *TestingReceiptPrinter) formatCurrency(amount *big.Float) string {
	return fmt.Sprintf("%2.2f€", amount)
}

func (printer *TestingReceiptPrinter) formatPercentage(rate int) string {
	return fmt.Sprintf("%d%%", rate)
}

func (printer *TestingReceiptPrinter) formatTaxLine(taxLine *checkout.TaxLine) string {
	return fmt.Sprintf("        Incl. %s VAT            %s",
		printer.formatPercentage(taxLine.Rate), printer.formatCurrency(&taxLine.Amount))
}

func (printer *TestingReceiptPrinter) formatBookingLine(bookingLine *checkout.BookingLine) string {
	return fmt.Sprintf("        %-25s %s",
		bookingLine.Text, printer.formatCurrency(&bookingLine.Price))
}

func TestFormatCurrency(t *testing.T) {
	printer := NewTestingReceiptPrinter()
	result := printer.formatCurrency(big.NewFloat(1.8022))

	assert.Equal(t, "1.80€", result)
}

func TestFormatTax(t *testing.T) {
	printer := NewTestingReceiptPrinter()
	taxLine := checkout.TaxLine{Rate: 10, Amount: *big.NewFloat(0.8022)}
	result := printer.formatTaxLine(&taxLine)

	assert.Equal(t, "        Incl. 10% VAT            0.80€", result)
}

func TestFormatBooking(t *testing.T) {
	printer := NewTestingReceiptPrinter()
	bookingLine := checkout.BookingLine{Text: "Butter 250g", Price: *big.NewFloat(1.80)}
	result := printer.formatBookingLine(&bookingLine)

	assert.Equal(t, "        Butter 250g               1.80€", result)
}
