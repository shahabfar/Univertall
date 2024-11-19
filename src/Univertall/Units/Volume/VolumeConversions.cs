namespace Univertall.Units.Volume;

/// <summary>
/// Enumeration of volume units.
/// </summary>
public enum VolumeUnit
{
    CubicMeter,
    Liter,
    Milliliter,
    Gallon,
    CubicInch,
    CubicFoot,
    CubicYard,
    CubicCentimeter,
    Pint,
    Quart,
    Barrel,
    Teaspoon,
    Tablespoon
}

/// <summary>
/// Converter class for volume units.
/// </summary>
public class VolumeConverter : BaseUnivertall<VolumeUnit>
{
    /// <summary>
    /// Converts the given value from the specified unit to the base unit (CubicMeter).
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The value in the base unit.</returns>
    protected override double ToBaseUnit(double value, VolumeUnit fromUnit)
    {
        return fromUnit switch
        {
            VolumeUnit.CubicMeter => value,
            VolumeUnit.Liter => value / 1000,
            VolumeUnit.Milliliter => value / 1e6,
            VolumeUnit.Gallon => value * 0.003785411784,
            VolumeUnit.CubicInch => value * 0.000016387064,
            VolumeUnit.CubicFoot => value * 0.028316846592,
            VolumeUnit.CubicYard => value * 0.764555,
            VolumeUnit.CubicCentimeter => value / 1e6, // Corrected constant
            VolumeUnit.Pint => value / 2113.38,
            VolumeUnit.Quart => value / 1056.69,
            VolumeUnit.Barrel => value * 0.158987294928,
            VolumeUnit.Teaspoon => value / 202884,
            VolumeUnit.Tablespoon => value / 67628,
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    /// <summary>
    /// Converts the given value from the base unit (CubicMeter) to the specified unit.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The value in the specified unit.</returns>
    protected override double FromBaseUnit(double value, VolumeUnit toUnit)
    {
        return toUnit switch
        {
            VolumeUnit.CubicMeter => value,
            VolumeUnit.Liter => value * 1000,
            VolumeUnit.Milliliter => value * 1e6,
            VolumeUnit.Gallon => value * 264.1720523581484,
            VolumeUnit.CubicInch => value * 61023.7440947323,
            VolumeUnit.CubicFoot => value / 0.028316846592,
            VolumeUnit.CubicYard => value / 0.764555,
            VolumeUnit.CubicCentimeter => value * 1e6, // Corrected constant
            VolumeUnit.Pint => value * 2113.38,
            VolumeUnit.Quart => value * 1056.69,
            VolumeUnit.Barrel => value / 0.158987294928,
            VolumeUnit.Teaspoon => value * 202884,
            VolumeUnit.Tablespoon => value * 67628,
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}

