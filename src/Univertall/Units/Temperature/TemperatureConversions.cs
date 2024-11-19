namespace Univertall.Units.Temperature;

/// <summary>
/// Enumeration of temperature units.
/// </summary>
public enum TemperatureUnit
{
    Celsius,
    Fahrenheit,
    Kelvin,
    Rankine,
    Delisle,
    Newton,
    /// <summary>
    /// Réaumur scale. This unit is not commonly used today.
    /// </summary>
    Reaumur,
    /// <summary>
    /// Rømer scale. This unit is not commonly used today.
    /// </summary>
    Romer
}

/// <summary>
/// Converter class for temperature units.
/// </summary>
public class TemperatureConverter : BaseUnivertall<TemperatureUnit>
{
    /// <summary>
    /// Converts the given value from the specified unit to the base unit (Celsius).
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The value in the base unit (Celsius).</returns>
    protected override double ToBaseUnit(double value, TemperatureUnit fromUnit)
    {
        return fromUnit switch
        {
            TemperatureUnit.Celsius => value,
            TemperatureUnit.Fahrenheit => (value - 32) * 5 / 9,
            TemperatureUnit.Kelvin => value - 273.15,
            TemperatureUnit.Rankine => (value - 491.67) * 5 / 9,
            TemperatureUnit.Delisle => 100 - value * 2 / 3,
            TemperatureUnit.Newton => value * 100 / 33,
            TemperatureUnit.Reaumur => value * 5 / 4,
            TemperatureUnit.Romer => (value - 7.5) * 40 / 21,
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    /// <summary>
    /// Converts the given value from the base unit (Celsius) to the specified unit.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The value in the specified unit.</returns>
    protected override double FromBaseUnit(double value, TemperatureUnit toUnit)
    {
        return toUnit switch
        {
            TemperatureUnit.Celsius => value,
            TemperatureUnit.Fahrenheit => value * 9 / 5 + 32,
            TemperatureUnit.Kelvin => value + 273.15,
            TemperatureUnit.Rankine => value * 9 / 5 + 491.67,
            TemperatureUnit.Delisle => (100 - value) * 3 / 2,
            TemperatureUnit.Newton => value * 33 / 100,
            TemperatureUnit.Reaumur => value * 4 / 5,
            TemperatureUnit.Romer => value * 21 / 40 + 7.5,
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}

