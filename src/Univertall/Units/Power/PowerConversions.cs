namespace Univertall.Units.Power;
/// <summary>
/// Enumeration of power units.
/// </summary>
public enum PowerUnit
{
    Watt,
    MetricHorsepower,
    MechanicalHorsepower,
    BTUPerSecond,
    Kilowatt,
    Megawatt
}

/// <summary>
/// Converter class for power units.
/// </summary>
public class PowerConverter : BaseUnivertall<PowerUnit>
{
    /// <summary>
    /// Converts the specified value from the given unit to the base unit (Watt).
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The value in the base unit (Watt).</returns>
    protected override double ToBaseUnit(double value, PowerUnit fromUnit)
    {
        return fromUnit switch
        {
            PowerUnit.Watt => value,
            PowerUnit.MetricHorsepower => value * 735.49875,       // Metric horsepower
            PowerUnit.MechanicalHorsepower => value * 745.69987158227022, // Mechanical horsepower
            PowerUnit.BTUPerSecond => value * 1055.05585262,            // BTU/second
            PowerUnit.Kilowatt => value * 1000,                   // Kilowatt
            PowerUnit.Megawatt => value * 1_000_000,              // Megawatt
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    /// <summary>
    /// Converts the specified value from the base unit (Watt) to the given unit.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The value in the specified unit.</returns>
    protected override double FromBaseUnit(double value, PowerUnit toUnit)
    {
        return toUnit switch
        {
            PowerUnit.Watt => value,
            PowerUnit.MetricHorsepower => value / 735.49875,       // Metric horsepower
            PowerUnit.MechanicalHorsepower => value / 745.69987158227022, // Mechanical horsepower
            PowerUnit.BTUPerSecond => value / 1055.05585262,            // BTU/second
            PowerUnit.Kilowatt => value / 1000,                   // Kilowatt
            PowerUnit.Megawatt => value / 1_000_000,              // Megawatt
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}

