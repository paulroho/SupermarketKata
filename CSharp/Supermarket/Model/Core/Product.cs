using System;

namespace Supermarket.Model.Core
{
    public class Product
    {
        private decimal? _unitPrice;
        private int? _taxRate;

        public Product(string name, EAN number)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentOutOfRangeException(nameof(name));
            Name = name;

            if (number == null)
                throw new ArgumentNullException(nameof(number));
            Number = number;
        }

        public EAN Number { get; }
        public string Name { get; }

        public decimal UnitPrice
        {
            get
            {
                if (!_unitPrice.HasValue)
                {
                    throw new InvalidOperationException();
                }
                return _unitPrice.Value;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The UnitPrice has to be 0 or positive.");
                }
                _unitPrice = value;
            }
        }

        public int TaxRate
        {
            get
            {
                if (!_taxRate.HasValue)
                {
                    throw new InvalidOperationException();
                }
                return _taxRate.Value;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The TaxRate has to be 0 or positive.");
                }
                _taxRate = value;
            }
        }

        public decimal GrossPrice => Math.Round(UnitPrice*(1 + TaxRate/100M), 2, MidpointRounding.AwayFromZero);

        public override string ToString() => $"{Name} {UnitPrice:C}";
    }
}