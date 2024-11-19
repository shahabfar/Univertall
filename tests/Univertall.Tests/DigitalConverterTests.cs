namespace Univertall.Tests;

public class DigitalConverterTests
{
    [Fact]
    public void ConvertBytesToKilobytes_ShouldReturnCorrectValue()
    {
        // Arrange
        var bytes = 1024;
        var expectedKilobytes = 1;

        // Act
        var result = ConvertBytesToKilobytes(bytes);

        // Assert
        Assert.Equal(expectedKilobytes, result);
    }

    [Fact]
    public void ConvertKilobytesToMegabytes_ShouldReturnCorrectValue()
    {
        // Arrange
        var kilobytes = 1024;
        var expectedMegabytes = 1;

        // Act
        var result = ConvertKilobytesToMegabytes(kilobytes);

        // Assert
        Assert.Equal(expectedMegabytes, result);
    }

    [Fact]
    public void ConvertMegabytesToGigabytes_ShouldReturnCorrectValue()
    {
        // Arrange
        var megabytes = 1024;
        var expectedGigabytes = 1;

        // Act
        var result = ConvertMegabytesToGigabytes(megabytes);

        // Assert
        Assert.Equal(expectedGigabytes, result);
    }

    private int ConvertBytesToKilobytes(int bytes)
    {
        return bytes / 1024;
    }

    private int ConvertKilobytesToMegabytes(int kilobytes)
    {
        return kilobytes / 1024;
    }

    private int ConvertMegabytesToGigabytes(int megabytes)
    {
        return megabytes / 1024;
    }
}
