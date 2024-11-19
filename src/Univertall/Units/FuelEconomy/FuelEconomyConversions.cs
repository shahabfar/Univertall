namespace Univertall.Units.FuelEconomy;
/// <summary>  
/// Enumeration of fuel economy units.  
/// </summary>  
public enum FuelEconomyUnit
{
    /// <summary>  
    /// Miles per gallon (US).  
    /// </summary>  
    MilesPerGallon,

    /// <summary>  
    /// Liters per 100 kilometers.  
    /// </summary>  
    LitersPer100Km,

    /// <summary>  
    /// Kilometers per liter.  
    /// </summary>  
    KmPerLiter,

    /// <summary>  
    /// Miles per gallon (Imperial).  
    /// </summary>  
    MilesPerGallonImperial
}

/// <summary>  
/// Converter for fuel economy units.  
/// </summary>  
public class FuelEconomyConverter : BaseUnivertall<FuelEconomyUnit>
{
    /// <summary>  
    /// Converts the specified value to the base unit (Liters per 100 kilometers).  
    /// </summary>  
    /// <param name="value">The value to convert.</param>  
    /// <param name="fromUnit">The unit of the value to convert from.</param>  
    /// <returns>The value in the base unit.</returns>  
    protected override double ToBaseUnit(double value, FuelEconomyUnit fromUnit)
    {
        return fromUnit switch
        {
            FuelEconomyUnit.MilesPerGallon => 235.215 / value,
            FuelEconomyUnit.LitersPer100Km => value,
            FuelEconomyUnit.KmPerLiter => 235.215 / (value * 2.35215),
            FuelEconomyUnit.MilesPerGallonImperial => 282.481 / value,
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    /// <summary>  
    /// Converts the specified value from the base unit (Liters per 100 kilometers) to the target unit.  
    /// </summary>  
    /// <param name="value">The value to convert.</param>  
    /// <param name="toUnit">The unit to convert the value to.</param>  
    /// <returns>The value in the target unit.</returns>  
    protected override double FromBaseUnit(double value, FuelEconomyUnit toUnit)
    {
        return toUnit switch
        {
            FuelEconomyUnit.MilesPerGallon => 235.215 / value,
            FuelEconomyUnit.LitersPer100Km => value,
            FuelEconomyUnit.KmPerLiter => 235.215 / (value * 2.35215),
            FuelEconomyUnit.MilesPerGallonImperial => 282.481 / value,
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}

