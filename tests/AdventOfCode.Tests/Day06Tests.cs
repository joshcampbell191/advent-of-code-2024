namespace AdventOfCode.Tests;

public class Day06Tests
{
    [Fact]
    public void CountDistinctPositions()
    {
        // Arrange
        var map = new List<char>[] {
            ['.', '.', '.', '.', '#', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.', '#'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '#', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '#', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '#', '.', '.', '^', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '#', '.'],
            ['#', '.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '#', '.', '.', '.']
        };

        var sut = new Day06();

        // Act
        var count = sut.CountDistinctPositions(map);

        // Assert
        Assert.Equal(41, count);
    }
}