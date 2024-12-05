namespace AdventOfCode.Tests;

public class Day01Tests
{
    [Fact]
    public void CalculateDistance_Example_Returns11()
    {
        // Arrange
        var input = 
            """
            3   4
            4   3
            2   5
            1   3
            3   9
            3   3
            """;

        var sut = new Day01();

        // Act
        var distance = sut.CalculateDistance(input.Split(Environment.NewLine));

        // Assert
        Assert.Equal(11, distance);
    }
}