package core

import (
	"fmt"
	"regexp"
)

type EAN struct {
	code string
}

func NewEAN(code string) (ean EAN, err error) {
	if isNilOrEmpty(code) {
		err = fmt.Errorf("The code must not be empty.")
	} else if !containsJustDigits(code) {
		err = fmt.Errorf("The code must consist only if digits but was " + code)
	} else if len(code) != 9 && len(code) != 13 {
		err = fmt.Errorf("The code must be 9 or 13 characters long but was " + code)
	}
	ean.code = code

	return
}

func isNilOrEmpty(text string) bool {
	return len(text) == 0
}

func containsJustDigits(text string) bool {
	matched, _ := regexp.MatchString("[0-9]*", text)
	return matched
}

func (ean EAN) String() string {
	return fmt.Sprintf("EAN%d: %v", len(ean.code), ean.code)
}
