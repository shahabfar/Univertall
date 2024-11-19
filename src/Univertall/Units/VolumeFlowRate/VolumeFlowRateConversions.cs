namespace Univertall.Units.VolumeFlowRate;
/// <summary>
/// Enumeration of volume flow rate units.
/// </summary>
public enum VolumeFlowRateUnit
{
    CubicMeterPerSecond,
    LiterPerSecond,
    GallonPerMinute,
    CubicFeetPerSecond,
    CubicInchPerMinute,
    MilliliterPerSecond,
    CubicMeterPerHour,
    LiterPerMinute,
    GallonPerHour,
    CubicFeetPerMinute,
    CubicInchPerSecond,
    BarrelPerDay,
    BarrelPerHour,
    CubicMeterPerMinute,
    LiterPerHour
}

/// <summary>
/// Converter for volume flow rate units.
/// </summary>
public class VolumeFlowRateConverter : BaseUnivertall<VolumeFlowRateUnit>
{
    /// <summary>
    /// Converts the specified value from the given unit to the base unit (CubicMeterPerSecond).
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="fromUnit">The unit to convert from.</param>
    /// <returns>The value in the base unit.</returns>
    protected override double ToBaseUnit(double value, VolumeFlowRateUnit fromUnit)
    {
        return fromUnit switch
        {
            VolumeFlowRateUnit.CubicMeterPerSecond => value,
            VolumeFlowRateUnit.LiterPerSecond => value * 0.001,
            VolumeFlowRateUnit.GallonPerMinute => value * 0.0000630901964,
            VolumeFlowRateUnit.CubicFeetPerSecond => value * 0.0283168466,
            VolumeFlowRateUnit.CubicInchPerMinute => value * 2.7311773333333e-7,
            VolumeFlowRateUnit.MilliliterPerSecond => value * 1e-6,
            VolumeFlowRateUnit.CubicMeterPerHour => value * 0.0002777778,
            VolumeFlowRateUnit.LiterPerMinute => value * 0.0000166667,
            VolumeFlowRateUnit.GallonPerHour => value * 1.0515032733333e-6,
            VolumeFlowRateUnit.BarrelPerDay => value * 1.8401307283333e-6,
            VolumeFlowRateUnit.BarrelPerHour => value * 4.41631e-5,
            VolumeFlowRateUnit.CubicMeterPerMinute => value * 0.0166666667,
            VolumeFlowRateUnit.LiterPerHour => value * 2.7777777777778e-7,
            VolumeFlowRateUnit.CubicFeetPerMinute => value * 0.0004719474,
            VolumeFlowRateUnit.CubicInchPerSecond => value * 1.6387064e-5,
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    /// <summary>
    /// Converts the specified value from the base unit (CubicMeterPerSecond) to the given unit.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <param name="toUnit">The unit to convert to.</param>
    /// <returns>The value in the target unit.</returns>
    protected override double FromBaseUnit(double value, VolumeFlowRateUnit toUnit)
    {
        return toUnit switch
        {
            VolumeFlowRateUnit.CubicMeterPerSecond => value,
            VolumeFlowRateUnit.LiterPerSecond => value / 0.001,
            VolumeFlowRateUnit.GallonPerMinute => value / 0.0000630901964,
            VolumeFlowRateUnit.CubicFeetPerSecond => value / 0.0283168466,
            VolumeFlowRateUnit.CubicInchPerMinute => value / 2.7311773333333e-7,
            VolumeFlowRateUnit.MilliliterPerSecond => value / 1e-6,
            VolumeFlowRateUnit.CubicMeterPerHour => value / 0.0002777778,
            VolumeFlowRateUnit.LiterPerMinute => value / 0.0000166667,
            VolumeFlowRateUnit.GallonPerHour => value / 1.0515032733333e-6,
            VolumeFlowRateUnit.BarrelPerDay => value / 1.8401307283333e-6,
            VolumeFlowRateUnit.BarrelPerHour => value / 4.41631e-5,
            VolumeFlowRateUnit.CubicMeterPerMinute => value / 0.0166666667,
            VolumeFlowRateUnit.LiterPerHour => value / 2.7777777777778e-7,
            VolumeFlowRateUnit.CubicFeetPerMinute => value / 0.0004719474,
            VolumeFlowRateUnit.CubicInchPerSecond => value / 1.6387064e-5,
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}

