namespace Univertall.Units.Force;

/// <summary>
/// Enumeration of force units.
/// </summary>
public enum ForceUnit
{
    Newton,
    PoundForce,
    KilogramForce,
    Kilonewton,
    Dyne,
    GramForce,
    OunceForce
}

/// <summary>
/// Converter class for force units.
/// </summary>
public class ForceConverter : BaseUnivertall<ForceUnit>
{
    /// <summary>
    /// Converts the specified value from the given unit to the base unit (Newton).
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The value in the base unit (Newton).</returns>
    protected override double ToBaseUnit(double value, ForceUnit fromUnit)
    {
        return fromUnit switch
        {
            ForceUnit.Newton => value,
            ForceUnit.PoundForce => value / 0.224809,
            ForceUnit.KilogramForce => value / 0.101972,
            ForceUnit.Kilonewton => value * 1000,
            ForceUnit.Dyne => value / 1e5,
            ForceUnit.GramForce => value / 101.9716213,
            ForceUnit.OunceForce => value / 3.5969430896,
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    /// <summary>
    /// Converts the specified value from the base unit (Newton) to the given unit.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The value in the specified unit.</returns>
    protected override double FromBaseUnit(double value, ForceUnit toUnit)
    {
        return toUnit switch
        {
            ForceUnit.Newton => value,
            ForceUnit.PoundForce => value * 0.224809,
            ForceUnit.KilogramForce => value * 0.101972,
            ForceUnit.Kilonewton => value / 1000,
            ForceUnit.Dyne => value * 1e5,
            ForceUnit.GramForce => value * 101.9716213,
            ForceUnit.OunceForce => value * 3.5969430896,
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}

