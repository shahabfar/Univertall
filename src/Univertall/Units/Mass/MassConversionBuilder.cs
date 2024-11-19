namespace Univertall.Units.Mass;

/// <summary>
/// Builder class for mass conversions.
/// </summary>
public class MassConversionBuilder
{
    private readonly double _value;
    private MassUnit _fromUnit;

    /// <summary>
    /// Initializes a new instance of the <see cref="MassConversionBuilder"/> class.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public MassConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Sets the unit to convert from.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The current instance of <see cref="MassConversionBuilder"/>.</returns>
    public MassConversionBuilder From(MassUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>
    /// Converts the value to the specified unit.
    /// </summary>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double To(MassUnit toUnit)
    {
        var converter = new MassConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}