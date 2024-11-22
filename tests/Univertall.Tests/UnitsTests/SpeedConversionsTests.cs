using Univertall.Units.Speed;

namespace Univertall.Tests.UnitsTests;

public class SpeedConversionsTests
{
    [Theory]
    [InlineData(1.0, SpeedUnit.MetersPerSecond, 1.0)]
    [InlineData(3.6, SpeedUnit.KilometersPerHour, 1.0)]
    [InlineData(2.23694, SpeedUnit.MilesPerHour, 1.0)]
    [InlineData(1.94384, SpeedUnit.Knots, 1.0)]
    [InlineData(3.28084, SpeedUnit.FeetPerSecond, 1.0)]
    [InlineData(3937.01, SpeedUnit.YardPerHour, 1.0)]
    [InlineData(0.00291036, SpeedUnit.Mach, 1.0)]
    [InlineData(0.0033893, SpeedUnit.Mach_SI, 1.0)]
    public void ToBaseUnit_ShouldConvertCorrectly(double value, SpeedUnit fromUnit, double expected)
    {
        // Arrange
        var converter = new SpeedConverter();

        // Act
        var result = converter.Convert(value, fromUnit, SpeedUnit.MetersPerSecond);

        // Assert
        Assert.Equal(expected, result, 5);
    }

    [Theory]
    [InlineData(1.0, SpeedUnit.MetersPerSecond, 1.0)]
    [InlineData(1.0, SpeedUnit.KilometersPerHour, 3.6)]
    [InlineData(1.0, SpeedUnit.MilesPerHour, 2.23694)]
    [InlineData(1.0, SpeedUnit.Knots, 1.94384)]
    [InlineData(1.0, SpeedUnit.FeetPerSecond, 3.28084)]
    [InlineData(1.0, SpeedUnit.YardPerHour, 3937.007874)]
    [InlineData(1.0, SpeedUnit.Mach, 0.0029103609)]
    [InlineData(1.0, SpeedUnit.Mach_SI, 0.0033892974)]
    public void FromBaseUnit_ShouldConvertCorrectly(double value, SpeedUnit toUnit, double expected)
    {
        // Arrange
        var converter = new SpeedConverter();

        // Act
        var result = converter.Convert(value, SpeedUnit.MetersPerSecond, toUnit);

        // Assert
        Assert.Equal(expected, result, 5);
    }

    [Theory]
    [InlineData(1.0, SpeedUnit.MetersPerSecond, SpeedUnit.KilometersPerHour, 3.6)]
    [InlineData(1.0, SpeedUnit.KilometersPerHour, SpeedUnit.MetersPerSecond, 0.27778)]
    [InlineData(1.0, SpeedUnit.MilesPerHour, SpeedUnit.KilometersPerHour, 1.60934)]
    [InlineData(1.0, SpeedUnit.Knots, SpeedUnit.MilesPerHour, 1.15078)]
    [InlineData(1.0, SpeedUnit.FeetPerSecond, SpeedUnit.MetersPerSecond, 0.3048)]
    [InlineData(1.0, SpeedUnit.YardPerHour, SpeedUnit.MetersPerSecond, 0.000254)]
    [InlineData(1.0, SpeedUnit.Mach, SpeedUnit.MetersPerSecond, 343.6)]
    [InlineData(1.0, SpeedUnit.Mach_SI, SpeedUnit.MetersPerSecond, 295.0464)]
    public void Convert_ShouldConvertCorrectly(double value, SpeedUnit fromUnit, SpeedUnit toUnit, double expected)
    {
        // Arrange
        var converter = new SpeedConverter();

        // Act
        var result = converter.Convert(value, fromUnit, toUnit);

        // Assert
        Assert.Equal(expected, result, 5);
    }
}
