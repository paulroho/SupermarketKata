using System;
using System.Linq;

namespace Supermarket.Model.Core
{
    /// <summary>
    /// Represents a European Article Number (EAN9 or EAN13).
    /// </summary>
    public class EAN
    {
        private EAN(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("The code must not be empty.", nameof(code));
            if (!ContainsJustDigits(code))
                throw new ArgumentException("The code must consist only of digits.", nameof(code));
            if (code.Length != 9 && code.Length != 13)
                throw new ArgumentException("The code must be 9 or 13 characters long.", nameof(code));
            Code = code;
        }

        public string Code { get; }

        /// <summary>
        /// Creates a EAN object based on the code passed. The validity of the code is not checked.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EAN NewEAN(string code)
        {
            return new EAN(code);
        }

        private static bool ContainsJustDigits(string text)
        {
            return text.All(c => c >= '0' && c <= '9');
        }

        public override string ToString() => $"EAN{Code.Length}: {Code}";

        #region Equality Members

        protected bool Equals(EAN other)
        {
            return string.Equals(Code, other.Code);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EAN) obj);
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public static bool operator ==(EAN left, EAN right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EAN left, EAN right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}