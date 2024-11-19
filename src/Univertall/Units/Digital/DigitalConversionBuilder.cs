namespace Univertall.Units.Digital;

/// <summary>
/// Builder for digital unit conversions.
/// </summary>
public class DigitalConversionBuilder
{
    private double _value;
    private DigitalUnit _fromUnit;

    public DigitalConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Sets the unit to convert from.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The current instance of <see cref="DigitalConversionBuilder"/>.</returns>
    public DigitalConversionBuilder From(DigitalUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>
    /// Converts the value to the specified unit.
    /// </summary>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double To(DigitalUnit toUnit)
    {
        var converter = new DigitalConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}
