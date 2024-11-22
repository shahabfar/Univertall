# UniVertAll

UniVertAll is a versatile unit conversion library for .NET developers. It supports a wide range of units and provides a fluent API for easy and intuitive conversions. The library is compatible with multiple .NET versions, including .NET 6, .NET 7, .NET 8, and .NET 9.

## Features

- Comprehensive support for various units (length, mass, power, volume, etc.)
- Fluent API for easy and intuitive conversions
- Extensible with custom units and conversions
- Robust error handling
- Thread-safe
- Compatible with multiple .NET versions
- Packaged as a NuGet package for easy distribution

## Usage

### Sample Conversion

Here is an example of how to use the library for Power unit conversions:

```csharp
using UnitConverter.Units.Power;

double watts = 746;
double horsepower = watts.ConvertPower()
        .From(PowerUnit.Watt)
        .To(PowerUnit.MetricHorsepower);
Console.WriteLine($"{watts} Watts is equal to {horsepower} Horsepower.");
```

Thank you for using UniVertAll! We hope it makes your unit conversion tasks easier and more efficient.

