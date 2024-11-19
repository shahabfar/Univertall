namespace Univertall.Units.Pressure;

/// <summary>
/// Builder class for creating pressure conversion operations.
/// </summary>
public class PressureConversionBuilder
{
    private readonly double _value;
    private PressureUnit _fromUnit;

    public PressureConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Sets the unit to convert from.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The current instance of <see cref="PressureConversionBuilder"/>.</returns>
    public PressureConversionBuilder From(PressureUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>
    /// Converts the value to the specified unit.
    /// </summary>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double To(PressureUnit toUnit)
    {
        var converter = new PressureConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}
