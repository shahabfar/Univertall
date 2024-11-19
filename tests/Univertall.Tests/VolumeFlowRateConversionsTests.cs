using Univertall.Units.VolumeFlowRate;

namespace Univertall.Tests
{
    public class VolumeFlowRateConverterTests
    {
        [Theory]
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.LiterPerSecond, 1000.0)]
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.GallonPerMinute, 15850.3231)] // US gallon
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.CubicFeetPerSecond, 35.3147)]
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.CubicInchPerMinute, 3661424.646)]
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.MilliliterPerSecond, 1000000.0)]
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.CubicMeterPerHour, 3600.0)]
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.LiterPerMinute, 59999.88)]
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.CubicFeetPerMinute, 2118.880)]
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.CubicInchPerSecond, 61023.7441)]
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.BarrelPerDay, 543439.6506)] // US oil barrel
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.BarrelPerHour, 22643.3380)] // US oil barrel
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.CubicMeterPerMinute, 60.0)]
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerSecond, VolumeFlowRateUnit.LiterPerHour, 3600000.0)]
        public void Convert_ShouldConvertToBaseCorrectly(double value, VolumeFlowRateUnit fromUnit, VolumeFlowRateUnit toUnit, double expected)
        {
            // Arrange
            var converter = new VolumeFlowRateConverter();

            // Act
            var result = converter.Convert(value, fromUnit, toUnit);

            // Assert
            Assert.Equal(expected, result, 3);
        }

        [Theory]
        [InlineData(1.0, VolumeFlowRateUnit.LiterPerSecond, VolumeFlowRateUnit.CubicMeterPerSecond, 0.001)]
        [InlineData(1.0, VolumeFlowRateUnit.GallonPerMinute, VolumeFlowRateUnit.CubicMeterPerSecond, 0.0000630902)] // US gallon
        [InlineData(1.0, VolumeFlowRateUnit.CubicFeetPerSecond, VolumeFlowRateUnit.CubicMeterPerSecond, 0.0283168)]
        [InlineData(1.0, VolumeFlowRateUnit.CubicInchPerMinute, VolumeFlowRateUnit.CubicMeterPerSecond, 2.7311773333e-7)]
        [InlineData(1.0, VolumeFlowRateUnit.MilliliterPerSecond, VolumeFlowRateUnit.CubicMeterPerSecond, 1e-6)]
        [InlineData(1.0, VolumeFlowRateUnit.CubicMeterPerHour, VolumeFlowRateUnit.CubicMeterPerSecond, 0.0002777778)]
        [InlineData(1.0, VolumeFlowRateUnit.LiterPerMinute, VolumeFlowRateUnit.CubicMeterPerSecond, 0.0000166667)]
        public void Convert_ShouldConvertFromBaseCorrectly(double value, VolumeFlowRateUnit fromUnit, VolumeFlowRateUnit toUnit, double expected)
        {
            // Arrange
            var converter = new VolumeFlowRateConverter();

            // Act
            var result = converter.Convert(value, fromUnit, toUnit);

            // Assert
            Assert.Equal(expected, result, 4);
        }
    }

    public class VolumeFlowRateConversionBuilderTests
    {
        [Fact]
        public void Builder_ShouldConvertCorrectly()
        {
            // Arrange
            double value = 1.0;
            var builder = new VolumeFlowRateConversionBuilder(value);

            // Act
            var result = builder.From(VolumeFlowRateUnit.LiterPerSecond).To(VolumeFlowRateUnit.CubicMeterPerSecond);

            // Assert
            Assert.Equal(0.001, result, 4);
        }

        [Fact]
        public void Builder_ShouldThrowExceptionForInvalidUnit()
        {
            // Arrange
            double value = 1.0;
            var builder = new VolumeFlowRateConversionBuilder(value);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                builder.From((VolumeFlowRateUnit)int.MaxValue).To(VolumeFlowRateUnit.CubicMeterPerSecond));
        }
    }
}
