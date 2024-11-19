using Univertall.Units.Force;

namespace Univertall.Tests
{
    public class ForceConverterTests
    {
        [Theory]
        [InlineData(1, ForceUnit.Newton, ForceUnit.Newton, 1)]
        [InlineData(1, ForceUnit.Newton, ForceUnit.PoundForce, 0.224809)]
        [InlineData(1, ForceUnit.Newton, ForceUnit.KilogramForce, 0.101972)]
        [InlineData(1, ForceUnit.Newton, ForceUnit.Kilonewton, 0.001)]
        [InlineData(1, ForceUnit.Newton, ForceUnit.Dyne, 100000)]
        [InlineData(1, ForceUnit.Newton, ForceUnit.GramForce, 101.9716213)]
        [InlineData(1, ForceUnit.Newton, ForceUnit.OunceForce, 3.5969430896)]
        public void ConvertFromNewton_ShouldReturnCorrectValue(double value, ForceUnit fromUnit, ForceUnit toUnit, double expected)
        {
            // Act
            var result = new ForceConversionBuilder(value).From(fromUnit).To(toUnit);

            // Assert
            Assert.Equal(expected, result, precision: 5);
        }

        [Theory]
        [InlineData(1, ForceUnit.PoundForce, ForceUnit.Newton, 4.44822)]
        [InlineData(1, ForceUnit.KilogramForce, ForceUnit.Newton, 9.80661)]
        [InlineData(1, ForceUnit.Kilonewton, ForceUnit.Newton, 1000)]
        [InlineData(1, ForceUnit.Dyne, ForceUnit.Newton, 0.00001)]
        [InlineData(1, ForceUnit.GramForce, ForceUnit.Newton, 0.00980665)]
        [InlineData(1, ForceUnit.OunceForce, ForceUnit.Newton, 0.2780139)]
        public void ConvertToNewton_ShouldReturnCorrectValue(double value, ForceUnit fromUnit, ForceUnit toUnit, double expected)
        {
            // Act
            var result = new ForceConversionBuilder(value).From(fromUnit).To(toUnit);

            // Assert
            Assert.Equal(expected, result, precision: 5);
        }
    }
}
