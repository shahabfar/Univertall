using Univertall.Units.Power;

namespace Univertall.Tests;

public class PowerConversionsTests
{
    [Theory]
    [InlineData(1.0, PowerUnit.Watt, 1.0)]
    [InlineData(1.0, PowerUnit.MetricHorsepower, 735.49875)]
    [InlineData(1.0, PowerUnit.BTUPerSecond, 1055.05585)]
    [InlineData(1.0, PowerUnit.Kilowatt, 1000.0)]
    [InlineData(1.0, PowerUnit.Megawatt, 1_000_000.0)]
    public void ToBaseUnit_ShouldConvertCorrectly(double value, PowerUnit fromUnit, double expected)
    {
        // Arrange
        var converter = new PowerConverter();

        // Act
        var result = converter.Convert(value, fromUnit, PowerUnit.Watt);

        // Assert
        Assert.Equal(expected, result, 5);
    }

    [Theory]
    [InlineData(1.0, PowerUnit.Watt, 1.0)]
    [InlineData(735.5, PowerUnit.MetricHorsepower, 1.0)]
    [InlineData(1055.06, PowerUnit.BTUPerSecond, 1.0)]
    [InlineData(1000.0, PowerUnit.Kilowatt, 1.0)]
    [InlineData(1_000_000.0, PowerUnit.Megawatt, 1.0)]
    public void FromBaseUnit_ShouldConvertCorrectly(double value, PowerUnit toUnit, double expected)
    {
        // Arrange
        var converter = new PowerConverter();

        // Act
        var result = converter.Convert(value, PowerUnit.Watt, toUnit);

        // Assert
        Assert.Equal(expected, result, 5);
    }

    [Theory]
    [InlineData(1.0, PowerUnit.Watt, PowerUnit.MetricHorsepower, 0.00135962)]   // 1 Watt = 1 / 735.49875 HP
    [InlineData(1.0, PowerUnit.Watt, PowerUnit.BTUPerSecond, 0.000947817)]      // 1 Watt = 1 / 1055.05585 BTU/s
    [InlineData(1.0, PowerUnit.Watt, PowerUnit.Kilowatt, 0.001)]                // 1 Watt = 1 / 1000 Kilowatts
    [InlineData(1.0, PowerUnit.Watt, PowerUnit.Megawatt, 0.000001)]             // 1 Watt = 1 / 1,000,000 Megawatts
    [InlineData(1.0, PowerUnit.MetricHorsepower, PowerUnit.Watt, 735.49875)]    // 1 HP = 735.49875 Watts
    [InlineData(1.0, PowerUnit.MetricHorsepower, PowerUnit.BTUPerSecond, 0.697119)] // 1 HP = 735.49875 / 1055.05585 BTU/s
    [InlineData(1.0, PowerUnit.MetricHorsepower, PowerUnit.Kilowatt, 0.735499)] // 1 HP = 735.49875 / 1000 Kilowatts
    [InlineData(1.0, PowerUnit.MetricHorsepower, PowerUnit.Megawatt, 0.0007355)] // 1 HP = 735.49875 / 1,000,000 Megawatts
    [InlineData(1.0, PowerUnit.BTUPerSecond, PowerUnit.Watt, 1055.05585)]       // 1 BTU/s = 1055.05585 Watts
    [InlineData(1.0, PowerUnit.BTUPerSecond, PowerUnit.MetricHorsepower, 1.43448)] // 1 BTU/s = 1055.05585 / 735.49875 HP
    [InlineData(1.0, PowerUnit.BTUPerSecond, PowerUnit.Kilowatt, 1.055056)]     // 1 BTU/s = 1055.05585 / 1000 Kilowatts
    [InlineData(1.0, PowerUnit.BTUPerSecond, PowerUnit.Megawatt, 0.001055)]     // 1 BTU/s = 1055.05585 / 1,000,000 Megawatts
    [InlineData(1.0, PowerUnit.Kilowatt, PowerUnit.Watt, 1000.0)]               // 1 Kilowatt = 1000 Watts
    [InlineData(1.0, PowerUnit.Kilowatt, PowerUnit.MetricHorsepower, 1.359622)] // 1 Kilowatt = 1000 / 735.49875 HP
    [InlineData(1.0, PowerUnit.Kilowatt, PowerUnit.BTUPerSecond, 0.947817)]     // 1 Kilowatt = 1000 / 1055.05585 BTU/s
    [InlineData(1.0, PowerUnit.Kilowatt, PowerUnit.Megawatt, 0.001)]            // 1 Kilowatt = 1000 / 1,000,000 Megawatts
    [InlineData(1.0, PowerUnit.Megawatt, PowerUnit.Watt, 1_000_000.0)]          // 1 Megawatt = 1,000,000 Watts
    [InlineData(1.0, PowerUnit.Megawatt, PowerUnit.MetricHorsepower, 1359.62162)] // 1 Megawatt = 1,000,000 / 735.49875 HP
    [InlineData(1.0, PowerUnit.Megawatt, PowerUnit.BTUPerSecond, 947.81712)]      // 1 Megawatt = 1,000,000 / 1055.05585 BTU/s
    [InlineData(1.0, PowerUnit.Megawatt, PowerUnit.Kilowatt, 1000.0)]           // 1 Megawatt = 1,000,000 / 1000 Kilowatts
    public void Convert_ShouldConvertCorrectly(double value, PowerUnit fromUnit, PowerUnit toUnit, double expected)
    {
        // Arrange
        var converter = new PowerConverter();

        // Act
        var result = converter.Convert(value, fromUnit, toUnit);

        // Assert
        Assert.Equal(expected, result, 5); // Allowing up to 5 decimal places of precision
    }

}