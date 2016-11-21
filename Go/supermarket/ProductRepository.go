package supermarket

import (
	"./model/core"
)

type ProductRepository interface {
	ProductByNumber(number core.EAN) (core.Product, error)
	ProductByName(name string) (core.Product, error)
	Add(product core.Product)
	AddAll(products []core.Product)
}
