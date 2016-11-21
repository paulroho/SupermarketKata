package supermarket

import (
	"bytes"
	"fmt"
	"hash/crc32"
	"strings"

	"./model/core"
)

func EANFromHash(product core.Product) core.EAN {
	crc := crc32.ChecksumIEEE(bytes.NewBufferString(product.Name).Bytes())
	eanType := 9
	paddedString := fmt.Sprintf("%d%v", crc, strings.Repeat("0", eanType))
	ean, err := core.NewEAN(paddedString[0:eanType])

	if err != nil {
		panic(fmt.Errorf("Test code couldn't product proper EAN: %v", err))
	}

	return ean
}
