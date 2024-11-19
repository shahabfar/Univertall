namespace Univertall.Units.Temperature;

/// <summary>
/// Builder class for temperature conversions.
/// </summary>
public class TemperatureConversionBuilder
{
    private readonly double _value;
    private TemperatureUnit _fromUnit;

    /// <summary>
    /// Initializes a new instance of the <see cref="TemperatureConversionBuilder"/> class.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public TemperatureConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Sets the unit to convert from.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The current instance of <see cref="TemperatureConversionBuilder"/>.</returns>
    public TemperatureConversionBuilder From(TemperatureUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>
    /// Converts the value to the specified unit.
    /// </summary>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double To(TemperatureUnit toUnit)
    {
        var converter = new TemperatureConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}
