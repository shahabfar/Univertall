namespace Univertall;

/// <summary>
/// Abstract base class for unit conversion.
/// </summary>
/// <typeparam name="TUnit">The type of unit enumeration.</typeparam>
public abstract class BaseUnivertall<TUnit> where TUnit : Enum
{
    /// <summary>
    /// Converts a value to the base unit.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit of the value to convert from.</param>
    /// <returns>The value in the base unit.</returns>
    protected abstract double ToBaseUnit(double value, TUnit fromUnit);

    /// <summary>
    /// Converts a value from the base unit to the specified unit.
    /// </summary>
    /// <param name="value">The value in the base unit.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The value in the specified unit.</returns>
    protected abstract double FromBaseUnit(double value, TUnit toUnit);

    /// <summary>
    /// Converts a value from one unit to another.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit of the value to convert from.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The converted value.</returns>
    public double Convert(double value, TUnit fromUnit, TUnit toUnit)
    {
        if (fromUnit.Equals(toUnit))
            return value; // No conversion needed

        var valueInBaseUnit = ToBaseUnit(value, fromUnit);
        return FromBaseUnit(valueInBaseUnit, toUnit);
    }
}
