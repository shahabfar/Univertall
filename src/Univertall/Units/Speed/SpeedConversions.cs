namespace Univertall.Units.Speed;

/// <summary>
/// Enum representing various speed units.
/// </summary>
public enum SpeedUnit
{
    MetersPerSecond,
    KilometersPerHour,
    MilesPerHour,
    Knots,
    Knots_UK,
    FeetPerSecond,
    YardPerHour,
    Mach,
    Mach_SI
}

/// <summary>
/// Class for converting between different speed units.
/// </summary>
public class SpeedConverter : BaseUnivertall<SpeedUnit>
{
    /// <summary>
    /// Converts the given value from the specified unit to the base unit (MetersPerSecond).
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The value in the base unit (MetersPerSecond).</returns>
    protected override double ToBaseUnit(double value, SpeedUnit fromUnit)
    {
        return fromUnit switch
        {
            SpeedUnit.MetersPerSecond => value,
            SpeedUnit.KilometersPerHour => value / 3.6,
            SpeedUnit.MilesPerHour => value * 0.44704,
            SpeedUnit.Knots => value * 0.5144444444,
            SpeedUnit.Knots_UK => value * 0.5147733333,
            SpeedUnit.FeetPerSecond => value * 0.3048,
            SpeedUnit.YardPerHour => value * 0.000254,
            SpeedUnit.Mach => value * 343.6,
            SpeedUnit.Mach_SI => value * 295.0464000003,
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    /// <summary>
    /// Converts the given value from the base unit (MetersPerSecond) to the specified unit.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The value in the specified unit.</returns>
    protected override double FromBaseUnit(double value, SpeedUnit toUnit)
    {
        return toUnit switch
        {
            SpeedUnit.MetersPerSecond => value,
            SpeedUnit.KilometersPerHour => value * 3.6,
            SpeedUnit.MilesPerHour => value / 0.44704,
            SpeedUnit.Knots => value / 0.5144444444,
            SpeedUnit.Knots_UK => value / 0.5147733333,
            SpeedUnit.FeetPerSecond => value / 0.3048,
            SpeedUnit.YardPerHour => value / 0.000254,
            SpeedUnit.Mach => value / 343.6,
            SpeedUnit.Mach_SI => value / 295.0464000003,
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}

