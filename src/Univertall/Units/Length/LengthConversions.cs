namespace Univertall.Units.Length;
/// <summary>
/// Enumeration of length units.
/// </summary>
public enum LengthUnit
{
    Meter,
    Kilometer,
    Centimeter,
    Millimeter,
    Micrometer,
    Nanometer,
    Mile,
    Yard,
    Foot,
    Inch
}

/// <summary>
/// Converter for length units.
/// </summary>
public class LengthConverter : BaseUnivertall<LengthUnit>
{
    /// <summary>
    /// Converts the specified value from the given unit to the base unit (kilometer).
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The value in the base unit (kilometer).</returns>
    protected override double ToBaseUnit(double value, LengthUnit fromUnit)
    {
        return fromUnit switch
        {
            LengthUnit.Meter => value,
            LengthUnit.Kilometer => value * 1000,
            LengthUnit.Centimeter => value * 0.01,
            LengthUnit.Millimeter => value * 0.001,
            LengthUnit.Micrometer => value * 1e-6,
            LengthUnit.Nanometer => value * 1e-9,
            LengthUnit.Mile => value * 1609.344,
            LengthUnit.Yard => value * 0.9144,
            LengthUnit.Foot => value * 0.3048,
            LengthUnit.Inch => value * 0.0254,
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    protected override double FromBaseUnit(double value, LengthUnit toUnit)
    {
        return toUnit switch
        {
            LengthUnit.Meter => value,
            LengthUnit.Kilometer => value / 1000,
            LengthUnit.Centimeter => value / 0.01,
            LengthUnit.Millimeter => value / 0.001,
            LengthUnit.Micrometer => value / 1e-6,
            LengthUnit.Nanometer => value / 1e-9,
            LengthUnit.Mile => value / 1609.344,
            LengthUnit.Yard => value / 0.9144,
            LengthUnit.Foot => value / 0.3048,
            LengthUnit.Inch => value / 0.0254,
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }

}

