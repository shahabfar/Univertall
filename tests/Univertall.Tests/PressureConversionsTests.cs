using Univertall.Units.Pressure;

namespace Univertall.Tests;

public class PressureConversionsTests
{
    [Theory]
    [InlineData(1.0, PressureUnit.Pascal, 1.0)]
    [InlineData(1.0, PressureUnit.Bar, 100000.0)]
    [InlineData(1.0, PressureUnit.PSI, 6894.757)]
    [InlineData(1.0, PressureUnit.Torr, 133.322)]
    [InlineData(1.0, PressureUnit.MetersOfWater, 9806.65)]
    [InlineData(1.0, PressureUnit.InchesOfMercury, 3386.39)]
    [InlineData(1.0, PressureUnit.Atmosphere, 101325.0)]
    public void ToBaseUnit_ShouldConvertCorrectly(double value, PressureUnit fromUnit, double expected)
    {
        // Arrange
        var converter = new PressureConverter();

        // Act
        var result = converter.Convert(value, fromUnit, PressureUnit.Pascal);

        // Assert
        Assert.Equal(expected, result, 2);
    }

    [Theory]
    [InlineData(1.0, PressureUnit.Pascal, 1.0)]
    [InlineData(100000.0, PressureUnit.Bar, 1.0)]
    [InlineData(6894.757, PressureUnit.PSI, 1.0)]
    [InlineData(133.322, PressureUnit.Torr, 1.0)]
    [InlineData(9806.65, PressureUnit.MetersOfWater, 1.0)]
    [InlineData(3386.39, PressureUnit.InchesOfMercury, 1.0)]
    [InlineData(101325.0, PressureUnit.Atmosphere, 1.0)]
    public void FromBaseUnit_ShouldConvertCorrectly(double value, PressureUnit toUnit, double expected)
    {
        // Arrange
        var converter = new PressureConverter();

        // Act
        var result = converter.Convert(value, PressureUnit.Pascal, toUnit);

        // Assert
        Assert.Equal(expected, result, 2);
    }

    [Theory]
    [InlineData(1.0, PressureUnit.Pascal, PressureUnit.Bar, 0.00001)]
    [InlineData(1.0, PressureUnit.Pascal, PressureUnit.PSI, 0.000145038)]
    [InlineData(1.0, PressureUnit.Pascal, PressureUnit.Torr, 0.00750061683)]
    [InlineData(1.0, PressureUnit.Pascal, PressureUnit.MetersOfWater, 0.000101972)]
    [InlineData(1.0, PressureUnit.Pascal, PressureUnit.InchesOfMercury, 0.0002953)]
    [InlineData(1.0, PressureUnit.Pascal, PressureUnit.Atmosphere, 0.00000986923)]
    [InlineData(1.0, PressureUnit.Bar, PressureUnit.Pascal, 100000.0)]
    [InlineData(1.0, PressureUnit.PSI, PressureUnit.Pascal, 6894.757)]
    [InlineData(1.0, PressureUnit.Torr, PressureUnit.Pascal, 133.322368)]
    [InlineData(1.0, PressureUnit.MetersOfWater, PressureUnit.Pascal, 9806.65)]
    [InlineData(1.0, PressureUnit.InchesOfMercury, PressureUnit.Pascal, 3386.389)]
    [InlineData(1.0, PressureUnit.Atmosphere, PressureUnit.Pascal, 101325.0)]
    public void Convert_ShouldConvertCorrectly(double value, PressureUnit fromUnit, PressureUnit toUnit, double expected)
    {
        // Arrange
        var converter = new PressureConverter();

        // Act
        var result = converter.Convert(value, fromUnit, toUnit);

        // Assert
        Assert.Equal(expected, result, 5);
    }
}