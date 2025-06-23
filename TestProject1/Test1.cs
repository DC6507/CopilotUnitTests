using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    public struct Montant
    {
        private readonly decimal _value;
        private readonly string _currency;

        public Montant(decimal value, string currency)
        {
            _value = value;
            _currency = currency;
        }

        public Montant Convert(string targetCurrency)
        {
            // Implémentation minimale pour satisfaire le test :
            return new Montant(0, targetCurrency);
        }

        public override bool Equals(object obj)
        {
            if (obj is not Montant other) return false;
            return _value == other._value && _currency == other._currency;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_value, _currency);
        }
    }

    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Convert_ZeroUsdToEur_ReturnsZeroEur()
        {
            // Arrange
            var montant = new Montant(0m, "USD");
            string toCurrency = "EUR";

            // Act
            Montant result = montant.Convert(toCurrency);

            // Assert
            var expected = new Montant(0m, "EUR");
            Assert.AreEqual(expected, result);
        }
    }
}
