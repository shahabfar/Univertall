namespace Univertall.Units.Force;

/// <summary>
/// Builder class for force conversions.
/// </summary>
public class ForceConversionBuilder
{
    private readonly double _value;
    private ForceUnit _fromUnit;

    /// <summary>
    /// Initializes a new instance of the <see cref="ForceConversionBuilder"/> class.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public ForceConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Sets the unit to convert from.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The current instance of <see cref="ForceConversionBuilder"/>.</returns>
    public ForceConversionBuilder From(ForceUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>
    /// Converts the value to the specified unit.
    /// </summary>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double To(ForceUnit toUnit)
    {
        var converter = new ForceConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}
