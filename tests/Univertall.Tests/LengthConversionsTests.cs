using Univertall.Units.Length;

namespace Univertall.Tests;

public class LengthConversionsTests
{
    [Theory]
    [InlineData(1.0, LengthUnit.Mile, 1609.344)]
    [InlineData(1.0, LengthUnit.Kilometer, 1000.0)]
    [InlineData(1.0, LengthUnit.Centimeter, 0.01)]
    [InlineData(1.0, LengthUnit.Inch, 0.0254)]
    [InlineData(1.0, LengthUnit.Meter, 1.0)]
    [InlineData(1.0, LengthUnit.Foot, 0.3048)]
    [InlineData(1.0, LengthUnit.Yard, 0.9144)]
    public void ToBaseUnit_ShouldConvertCorrectly(double value, LengthUnit fromUnit, double expected)
    {
        // Arrange
        var converter = new LengthConverter();

        // Act
        var result = converter.Convert(value, fromUnit, LengthUnit.Meter);

        // Assert
        Assert.Equal(expected, result, 5);
    }

    [Theory]
    [InlineData(1609.344, LengthUnit.Mile, 1.0)]
    [InlineData(1000.0, LengthUnit.Kilometer, 1.0)]
    [InlineData(0.01, LengthUnit.Centimeter, 1.0)]
    [InlineData(0.0254, LengthUnit.Inch, 1.0)]
    [InlineData(1.0, LengthUnit.Meter, 1.0)]
    [InlineData(0.3048, LengthUnit.Foot, 1.0)]
    [InlineData(0.9144, LengthUnit.Yard, 1.0)]
    public void FromBaseUnit_ShouldConvertCorrectly(double value, LengthUnit toUnit, double expected)
    {
        // Arrange
        var converter = new LengthConverter();

        // Act
        var result = converter.Convert(value, LengthUnit.Meter, toUnit);

        // Assert
        Assert.Equal(expected, result, 5);
    }

    [Theory]
    [InlineData(1.0, LengthUnit.Mile, LengthUnit.Kilometer, 1.609344)]
    [InlineData(1.0, LengthUnit.Kilometer, LengthUnit.Mile, 0.621371)]
    [InlineData(100.0, LengthUnit.Centimeter, LengthUnit.Meter, 1.0)]
    [InlineData(1.0, LengthUnit.Meter, LengthUnit.Centimeter, 100.0)]
    [InlineData(39.3701, LengthUnit.Inch, LengthUnit.Meter, 1.0)]
    [InlineData(1.0, LengthUnit.Meter, LengthUnit.Inch, 39.3701)]
    [InlineData(3.28084, LengthUnit.Foot, LengthUnit.Meter, 1.0)]
    [InlineData(1.0, LengthUnit.Meter, LengthUnit.Foot, 3.28084)]
    [InlineData(1.09361, LengthUnit.Yard, LengthUnit.Meter, 1.0)]
    [InlineData(1.0, LengthUnit.Meter, LengthUnit.Yard, 1.09361)]
    public void Convert_ShouldConvertCorrectly(double value, LengthUnit fromUnit, LengthUnit toUnit, double expected)
    {
        // Arrange
        var converter = new LengthConverter();

        // Act
        var result = converter.Convert(value, fromUnit, toUnit);

        // Assert
        Assert.Equal(expected, result, 4);
    }
}