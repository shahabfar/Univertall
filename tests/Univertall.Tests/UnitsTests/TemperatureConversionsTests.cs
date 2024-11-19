using Univertall.Units.Temperature;

namespace Univertall.Tests.UnitsTests;

public class TemperatureConversionsTests
{
    [Theory]
    [InlineData(0.0, TemperatureUnit.Celsius, 0.0)]
    [InlineData(32.0, TemperatureUnit.Fahrenheit, 0.0)]
    [InlineData(273.15, TemperatureUnit.Kelvin, 0.0)]
    [InlineData(491.67, TemperatureUnit.Rankine, 0.0)]
    [InlineData(150.0, TemperatureUnit.Delisle, 0.0)]
    [InlineData(0.0, TemperatureUnit.Newton, 0.0)]
    [InlineData(0.0, TemperatureUnit.Reaumur, 0.0)]
    [InlineData(7.5, TemperatureUnit.Romer, 0.0)]
    public void ToBaseUnit_ShouldConvertCorrectly(double value, TemperatureUnit fromUnit, double expected)
    {
        // Arrange
        var converter = new TemperatureConverter();

        // Act
        var result = converter.Convert(value, fromUnit, TemperatureUnit.Celsius);

        // Assert
        Assert.Equal(expected, result, 5);
    }

    [Theory]
    [InlineData(0.0, TemperatureUnit.Celsius, 0.0)]
    [InlineData(0.0, TemperatureUnit.Fahrenheit, 32.0)]
    [InlineData(0.0, TemperatureUnit.Kelvin, 273.15)]
    [InlineData(0.0, TemperatureUnit.Rankine, 491.67)]
    [InlineData(0.0, TemperatureUnit.Delisle, 150.0)]
    [InlineData(0.0, TemperatureUnit.Newton, 0.0)]
    [InlineData(0.0, TemperatureUnit.Reaumur, 0.0)]
    [InlineData(0.0, TemperatureUnit.Romer, 7.5)]
    public void FromBaseUnit_ShouldConvertCorrectly(double value, TemperatureUnit toUnit, double expected)
    {
        // Arrange
        var converter = new TemperatureConverter();

        // Act
        var result = converter.Convert(value, TemperatureUnit.Celsius, toUnit);

        // Assert
        Assert.Equal(expected, result, 5);
    }

    [Theory]
    [InlineData(0.0, TemperatureUnit.Celsius, TemperatureUnit.Fahrenheit, 32.0)]
    [InlineData(0.0, TemperatureUnit.Celsius, TemperatureUnit.Kelvin, 273.15)]
    [InlineData(0.0, TemperatureUnit.Celsius, TemperatureUnit.Rankine, 491.67)]
    [InlineData(0.0, TemperatureUnit.Celsius, TemperatureUnit.Delisle, 150.0)]
    [InlineData(0.0, TemperatureUnit.Celsius, TemperatureUnit.Newton, 0.0)]
    [InlineData(0.0, TemperatureUnit.Celsius, TemperatureUnit.Reaumur, 0.0)]
    [InlineData(0.0, TemperatureUnit.Celsius, TemperatureUnit.Romer, 7.5)]
    [InlineData(32.0, TemperatureUnit.Fahrenheit, TemperatureUnit.Celsius, 0.0)]
    [InlineData(273.15, TemperatureUnit.Kelvin, TemperatureUnit.Celsius, 0.0)]
    [InlineData(491.67, TemperatureUnit.Rankine, TemperatureUnit.Celsius, 0.0)]
    [InlineData(150.0, TemperatureUnit.Delisle, TemperatureUnit.Celsius, 0.0)]
    [InlineData(0.0, TemperatureUnit.Newton, TemperatureUnit.Celsius, 0.0)]
    [InlineData(0.0, TemperatureUnit.Reaumur, TemperatureUnit.Celsius, 0.0)]
    [InlineData(7.5, TemperatureUnit.Romer, TemperatureUnit.Celsius, 0.0)]
    public void Convert_ShouldConvertCorrectly(double value, TemperatureUnit fromUnit, TemperatureUnit toUnit, double expected)
    {
        // Arrange
        var converter = new TemperatureConverter();

        // Act
        var result = converter.Convert(value, fromUnit, toUnit);

        // Assert
        Assert.Equal(expected, result, 5);
    }
}