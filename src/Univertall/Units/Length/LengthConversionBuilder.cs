namespace Univertall.Units.Length;

/// <summary>
/// Builder for length conversions.
/// </summary>
public class LengthConversionBuilder
{
    private readonly double _value;
    private LengthUnit _fromUnit;

    /// <summary>
    /// Initializes a new instance of the <see cref="LengthConversionBuilder"/> class with the specified value.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public LengthConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Sets the unit to convert from.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The current instance of <see cref="LengthConversionBuilder"/>.</returns>
    public LengthConversionBuilder From(LengthUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>
    /// Converts the value to the specified unit.
    /// </summary>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double To(LengthUnit toUnit)
    {
        var converter = new LengthConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}
