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

## Installation

You can install the UniVertAll library via NuGet:


## Usage

### Basic Conversion

Here is an example of how to use the library for basic unit conversions:

using UnitConverter.Units.Power;
double valueInWatts = new PowerConversionBuilder(1.5) .From(PowerUnit.Kilowatt) .To(PowerUnit.Watt);
Console.WriteLine($"1.5 Kilowatts is equal to {valueInWatts} Watts.");


### Extending with Custom Units

You can extend the library with custom units and conversions by inheriting from the `BaseUnitConverter` class.

public enum CustomUnit { UnitA, UnitB }
public class CustomConverter : BaseUnitConverter { protected override double ToBaseUnit(double value, CustomUnit fromUnit) { // Implement conversion to base unit }

protected override double FromBaseUnit(double value, CustomUnit toUnit)
{
    // Implement conversion from base unit
}


## Documentation

The library includes XML documentation comments for all public classes and methods. You can view the documentation in your IDE or generate a documentation file using tools like Sandcastle.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your changes. Ensure that your code follows the existing coding style and includes unit tests.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any questions or feedback, please open an issue on the GitHub repository.

---

Thank you for using UniVertAll! We hope it makes your unit conversion tasks easier and more efficient.

