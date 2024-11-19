using Univertall.Units.Mass;

namespace Univertall.Tests.UnitsTests
{
    public class MassConversionsTests
    {
        [Theory]
        [InlineData(1.0, MassUnit.Kilogram, 1.0)]
        [InlineData(1000.0, MassUnit.Gram, 1.0)]
        [InlineData(1e6, MassUnit.Milligram, 1.0)]
        [InlineData(1e9, MassUnit.Microgram, 1.0)]
        [InlineData(1.0, MassUnit.Ton, 1000.0)]
        [InlineData(2.20462, MassUnit.Pound, 1.0)]
        [InlineData(35.274, MassUnit.Ounce, 1.0)]
        [InlineData(0.157473, MassUnit.Stone, 1.0)]
        [InlineData(5000.0, MassUnit.Carat, 1.0)]
        [InlineData(1.0, MassUnit.LongTon, 1016.05)]
        [InlineData(1.0, MassUnit.ShortTon, 907.184)]
        public void ToBaseUnit_ShouldConvertCorrectly(double value, MassUnit fromUnit, double expected)
        {
            // Arrange
            var converter = new MassConverter();

            // Act
            var result = converter.Convert(value, fromUnit, MassUnit.Kilogram);

            // Assert
            Assert.Equal(expected, result, 4);
        }

        [Theory]
        [InlineData(1.0, MassUnit.Kilogram, 1.0)]
        [InlineData(1.0, MassUnit.Gram, 1000.0)]
        [InlineData(1.0, MassUnit.Milligram, 1e6)]
        [InlineData(1.0, MassUnit.Microgram, 1e9)]
        [InlineData(1000.0, MassUnit.Ton, 1.0)]
        [InlineData(1.0, MassUnit.Pound, 2.20462)]
        [InlineData(1.0, MassUnit.Ounce, 35.274)]
        [InlineData(1.0, MassUnit.Stone, 0.157473)]
        [InlineData(1.0, MassUnit.Carat, 5000.0)]
        [InlineData(1016.05, MassUnit.LongTon, 1.0)]
        [InlineData(907.185, MassUnit.ShortTon, 1.0)]
        public void FromBaseUnit_ShouldConvertCorrectly(double value, MassUnit toUnit, double expected)
        {
            // Arrange
            var converter = new MassConverter();

            // Act
            var result = converter.Convert(value, MassUnit.Kilogram, toUnit);

            // Assert
            Assert.Equal(expected, result, 4);
        }

        [Theory]
        [InlineData(1.0, MassUnit.Kilogram, MassUnit.Gram, 1000.0)]
        [InlineData(1.0, MassUnit.Kilogram, MassUnit.Milligram, 1e6)]
        [InlineData(1.0, MassUnit.Kilogram, MassUnit.Microgram, 1e9)]
        [InlineData(1.0, MassUnit.Kilogram, MassUnit.Ton, 0.001)]
        [InlineData(1.0, MassUnit.Kilogram, MassUnit.Pound, 2.20462)]
        [InlineData(1.0, MassUnit.Kilogram, MassUnit.Ounce, 35.27399)]
        [InlineData(1.0, MassUnit.Kilogram, MassUnit.Stone, 0.157473)]
        [InlineData(1.0, MassUnit.Kilogram, MassUnit.Carat, 5000.0)]
        [InlineData(1016.05, MassUnit.Kilogram, MassUnit.LongTon, 1.0)]
        [InlineData(907.184, MassUnit.Kilogram, MassUnit.ShortTon, 1.0)]
        [InlineData(1000.0, MassUnit.Gram, MassUnit.Kilogram, 1.0)]
        [InlineData(1e6, MassUnit.Milligram, MassUnit.Kilogram, 1.0)]
        [InlineData(1e9, MassUnit.Microgram, MassUnit.Kilogram, 1.0)]
        [InlineData(1.0, MassUnit.Ton, MassUnit.Kilogram, 1000.0)]
        [InlineData(2.20462, MassUnit.Pound, MassUnit.Kilogram, 1.0)]
        [InlineData(35.274, MassUnit.Ounce, MassUnit.Kilogram, 1.0)]
        [InlineData(0.157473, MassUnit.Stone, MassUnit.Kilogram, 1.0)]
        [InlineData(5000.0, MassUnit.Carat, MassUnit.Kilogram, 1.0)]
        [InlineData(1.0, MassUnit.LongTon, MassUnit.Kilogram, 1016.05)]
        [InlineData(1.0, MassUnit.ShortTon, MassUnit.Kilogram, 907.184)]
        public void Convert_ShouldConvertCorrectly(double value, MassUnit fromUnit, MassUnit toUnit, double expected)
        {
            // Arrange
            var converter = new MassConverter();

            // Act
            var result = converter.Convert(value, fromUnit, toUnit);

            // Assert
            Assert.Equal(expected, result, 4);
        }
    }
}

