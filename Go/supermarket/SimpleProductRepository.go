package supermarket

import (
	"fmt"

	"./model/core"
)

type SimpleProductRepository struct {
	products []core.Product
}

func NewSimpleProductRepository() ProductRepository {
	return new(SimpleProductRepository)
}

func (repo *SimpleProductRepository) ProductByNumber(number core.EAN) (product core.Product, err error) {
	return repo.findBy(func(product *core.Product) bool {
		return product.Number == number
	})
}

func (repo *SimpleProductRepository) ProductByName(name string) (product core.Product, err error) {
	return repo.findBy(func(product *core.Product) bool {
		return product.Name == name
	})
}

func (repo *SimpleProductRepository) Add(product core.Product) {
	repo.products = append(repo.products, product)
}

func (repo *SimpleProductRepository) AddAll(products []core.Product) {
	repo.products = append(repo.products, products...)
}

func (repo *SimpleProductRepository) findBy(predicate func(product *core.Product) bool) (product core.Product, err error) {
	err = fmt.Errorf("Product not found")
	for _, entry := range repo.products {
		if predicate(&entry) {
			product = entry
			err = nil
		}
	}
	return
}
