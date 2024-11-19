namespace Univertall.Units.VolumeFlowRate;

/// <summary>
/// Builder for creating volume flow rate conversions.
/// </summary>
public class VolumeFlowRateConversionBuilder
{
    private readonly double _value;
    private VolumeFlowRateUnit _fromUnit;

    /// <summary>
    /// Initializes a new instance of the <see cref="VolumeFlowRateConversionBuilder"/> class.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public VolumeFlowRateConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>
    /// Sets the unit to convert from.
    /// </summary>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The current instance of <see cref="VolumeFlowRateConversionBuilder"/>.</returns>
    public VolumeFlowRateConversionBuilder From(VolumeFlowRateUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>
    /// Converts the value to the specified unit.
    /// </summary>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double To(VolumeFlowRateUnit toUnit)
    {
        var converter = new VolumeFlowRateConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}
