using Univertall.Extensions;
using Univertall.Units.Angle;
using Univertall.Units.Digital;
using Univertall.Units.Force;
using Univertall.Units.FuelEconomy;
using Univertall.Units.Length;
using Univertall.Units.Mass;
using Univertall.Units.Power;
using Univertall.Units.Pressure;
using Univertall.Units.Temperature;
using Univertall.Units.Volume;
using Univertall.Units.VolumeFlowRate;

// Angle conversion
double degrees = 180;
double radians = degrees.ConvertAngle().From(AngleUnit.Degrees).To(AngleUnit.Radians);
Console.WriteLine($"{degrees} Degrees is equal to {radians} Radians.");

// Digital conversion
double kilobytes = 2048;
double megabytes = kilobytes.ConvertDigital().From(DigitalUnit.Kilobyte).To(DigitalUnit.Megabyte);
Console.WriteLine($"{kilobytes} Kilobytes is equal to {megabytes} Megabytes.");

// Force conversion
double newtons = 1;
double poundsForce = newtons.ConvertForce().From(ForceUnit.Newton).To(ForceUnit.PoundForce);
double ounceForce = newtons.ConvertForce().From(ForceUnit.Newton).To(ForceUnit.OunceForce);
Console.WriteLine($"{newtons} Newton is equal to {poundsForce} PoundForce and {ounceForce} OunceForce.");

// Fuel Economy conversion
double mpg = 1;
double lPer100km = mpg.ConvertFuelEconomy().From(FuelEconomyUnit.MilesPerGallon).To(FuelEconomyUnit.LitersPer100Km);
double kmPerLiter = mpg.ConvertFuelEconomy().From(FuelEconomyUnit.MilesPerGallon).To(FuelEconomyUnit.KmPerLiter);
Console.WriteLine($"{mpg} Miles per Gallon (US) is equal to {lPer100km} Liters per 100 Kilometers and {kmPerLiter} Kilometers per Liter.");

// Length conversion
double meters = 1000;
double inches = meters.ConvertLength().From(LengthUnit.Meter).To(LengthUnit.Inch);
double feet = meters.ConvertLength().From(LengthUnit.Meter).To(LengthUnit.Foot);
Console.WriteLine($"{meters} Meters is equal to {inches} Inches and {feet} Feet.");

// Mass conversion
double kilograms = 1;
double grams = kilograms.ConvertMass().From(MassUnit.Kilogram).To(MassUnit.Gram);
double pounds = kilograms.ConvertMass().From(MassUnit.Kilogram).To(MassUnit.Pound);
Console.WriteLine($"{kilograms} Kilogram is equal to {grams} Grams and {pounds} Pounds.");

// Power conversion
double watts = 1000;
double metricHorsepower = watts.ConvertPower().From(PowerUnit.Watt).To(PowerUnit.MetricHorsepower);
double kilowatts = watts.ConvertPower().From(PowerUnit.Watt).To(PowerUnit.Kilowatt);
Console.WriteLine($"{watts} Watts is equal to {metricHorsepower} Metric Horsepower and {kilowatts} Kilowatts.");

// Pressure conversion
double pascals = 101325;
double atmospheres = pascals.ConvertPressure().From(PressureUnit.Pascal).To(PressureUnit.Atmosphere);
double bar = pascals.ConvertPressure().From(PressureUnit.Pascal).To(PressureUnit.Bar);
Console.WriteLine($"{pascals} Pascals is equal to {atmospheres} Atmospheres and {bar} Bar.");

// Temperature conversion
double celsius = 100;
double fahrenheit = celsius.ConvertTemperature().From(TemperatureUnit.Celsius).To(TemperatureUnit.Fahrenheit);
double kelvin = celsius.ConvertTemperature().From(TemperatureUnit.Celsius).To(TemperatureUnit.Kelvin);
Console.WriteLine($"{celsius} Celsius is equal to {fahrenheit} Fahrenheit and {kelvin} Kelvin.");

// Volume conversion
double liters = 3.78541;
double gallons = liters.ConvertVolume().From(VolumeUnit.Liter).To(VolumeUnit.Gallon);
double cubicMeters = liters.ConvertVolume().From(VolumeUnit.Liter).To(VolumeUnit.CubicMeter);
Console.WriteLine($"{liters} Liters is equal to {gallons} Gallons and {cubicMeters} Cubic Meters.");

// Volume Flow Rate conversion
double cubicMetersPerSecond = 1;
double gallonsPerHour = cubicMetersPerSecond.ConvertVolumeFlowRate()
    .From(VolumeFlowRateUnit.CubicMeterPerSecond)
    .To(VolumeFlowRateUnit.GallonPerHour);
double litersPerMinute = cubicMetersPerSecond.ConvertVolumeFlowRate()
    .From(VolumeFlowRateUnit.CubicMeterPerSecond)
    .To(VolumeFlowRateUnit.LiterPerMinute);
Console.WriteLine($"{cubicMetersPerSecond} Cubic Meters per Second is equal to {gallonsPerHour} Gallons per Hour and {litersPerMinute} Liters per Minute.");
