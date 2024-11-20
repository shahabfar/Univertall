Here's your updated README with the requested table of supported units (including custom units):

# **UniVertAll**

[![Publish to NuGet](https://github.com/shahabfar/Univertall/actions/workflows/release.yml/badge.svg)](https://github.com/shahabfar/Univertall/actions/workflows/release.yml)

UniVertAll is a versatile unit conversion library for .NET developers. It supports a wide range of units and provides a fluent API for easy and intuitive conversions. The library is compatible with .NET 6, .NET 7, .NET 8, and .NET 9.

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)

## **Features**

- **Comprehensive Support**: Includes various units (length, mass, power, temperature, volume, and more).
- **Fluent API**: Simplifies unit conversion with an intuitive syntax.
- **Customizable**: Extend the library with your own units and conversions.
- **Thread-Safe**: Designed for concurrent applications.
- **Compatible**: Works with multiple .NET versions.
- **NuGet Distribution**: Easily installable via NuGet Package Manager.


## **Installation**

Install the UniVertAll library via NuGet:

[![NuGet Version](https://img.shields.io/nuget/v/UniVertAll.svg)](https://www.nuget.org/packages/UniVertAll)

### Using .NET CLI:
```bash
dotnet add package UniVertAll
```

### Using Package Manager:
Search for `UniVertAll` in the NuGet Package Manager within Visual Studio and install it.


## **Supported Units**

Here’s a list of all the units supported by UniVertAll:

| **Category**      | **Units Supported**                                                                                                                                                                      |
|--------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Length**         | Meter, Kilometer, Centimeter, Millimeter, Micrometer, Nanometer, Inch, Foot, Yard, Mile, Nautical Mile                                                                                  |
| **Mass**           | Kilogram, Gram, Milligram, Microgram, Ton, Metric Ton, Long Ton, Short Ton, Pound, Ounce, Stone, Carat                                                                                  |
| **Volume**         | Cubic Meter, Liter, Milliliter, Gallon (US), Gallon (UK), Quart, Pint, Cup, Fluid Ounce, Tablespoon, Teaspoon                                                                          |
| **Power**          | Watt, Kilowatt, Megawatt, Gigawatt, Horsepower (Metric), Horsepower (Imperial)                                                                                                          |
| **Temperature**    | Celsius, Fahrenheit, Kelvin                                                                                                                                                            |
| **Pressure**       | Pascal, Kilopascal, Bar, Atmosphere, Torr, PSI (Pounds per Square Inch)                                                                                                                |
| **Volume Flow Rate** | Cubic Meter per Second, Liter per Second, Gallon per Minute (US), Gallon per Hour (US), Cubic Feet per Second, Cubic Feet per Minute, Cubic Inch per Second, Cubic Inch per Minute     |
| **Angle**          | Degree, Radian, Gradian                                                                                                                                                                |
| **Digital**        | Bit, Byte, Kilobyte, Megabyte, Gigabyte, Terabyte, Petabyte, Exabyte                                                                                                                   |
| **Fuel Economy**   | Miles per Gallon (US), Miles per Gallon (Imperial), Liters per 100 Kilometers, Kilometers per Liter                                                                                     |
| **Force**          | Newton, Kilonewton, Pound-Force, Ounce-Force                                                                                                                                           |
| **Custom**         | CustomUnit (User-defined, such as UnitA, UnitB, etc.)                                                                                                                                  |

##

## **Using Univertall**

UniVertAll uses a **fluent API** to provide intuitive and easy-to-use conversions. Below are some examples showcasing its functionality:


### **1. Length Conversion**
```csharp
using UnitConverter.Units.Length;

double meters = 5000;
double yards = meters.ConvertLength().From(LengthUnit.Meter).To(LengthUnit.Yard);
Console.WriteLine($"{meters} Meters is equal to {yards} Yards.");
```

### **3. Volume Conversion**
```csharp
using UnitConverter.Units.Volume;

double liters = 3.78541;
double gallons = liters.ConvertVolume().From(VolumeUnit.Liter).To(VolumeUnit.Gallon);
Console.WriteLine($"{liters} Liters is equal to {gallons} Gallons.");
```

### **4. Power Conversion**
```csharp
using UnitConverter.Units.Power;

double watts = 746;
double horsepower = watts.ConvertPower().From(PowerUnit.Watt).To(PowerUnit.MetricHorsepower);
Console.WriteLine($"{watts} Watts is equal to {horsepower} Horsepower.");
```

### **6. Angle Conversion**
```csharp
using UnitConverter.Units.Angle;

double degrees = 180;
double radians = degrees.ConvertAngle().From(AngleUnit.Degree).To(AngleUnit.Radian);
Console.WriteLine($"{degrees} Degrees is equal to {radians} Radians.");
```

##

## **Extending with Custom Units**

UniVertAll is highly extensible. You can define your custom units and conversions by inheriting from the `BaseUnitConverter` class, as shown above. This makes the library flexible and adaptable to unique domain-specific requirements. Here is an example:

```csharp
using UnitConverter.Base;

public enum CustomUnit { UnitA, UnitB }

public class CustomConverter : BaseUnitConverter<CustomUnit>
{
    protected override double ToBaseUnit(double value, CustomUnit fromUnit)
    {
        return fromUnit switch
        {
            CustomUnit.UnitA => value * 10,  // Example: 1 UnitA = 10 Base Units
            CustomUnit.UnitB => value / 2,  // Example: 1 UnitB = 0.5 Base Units
            _ => throw new ArgumentOutOfRangeException(nameof(fromUnit), fromUnit, null)
        };
    }

    protected override double FromBaseUnit(double value, CustomUnit toUnit)
    {
        return toUnit switch
        {
            CustomUnit.UnitA => value / 10,  // Convert Base Unit to UnitA
            CustomUnit.UnitB => value * 2,   // Convert Base Unit to UnitB
            _ => throw new ArgumentOutOfRangeException(nameof(toUnit), toUnit, null)
        };
    }
}

// Usage
var customConverter = new CustomConverter();
double result = customConverter.Convert(5, CustomUnit.UnitA, CustomUnit.UnitB);
Console.WriteLine($"5 UnitA is equal to {result} UnitB.");
```


## **Documentation**

XML documentation is included for all public classes and methods, accessible in your IDE. You can generate documentation using tools like [DocFX](https://dotnet.github.io/docfx/) or [Sandcastle](https://github.com/EWSoftware/SHFB).


## **Contributing**

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch for your feature: `git checkout -b feature-name`.
3. Commit your changes: `git commit -m "Add new feature"`.
4. Push your branch: `git push origin feature-name`.
5. Open a pull request.

Ensure your code adheres to the project’s coding style and includes tests.


## **License**

UniVertAll is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for more details.


## **Contact**

For questions or feedback:

- Open an issue on the [GitHub repository](https://github.com/your-repo/UniVertAll).
- We welcome your suggestions and contributions!

##

Thank you for using **UniVertAll**! We hope it simplifies your unit conversion needs. 😊

---