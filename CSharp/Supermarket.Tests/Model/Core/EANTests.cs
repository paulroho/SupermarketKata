using System;
using System.Runtime.InteropServices;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supermarket.Model.Core;

namespace Supermarket.Tests.Model.Core
{
    [TestClass]
    public class EANTests
    {
        [TestMethod]
        public void NewEAN_With9DigitString_ReturnsAnInstanceRepresentingThatString()
        {
            var ean = EAN.NewEAN("123456789");

            ean.Should().NotBeNull();
            ean.Code.Should().Be("123456789");
        }

        [TestMethod]
        public void NewEAN_With13DigitString_ReturnsAnInstanceRepresentingThatString()
        {
            var ean = EAN.NewEAN("1234567890123");

            ean.Should().NotBeNull();
            ean.Code.Should().Be("1234567890123");
        }

        [TestMethod]
        public void NewEAN_WithStringContainingNonDigits_ThrowsAProperException()
        {
            var act = new Action(() => EAN.NewEAN("X23456789"));

            act.ShouldThrow<ArgumentException>().WithMessage("*digits*");
        }

        [TestMethod]
        public void NewEAN_WithStringOfNot9or13Digits_ThrowsAProperException()
        {
            var act = new Action(() => EAN.NewEAN("123"));

            act.ShouldThrow<ArgumentException>()
                .WithMessage("*9*")
                .WithMessage("*13*");
        }

        [TestMethod]
        public void ToString_ForEAN9_ContainsFormatAndCode()
        {
            var ean = EAN.NewEAN("123456789");

            var actual = ean.ToString();

            actual.Should().Contain("EAN9")
                       .And.Contain("123456789");
        }

        [TestMethod]
        public void ToString_ForEAN13_ContainsFormatAndCode()
        {
            var ean = EAN.NewEAN("1234567890123");

            var actual = ean.ToString();

            actual.Should().Contain("EAN13")
                       .And.Contain("1234567890123");
        }

        [TestMethod]
        public void Equals_OnTwoInstancesWithSameCode_ReturnsTrue()
        {
            var ean1 = EAN.NewEAN("123456789");
            var ean2 = EAN.NewEAN("123456789");

            var actual = ean1.Equals(ean2);

            actual.Should().BeTrue();
        }

        [TestMethod]
        public void EqualityOperator_OnTwoInstancesWithSameCode_ReturnsTrue()
        {
            var ean1 = EAN.NewEAN("123456789");
            var ean2 = EAN.NewEAN("123456789");

            var actual = ean1 == ean2;

            actual.Should().BeTrue();
        }

        [TestMethod]
        public void Equals_OnTwoInstancesWithDifferentCode_ReturnsFalse()
        {
            var ean1 = EAN.NewEAN("123456789");
            var ean2 = EAN.NewEAN("912345678");

            var actual = ean1.Equals(ean2);

            actual.Should().BeFalse();
        }

        [TestMethod]
        public void InequalityOperator_OnTwoInstancesWithSameCode_ReturnsTrue()
        {
            var ean1 = EAN.NewEAN("123456789");
            var ean2 = EAN.NewEAN("123456789");

            var actual = ean1 != ean2;

            actual.Should().BeFalse();
        }
    }
}