using Univertall.Units.FuelEconomy;

namespace Univertall.Tests.UnitsTests
{
    public class FuelEconomyConverterTests
    {
        [Theory]
        [InlineData(10, FuelEconomyUnit.MilesPerGallon, 23.5215)]
        [InlineData(5, FuelEconomyUnit.LitersPer100Km, 5)]
        [InlineData(1, FuelEconomyUnit.KmPerLiter, 100)]
        [InlineData(20, FuelEconomyUnit.MilesPerGallonImperial, 14.12405)]
        public void ToBaseUnit_ShouldConvertCorrectly(double value, FuelEconomyUnit fromUnit, double expected)
        {
            // Arrange
            var converter = new FuelEconomyConverter();

            // Act
            var result = converter.Convert(value, fromUnit, FuelEconomyUnit.LitersPer100Km);

            // Assert
            Assert.Equal(expected, result, 5);
        }

        [Theory]
        [InlineData(23.5215, FuelEconomyUnit.MilesPerGallon, 10)]
        [InlineData(5, FuelEconomyUnit.LitersPer100Km, 5)]
        [InlineData(1, FuelEconomyUnit.KmPerLiter, 100)]
        [InlineData(14.12405, FuelEconomyUnit.MilesPerGallonImperial, 20)]
        public void FromBaseUnit_ShouldConvertCorrectly(double value, FuelEconomyUnit toUnit, double expected)
        {
            // Arrange
            var converter = new FuelEconomyConverter();

            // Act
            var result = converter.Convert(value, FuelEconomyUnit.LitersPer100Km, toUnit);

            // Assert
            Assert.Equal(expected, result, 5);
        }

        [Theory]
        [InlineData(10, FuelEconomyUnit.MilesPerGallon, FuelEconomyUnit.KmPerLiter, 4.25143)]
        [InlineData(5, FuelEconomyUnit.LitersPer100Km, FuelEconomyUnit.MilesPerGallon, 47.043)]
        [InlineData(1, FuelEconomyUnit.KmPerLiter, FuelEconomyUnit.MilesPerGallonImperial, 2.82481)]
        [InlineData(20, FuelEconomyUnit.MilesPerGallonImperial, FuelEconomyUnit.LitersPer100Km, 14.12405)]
        public void Convert_ShouldConvertCorrectly(double value, FuelEconomyUnit fromUnit, FuelEconomyUnit toUnit, double expected)
        {
            // Arrange
            var converter = new FuelEconomyConverter();

            // Act
            var result = converter.Convert(value, fromUnit, toUnit);

            // Assert
            Assert.Equal(expected, result, 5);
        }
    }
}
