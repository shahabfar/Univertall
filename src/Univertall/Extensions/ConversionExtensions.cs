using Univertall.Units.Angle;
using Univertall.Units.Digital;
using Univertall.Units.Force;
using Univertall.Units.FuelEconomy;
using Univertall.Units.Length;
using Univertall.Units.Mass;
using Univertall.Units.Power;
using Univertall.Units.Pressure;
using Univertall.Units.Speed;
using Univertall.Units.Temperature;
using Univertall.Units.Volume;
using Univertall.Units.VolumeFlowRate;

namespace Univertall.Extensions;

/// <summary>
/// Provides extension methods for converting various units.
/// </summary>
public static class ConversionExtensions
{
    /// <summary>
    /// Converts the specified value to an angle conversion builder.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>An AngleConversionBuilder for the specified value.</returns>
    public static AngleConversionBuilder ConvertAngle(this double value)
    {
        return new AngleConversionBuilder(value);
    }

    /// <summary>
    /// Converts the specified value to a digital conversion builder.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A DigitalConversionBuilder for the specified value.</returns>
    public static DigitalConversionBuilder ConvertDigital(this double value)
    {
        return new DigitalConversionBuilder(value);
    }

    /// <summary>
    /// Converts the specified value to a force conversion builder.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A ForceConversionBuilder for the specified value.</returns>
    public static ForceConversionBuilder ConvertForce(this double value)
    {
        return new ForceConversionBuilder(value);
    }

    /// <summary>
    /// Converts the specified value to a fuel economy conversion builder.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A FuelEconomyConversionBuilder for the specified value.</returns>
    public static FuelEconomyConversionBuilder ConvertFuelEconomy(this double value)
    {
        return new FuelEconomyConversionBuilder(value);
    }

    /// <summary>
    /// Converts the specified value to a length conversion builder.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A LengthConversionBuilder for the specified value.</returns>
    public static LengthConversionBuilder ConvertLength(this double value)
    {
        return new LengthConversionBuilder(value);
    }

    /// <summary>
    /// Converts the specified value to a power conversion builder.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A PowerConversionBuilder for the specified value.</returns>
    public static PowerConversionBuilder ConvertPower(this double value)
    {
        return new PowerConversionBuilder(value);
    }

    /// <summary>
    /// Converts the specified value to a pressure conversion builder.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A PressureConversionBuilder for the specified value.</returns>
    public static PressureConversionBuilder ConvertPressure(this double value)
    {
        return new PressureConversionBuilder(value);
    }

    /// <summary>
    /// Converts the specified value to a temperature conversion builder.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A TemperatureConversionBuilder for the specified value.</returns>
    public static TemperatureConversionBuilder ConvertTemperature(this double value)
    {
        return new TemperatureConversionBuilder(value);
    }

    /// <summary>
    /// Converts the specified value to a volume conversion builder.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A VolumeConversionBuilder for the specified value.</returns>
    public static VolumeConversionBuilder ConvertVolume(this double value)
    {
        return new VolumeConversionBuilder(value);
    }

    /// <summary>
    /// Converts the specified value to a volume flow rate conversion builder.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A VolumeFlowRateConversionBuilder for the specified value.</returns>
    public static VolumeFlowRateConversionBuilder ConvertVolumeFlowRate(this double value)
    {
        return new VolumeFlowRateConversionBuilder(value);
    }

    /// <summary>
    /// Converts the specified value to a mass conversion builder.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A MassConversionBuilder for the specified value.</returns>
    public static MassConversionBuilder ConvertMass(this double value)
    {
        return new MassConversionBuilder(value);
    }

    public static SpeedConversionBuilder ConvertSpeed(this double value)
    {
        return new SpeedConversionBuilder(value);
    }

}
