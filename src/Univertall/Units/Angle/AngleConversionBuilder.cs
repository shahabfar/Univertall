namespace Univertall.Units.Angle;

/// <summary>
/// Builder class for converting angle units.
/// </summary>
public class AngleConversionBuilder
{
    private readonly double _value;
    private AngleUnit _fromUnit;

    /// <summary>
    /// Initializes a new instance of the <see cref="AngleConversionBuilder"/> class.
    /// </summary>
    /// <param name="value">The value to be converted.</param>
    public AngleConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Sets the unit to convert from.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The current instance of <see cref="AngleConversionBuilder"/>.</returns>
    public AngleConversionBuilder From(AngleUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>
    /// Converts the value to the specified unit.
    /// </summary>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double To(AngleUnit toUnit)
    {
        var converter = new AngleConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}
