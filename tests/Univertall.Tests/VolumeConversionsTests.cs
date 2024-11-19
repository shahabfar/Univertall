using Univertall.Units.Volume;

namespace Univertall.Tests;

public class VolumeConversionsTests
{
    [Theory]
    [InlineData(1.0, VolumeUnit.CubicMeter, 1.0)]
    [InlineData(1.0, VolumeUnit.Liter, 0.001)]
    [InlineData(1.0, VolumeUnit.Milliliter, 0.000001)]
    [InlineData(1.0, VolumeUnit.Gallon, 0.00378541)]
    [InlineData(1.0, VolumeUnit.CubicInch, 0.0000163871)]
    [InlineData(1.0, VolumeUnit.CubicFoot, 0.0283168)]
    [InlineData(1.0, VolumeUnit.CubicYard, 0.764555)]
    [InlineData(1.0, VolumeUnit.CubicCentimeter, 0.000001)]
    [InlineData(1.0, VolumeUnit.Pint, 0.000473176)]
    [InlineData(1.0, VolumeUnit.Quart, 0.000946353)]
    [InlineData(1.0, VolumeUnit.Barrel, 0.158987)]
    [InlineData(1.0, VolumeUnit.Teaspoon, 0.00000492892)]
    [InlineData(1.0, VolumeUnit.Tablespoon, 0.0000147868)]
    public void ToBaseUnit_ShouldConvertCorrectly(double value, VolumeUnit fromUnit, double expected)
    {
        // Arrange
        var converter = new VolumeConverter();

        // Act
        var result = converter.Convert(value, fromUnit, VolumeUnit.CubicMeter);

        // Assert
        Assert.Equal(expected, result, 5);
    }

    [Theory]
    [InlineData(1.0, VolumeUnit.CubicMeter, 1)]
    [InlineData(0.001, VolumeUnit.Liter, 1.0)]
    [InlineData(0.000001, VolumeUnit.Milliliter, 1.0)]
    [InlineData(0.00378541, VolumeUnit.Gallon, 1.0)]
    [InlineData(0.0000163871, VolumeUnit.CubicInch, 1.0)]
    [InlineData(0.0283168, VolumeUnit.CubicFoot, 1.0)]
    [InlineData(0.764555, VolumeUnit.CubicYard, 1.0)]
    [InlineData(0.000001, VolumeUnit.CubicCentimeter, 1.0)]
    [InlineData(0.000473176, VolumeUnit.Pint, 1.0)]
    [InlineData(0.000946353, VolumeUnit.Quart, 1.0)]
    [InlineData(0.158987, VolumeUnit.Barrel, 1.0)]
    [InlineData(0.00000492892, VolumeUnit.Teaspoon, 1.0)]
    [InlineData(0.0000147868, VolumeUnit.Tablespoon, 1.0)]
    public void FromBaseUnit_ShouldConvertCorrectly(double value, VolumeUnit toUnit, double expected)
    {
        // Arrange
        var converter = new VolumeConverter();

        // Act
        var result = converter.Convert(value, VolumeUnit.CubicMeter, toUnit);

        // Assert
        Assert.Equal(expected, result, 5);
    }

    [Theory]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.Liter, 1000.0)]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.Milliliter, 1e6)]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.Gallon, 264.1720523581484)]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.CubicInch, 61023.7440947323)]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.CubicFoot, 35.31466672148859)]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.CubicYard, 1.30795)]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.CubicCentimeter, 1e6)]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.Pint, 2113.38)]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.Quart, 1056.69)]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.Barrel, 6.289810770432)]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.Teaspoon, 202884)]
    [InlineData(1.0, VolumeUnit.CubicMeter, VolumeUnit.Tablespoon, 67628)]
    [InlineData(1.0, VolumeUnit.Liter, VolumeUnit.CubicMeter, 0.001)]
    [InlineData(1.0, VolumeUnit.Milliliter, VolumeUnit.CubicMeter, 0.000001)]
    [InlineData(1.0, VolumeUnit.Gallon, VolumeUnit.CubicMeter, 0.003785411784)]
    [InlineData(1.0, VolumeUnit.CubicInch, VolumeUnit.CubicMeter, 0.000016387064)]
    [InlineData(1.0, VolumeUnit.CubicFoot, VolumeUnit.CubicMeter, 0.028316846592)]
    [InlineData(1.0, VolumeUnit.CubicYard, VolumeUnit.CubicMeter, 0.764555)]
    [InlineData(1.0, VolumeUnit.CubicCentimeter, VolumeUnit.CubicMeter, 1e-6)]
    [InlineData(1.0, VolumeUnit.Pint, VolumeUnit.CubicMeter, 0.000473176)]
    [InlineData(1.0, VolumeUnit.Quart, VolumeUnit.CubicMeter, 0.000946353)]
    [InlineData(1.0, VolumeUnit.Barrel, VolumeUnit.CubicMeter, 0.158987294928)]
    [InlineData(1.0, VolumeUnit.Teaspoon, VolumeUnit.CubicMeter, 0.00000492892)]
    [InlineData(1.0, VolumeUnit.Tablespoon, VolumeUnit.CubicMeter, 0.0000147868)]
    public void Convert_ShouldConvertCorrectly(double value, VolumeUnit fromUnit, VolumeUnit toUnit, double expected)
    {
        // Arrange
        var converter = new VolumeConverter();

        // Act
        var result = converter.Convert(value, fromUnit, toUnit);

        // Assert
        Assert.Equal(expected, result, 5);
    }
}