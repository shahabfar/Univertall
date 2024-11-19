namespace Univertall.Units.Digital;

/// <summary>
/// Enumeration of digital units.
/// </summary>
public enum DigitalUnit
{
    Bit,
    Byte,
    Kilobyte,
    Megabyte,
    Gigabyte,
    Terabyte
}

/// <summary>
/// Converter for digital units.
/// </summary>
public class DigitalConverter : BaseUnivertall<DigitalUnit>
{
    /// <summary>
    /// Converts the specified value from the given unit to the base unit (Byte).
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The value in the base unit (Byte).</returns>
    protected override double ToBaseUnit(double value, DigitalUnit fromUnit)
    {
        return fromUnit switch
        {
            DigitalUnit.Bit => value / 8.0,
            DigitalUnit.Byte => value,
            DigitalUnit.Kilobyte => value * 1024.0,
            DigitalUnit.Megabyte => value * 1024.0 * 1024.0,
            DigitalUnit.Gigabyte => value * 1024.0 * 1024.0 * 1024.0,
            DigitalUnit.Terabyte => value * 1024.0 * 1024.0 * 1024.0 * 1024.0,
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    /// <summary>
    /// Converts the specified value from the base unit (Byte) to the given unit.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The value in the specified unit.</returns>
    protected override double FromBaseUnit(double value, DigitalUnit toUnit)
    {
        return toUnit switch
        {
            DigitalUnit.Bit => value * 8.0,
            DigitalUnit.Byte => value,
            DigitalUnit.Kilobyte => value / 1024.0,
            DigitalUnit.Megabyte => value / (1024.0 * 1024.0),
            DigitalUnit.Gigabyte => value / (1024.0 * 1024.0 * 1024.0),
            DigitalUnit.Terabyte => value / (1024.0 * 1024.0 * 1024.0 * 1024.0),
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}

