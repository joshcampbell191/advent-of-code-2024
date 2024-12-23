namespace AdventOfCode.Tests;

public class Day03Tests
{
    [Fact]
    public void ComputeMultiplications()
    {
        // Arrange
        var input = @"xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";

        var sut = new Day03();

        // Act
        var sum = sut.ComputeMultiplications(input);

        // Assert
        Assert.Equal(161, sum);
    }

    [Fact]
    public void ComputeEnabledMultiplications()
    {
        // Arrange
        var input = @"xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))";

        var sut = new Day03();

        // Act
        var sum = sut.ComputeEnabledMultiplications(input);

        // Assert
        Assert.Equal(48, sum);
    }
}