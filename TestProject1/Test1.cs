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

        public Montant Convert(string targetCurrency, decimal taux = 1)
        {
            if (_currency == targetCurrency)
                return new Montant(_value, _currency);

            if (_value == 0)
                return new Montant(0, targetCurrency);

            var convertedValue = _value * taux;
            return new Montant(convertedValue, targetCurrency);
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

        [TestMethod]
        public void Convert_ZeroGbpToJpy_ReturnsZeroJpy()
        {
            // Arrange
            var montant = new Montant(0m, "GBP");
            string toCurrency = "JPY";

            // Act
            Montant result = montant.Convert(toCurrency);

            // Assert
            var expected = new Montant(0m, "JPY");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Convert_OneEurToEur_ReturnsOneEur()
        {
            // Arrange
            var montant = new Montant(1m, "EUR");
            string toCurrency = "EUR";

            // Act
            Montant result = montant.Convert(toCurrency);

            // Assert
            var expected = new Montant(1m, "EUR");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Convert_OneHundredUsdToUsd_ReturnsOneHundredUsd()
        {
            // Arrange
            var montant = new Montant(100m, "USD");
            string toCurrency = "USD";

            // Act
            Montant result = montant.Convert(toCurrency);

            // Assert
            var expected = new Montant(100m, "USD");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Convert_OneEurToUsd_ReturnsOnePointOneEightUsd()
        {
            // Arrange
            const decimal value = 1m;
            var montant = new Montant(value, "EUR");
            string toCurrency = "USD";
            decimal taux = 1.18m;

            // Act
            // On simule la logique métier attendue : la méthode Convert ne gère pas encore les taux,
            // donc on applique le taux dans le test pour simuler le résultat attendu.
            Montant result = montant.Convert(toCurrency, taux);

            // Assert
            var expected = new Montant(value * taux, "USD");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Convert_OneUsdToEur_ReturnsZeroPointEightFiveEur()
        {
            // Arrange
            const decimal value = 1m;
            var montant = new Montant(value, "USD");
            string toCurrency = "EUR";
            decimal taux = 0.85m;

            // Act
            Montant result = montant.Convert(toCurrency, taux);

            // Assert
            var expected = new Montant(value * taux, "EUR");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Convert_MinusOneHundredUsdToEur_ReturnsMinusEightyFiveEur()
        {
            // Arrange
            const decimal value = -100m;
            var montant = new Montant(value, "USD");
            string toCurrency = "EUR";
            decimal taux = 0.85m;

            // Act
            Montant result = montant.Convert(toCurrency, taux);

            // Assert
            var expected = new Montant(value * taux, "EUR");
            Assert.AreEqual(expected, result);
        }
    }
}
