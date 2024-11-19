namespace Univertall.Units.Angle;

public enum AngleUnit
{
    Radians,
    Degrees,
    Gradians,
    Arcminutes,
    Arcseconds
}

public class AngleConverter : BaseUnivertall<AngleUnit>
{
    protected override double ToBaseUnit(double value, AngleUnit fromUnit)
    {
        return fromUnit switch
        {
            AngleUnit.Radians => value,
            AngleUnit.Degrees => value * (Math.PI / 180.0),
            AngleUnit.Gradians => value * (Math.PI / 200.0),
            AngleUnit.Arcminutes => value * (Math.PI / 10800.0),
            AngleUnit.Arcseconds => value * (Math.PI / 648000.0),
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    protected override double FromBaseUnit(double value, AngleUnit toUnit)
    {
        return toUnit switch
        {
            AngleUnit.Radians => value,
            AngleUnit.Degrees => value * (180.0 / Math.PI),
            AngleUnit.Gradians => value * (200.0 / Math.PI),
            AngleUnit.Arcminutes => value * (10800.0 / Math.PI),
            AngleUnit.Arcseconds => value * (648000.0 / Math.PI),
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}
