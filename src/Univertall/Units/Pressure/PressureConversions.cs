namespace Univertall.Units.Pressure;

/// <summary>
/// Enum representing various pressure units.
/// </summary>
public enum PressureUnit
{
    Pascal,
    Bar,
    PSI,
    Torr,
    MetersOfWater,
    InchesOfMercury,
    Atmosphere
}

/// <summary>
/// Class for converting between different pressure units.
/// </summary>
public class PressureConverter : BaseUnivertall<PressureUnit>
{
    /// <summary>
    /// Converts the given value from the specified unit to the base unit (Pascal).
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The value in the base unit (Pascal).</returns>
    protected override double ToBaseUnit(double value, PressureUnit fromUnit)
    {
        return fromUnit switch
        {
            PressureUnit.Pascal => value,
            PressureUnit.Bar => value * 100000,
            PressureUnit.PSI => value * 6894.757,
            PressureUnit.Torr => value * 133.322368,
            PressureUnit.MetersOfWater => value * 9806.65, // Corrected constant
            PressureUnit.InchesOfMercury => value * 3386.389,
            PressureUnit.Atmosphere => value * 101325,
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    /// <summary>
    /// Converts the given value from the base unit (Pascal) to the specified unit.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The value in the specified unit.</returns>
    protected override double FromBaseUnit(double value, PressureUnit toUnit)
    {
        return toUnit switch
        {
            PressureUnit.Pascal => value,
            PressureUnit.Bar => value / 100000,
            PressureUnit.PSI => value * 0.000145038,
            PressureUnit.Torr => value / 133.322368,
            PressureUnit.MetersOfWater => value / 9806.65, // Corrected constant
            PressureUnit.InchesOfMercury => value / 3386.389,
            PressureUnit.Atmosphere => value / 101325,
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}

