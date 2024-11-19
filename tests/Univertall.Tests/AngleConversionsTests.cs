using Univertall.Units.Angle;

namespace Univertall.Tests;

public class AngleConversionsTests
{
    [Theory]
    [InlineData(1.0, 57.2958)]
    [InlineData(0.0, 0.0)]
    [InlineData(Math.PI, 180.0)]
    public void ToDegreeFromRadian_Double(double radian, double expected)
    {
        double result = new AngleConverter().Convert(radian, AngleUnit.Radians, AngleUnit.Degrees);
        Assert.Equal(expected, result, 4);
    }

    [Theory]
    [InlineData(1, 57.2958)]
    [InlineData(0, 0.0)]
    [InlineData(3, 171.887)]
    public void ToDegreeFromRadian_Int(int radian, double expected)
    {
        double result = new AngleConverter().Convert(radian, AngleUnit.Radians, AngleUnit.Degrees);
        Assert.Equal(expected, result, 3);
    }

    [Theory]
    [InlineData(1.0, 1.1111)]
    [InlineData(0.0, 0.0)]
    [InlineData(180.0, 200.0)]
    public void ToGradianFromDegree_Double(double degree, double expected)
    {
        double result = new AngleConverter().Convert(degree, AngleUnit.Degrees, AngleUnit.Gradians);
        Assert.Equal(expected, result, 3);
    }

    [Theory]
    [InlineData(1, 1.1111)]
    [InlineData(0, 0.0)]
    [InlineData(180, 200.0)]
    public void ToGradianFromDegree_Int(int degree, double expected)
    {
        double result = new AngleConverter().Convert(degree, AngleUnit.Degrees, AngleUnit.Gradians);
        Assert.Equal(expected, result, 3);
    }

    [Theory]
    [InlineData(1.0, 0.000290888)]
    [InlineData(0.0, 0.0)]
    [InlineData(10800.0, Math.PI)]
    public void ToRadianFromArcminute_Double(double arcminute, double expected)
    {
        double result = new AngleConverter().Convert(arcminute, AngleUnit.Arcminutes, AngleUnit.Radians);
        Assert.Equal(expected, result, 6);
    }

    [Theory]
    [InlineData(1, 0.000290888)]
    [InlineData(0, 0.0)]
    [InlineData(10800, Math.PI)]
    public void ToRadianFromArcminute_Int(int arcminute, double expected)
    {
        double result = new AngleConverter().Convert(arcminute, AngleUnit.Arcminutes, AngleUnit.Radians);
        Assert.Equal(expected, result, 6);
    }

    [Theory]
    [InlineData(1.0, 0.00000484814)]
    [InlineData(0.0, 0.0)]
    [InlineData(648000.0, Math.PI)]
    public void ToRadianFromArcsecond_Double(double arcsecond, double expected)
    {
        double result = new AngleConverter().Convert(arcsecond, AngleUnit.Arcseconds, AngleUnit.Radians);
        Assert.Equal(expected, result, 8);
    }

    [Theory]
    [InlineData(1, 0.00000484814)]
    [InlineData(0, 0.0)]
    [InlineData(648000, Math.PI)]
    public void ToRadianFromArcsecond_Int(int arcsecond, double expected)
    {
        double result = new AngleConverter().Convert(arcsecond, AngleUnit.Arcseconds, AngleUnit.Radians);
        Assert.Equal(expected, result, 8);
    }
}