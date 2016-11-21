package core

import (
	"fmt"
)

type EAN struct {
	code string
}

func NewEAN(code string) (ean EAN, err error) {
	ean.code = code

	return
}

func (ean EAN) String() string {
	return fmt.Sprintf("EAN%d: %v", len(ean.code), ean.code)
}
