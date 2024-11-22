namespace Univertall.Units.Speed;

public class SpeedConversionBuilder
{
    private readonly double _value;
    private SpeedUnit _fromUnit;

    public SpeedConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Sets the unit to convert from.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The current instance of <see cref="SpeedConversionBuilder"/>.</returns>
    public SpeedConversionBuilder From(SpeedUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>
    /// Converts the value to the specified unit.
    /// </summary>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double To(SpeedUnit toUnit)
    {
        var converter = new SpeedConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}