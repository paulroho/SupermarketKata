using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supermarket.Model.Core;

namespace Supermarket.Tests.Model.Core
{
    [TestClass]
    public class ProductTests
    {
        private static readonly EAN SomeEAN = EAN.NewEAN("123456789");

        [TestMethod]
        public void ctor_WithNameNull_ThrowsAProperException()
        {
            // ReSharper disable once ObjectCreationAsStatement
            var act = new Action(() => new Product(name: null, number:SomeEAN));
            act.ShouldThrow<ArgumentNullException>().Where(xcp => xcp.ParamName == "name");
        }

        [TestMethod]
        public void ctor_WithNameEmpty_ThrowsAProperException()
        {
            // ReSharper disable once ObjectCreationAsStatement
            var act = new Action(() => new Product(name: string.Empty, number: SomeEAN));
            act.ShouldThrow<ArgumentException>().Where(xcp => xcp.ParamName == "name");
        }

        [TestMethod]
        public void ctor_WithNameAllWhitespace_ThrowsAProperException()
        {
            // ReSharper disable once ObjectCreationAsStatement
            var act = new Action(() => new Product(name: " \t  \r\n  ", number: SomeEAN));
            act.ShouldThrow<ArgumentException>().Where(xcp => xcp.ParamName == "name");
        }

        [TestMethod]
        public void ctor_WithNumberNull_ThrowsAProperException()
        {
            // ReSharper disable once ObjectCreationAsStatement
            var act = new Action(() => new Product(name: "Some name", number:null));
            act.ShouldThrow<ArgumentNullException>().Where(xcp => xcp.ParamName == "number");
        }

        [TestMethod]
        public void Name_WhenInitializedInCtor_CanBeReadBack()
        {
            var product = new Product("The Name", SomeEAN);

            product.Name.Should().Be("The Name");
        }

        [TestMethod]
        public void Number_WhenInitializedInCtor_CanBeReadBack()
        {
            var theEan = EAN.NewEAN("987654321");
            var product = new Product("Dummy Product Name", theEan);

            product.Number.Should().Be(theEan);
        }

        [TestMethod]
        public void UnitPrice_OnNewInstance_ThrowsAProperException()
        {
            var product = new Product("Dummy Product Name", SomeEAN);
            // ReSharper disable once UnusedVariable
            var act = new Action(() => { var dummy = product.UnitPrice; });

            act.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void UnitPrice_WhenSet_CanBeReadBack()
        {
            var product = new Product("Dummy Product Name", SomeEAN);

            product.UnitPrice = 123.45M;
            var actual = product.UnitPrice;

            actual.Should().Be(123.45M);
        }

        [TestMethod]
        public void UnitPrice_WhenSetOnNegativeValue_ThrowsAProperException()
        {
            const decimal anyNegativeValue = -123.45M;
            var product = new Product("Dummy Product Name", SomeEAN);

            var act = new Action(() => { product.UnitPrice = anyNegativeValue; });

            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void TaxRate_OnNewInstance_ThrowsAProperException()
        {
            var product = new Product("Dummy Product Name", SomeEAN);
            // ReSharper disable once UnusedVariable
            var act = new Action(() => { var dummy = product.TaxRate; });

            act.ShouldThrow<InvalidOperationException>();
        }

        [TestMethod]
        public void TaxRate_WhenSet_CanBeReadBack()
        {
            var product = new Product("Dummy Product Name", SomeEAN);

            product.TaxRate = 20;
            var actual = product.TaxRate;

            actual.Should().Be(20);
        }

        [TestMethod]
        public void TaxRate_WhenSetOnNegativeValue_ThrowsAProperException()
        {
            const int anyNegativeValue = -20;
            var product = new Product("Dummy Product Name", SomeEAN);

            var act = new Action(() => { product.TaxRate = anyNegativeValue; });

            act.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [TestMethod]
        public void GrossPrice_WhenUnitPriceAndTaxRateAreSet_CalculatesTheGrossPrice()
        {
            var product = new Product("Dummy Product Name", SomeEAN)
            {
                TaxRate = 20,
                UnitPrice = 123.40M,
            };

            var actual = product.GrossPrice;

            actual.Should().Be(123.40M + 24.68M);
        }

        [TestMethod]
        public void GrossPrice_WhenItWouldHaveSubCentParts_RoundsItProperly()
        {
            var product = new Product("Dummy Product Name", SomeEAN)
            {
                TaxRate = 19,
                UnitPrice = 123.40M,
            };

            var actual = product.GrossPrice;

            actual.Should().Be(123.40M + 23.45M);   // Exact tax would be 23.446M
        }
    }
}