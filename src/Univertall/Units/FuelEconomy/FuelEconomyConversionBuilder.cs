namespace Univertall.Units.FuelEconomy;

/// <summary>  
/// Builder for fuel economy conversions.  
/// </summary>  
public class FuelEconomyConversionBuilder
{
    private readonly double _value;
    private FuelEconomyUnit _fromUnit;

    /// <summary>  
    /// Initializes a new instance of the <see cref="FuelEconomyConversionBuilder"/> class.
    /// </summary>  
    /// <param name="value">The value to convert.</param>  
    public FuelEconomyConversionBuilder(double value)
    {
        _value = value;
    }

    /// <summary>  
    /// Sets the unit to convert from.  
    /// </summary>  
    /// <param name="fromUnit">The unit to convert from.</param>  
    /// <returns>The current instance of <see cref="FuelEconomyConversionBuilder"/>.</returns>  
    public FuelEconomyConversionBuilder From(FuelEconomyUnit fromUnit)
    {
        _fromUnit = fromUnit;
        return this;
    }

    /// <summary>  
    /// Converts the value to the specified target unit.  
    /// </summary>  
    /// <param name="toUnit">The unit to convert the value to.</param>  
    /// <returns>The converted value.</returns>  
    public double To(FuelEconomyUnit toUnit)
    {
        var converter = new FuelEconomyConverter();
        return converter.Convert(_value, _fromUnit, toUnit);
    }
}
