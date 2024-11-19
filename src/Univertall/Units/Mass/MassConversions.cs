namespace Univertall.Units.Mass;

/// <summary>
/// Enumeration of mass units.
/// </summary>
public enum MassUnit
{
    Kilogram,
    Gram,
    Milligram,
    Microgram,
    Ton,
    Pound,
    Ounce,
    Stone,
    Carat,
    LongTon,
    ShortTon
}

/// <summary>
/// Converter class for mass units.
/// </summary>
public class MassConverter : BaseUnivertall<MassUnit>
{
    /// <summary>
    /// Converts the given value from the specified unit to the base unit (Kilogram).
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The value in the base unit (Kilogram).</returns>
    protected override double ToBaseUnit(double value, MassUnit fromUnit)
    {
        return fromUnit switch
        {
            MassUnit.Kilogram => value,
            MassUnit.Gram => value / 1000,
            MassUnit.Milligram => value / 1e6,
            MassUnit.Microgram => value / 1e9,
            MassUnit.Ton => value * 1000,
            MassUnit.Pound => value * 0.45359237,
            MassUnit.Ounce => value * 0.028349523125,
            MassUnit.Stone => value * 6.35029,
            MassUnit.Carat => value / 5000,
            MassUnit.LongTon => value * 1016.05,
            MassUnit.ShortTon => value * 907.184,
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    /// <summary>
    /// Converts the given value from the base unit (Kilogram) to the specified unit.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The value in the specified unit.</returns>
    protected override double FromBaseUnit(double value, MassUnit toUnit)
    {
        return toUnit switch
        {
            MassUnit.Kilogram => value,
            MassUnit.Gram => value * 1000,
            MassUnit.Milligram => value * 1e6,
            MassUnit.Microgram => value * 1e9,
            MassUnit.Ton => value / 1000,
            MassUnit.Pound => value / 0.45359237,
            MassUnit.Ounce => value / 0.028349523125,
            MassUnit.Stone => value / 6.35029,
            MassUnit.Carat => value * 5000,
            MassUnit.LongTon => value / 1016.05,
            MassUnit.ShortTon => value / 907.184,
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}

