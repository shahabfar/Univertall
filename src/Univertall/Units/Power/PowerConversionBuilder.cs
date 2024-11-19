namespace Univertall.Units.Power;

/// <summary>
/// Builder class for power conversions.
/// </summary>
public class PowerConversionBuilder
{
    private readonly double _value;
    private PowerUnit _fromUnit;

    public PowerConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Sets the unit to convert from.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The current instance of <see cref="PowerConversionBuilder"/>.</returns>
    public PowerConversionBuilder From(PowerUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>
    /// Converts the value to the specified unit.
    /// </summary>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double To(PowerUnit toUnit)
    {
        var converter = new PowerConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}
