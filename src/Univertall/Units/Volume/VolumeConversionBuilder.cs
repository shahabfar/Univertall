namespace Univertall.Units.Volume;

/// <summary>
/// Builder class for volume conversions.
/// </summary>
public class VolumeConversionBuilder
{
    private readonly double _value;
    private VolumeUnit _fromUnit;

    /// <summary>
    /// Initializes a new instance of the <see cref="VolumeConversionBuilder"/> class.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public VolumeConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Sets the unit to convert from.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The current instance of <see cref="VolumeConversionBuilder"/>.</returns>
    public VolumeConversionBuilder From(VolumeUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>
    /// Converts the value to the specified unit.
    /// </summary>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double To(VolumeUnit toUnit)
    {
        var converter = new VolumeConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}
