namespace AdventOfCode.Tests;

public class Day04Tests
{
    [Fact]
    public void CountXmas()
    {
        // Arrange
        var input = new char[][] {
            [ 'M', 'M', 'M', 'S', 'X', 'X', 'M', 'A', 'S', 'M' ],
            [ 'M', 'S', 'A', 'M', 'X', 'M', 'S', 'M', 'S', 'A' ],
            [ 'A', 'M', 'X', 'S', 'X', 'M', 'A', 'A', 'M', 'M' ],
            [ 'M', 'S', 'A', 'M', 'A', 'S', 'M', 'S', 'M', 'X' ],
            [ 'X', 'M', 'A', 'S', 'A', 'M', 'X', 'A', 'M', 'M' ],
            [ 'X', 'X', 'A', 'M', 'M', 'X', 'X', 'A', 'M', 'A' ],
            [ 'S', 'M', 'S', 'M', 'S', 'A', 'S', 'X', 'S', 'S' ],
            [ 'S', 'A', 'X', 'A', 'M', 'A', 'S', 'A', 'A', 'A' ],
            [ 'M', 'A', 'M', 'M', 'M', 'X', 'M', 'M', 'M', 'M' ],
            [ 'M', 'X', 'M', 'X', 'A', 'X', 'M', 'A', 'S', 'X' ]
        };

        var sut = new Day04();

        // Act
        var count = sut.CountXmas(input);

        // Assert
        Assert.Equal(18, count);
    }

    [Fact]
    public void CountCrossXmas()
    {
        // Arrange
        var input = new char[][] {
            [ 'M', 'M', 'M', 'S', 'X', 'X', 'M', 'A', 'S', 'M' ],
            [ 'M', 'S', 'A', 'M', 'X', 'M', 'S', 'M', 'S', 'A' ],
            [ 'A', 'M', 'X', 'S', 'X', 'M', 'A', 'A', 'M', 'M' ],
            [ 'M', 'S', 'A', 'M', 'A', 'S', 'M', 'S', 'M', 'X' ],
            [ 'X', 'M', 'A', 'S', 'A', 'M', 'X', 'A', 'M', 'M' ],
            [ 'X', 'X', 'A', 'M', 'M', 'X', 'X', 'A', 'M', 'A' ],
            [ 'S', 'M', 'S', 'M', 'S', 'A', 'S', 'X', 'S', 'S' ],
            [ 'S', 'A', 'X', 'A', 'M', 'A', 'S', 'A', 'A', 'A' ],
            [ 'M', 'A', 'M', 'M', 'M', 'X', 'M', 'M', 'M', 'M' ],
            [ 'M', 'X', 'M', 'X', 'A', 'X', 'M', 'A', 'S', 'X' ]
        };

        var sut = new Day04();

        // Act
        var count = sut.CountCrossXmas(input);

        // Assert
        Assert.Equal(9, count);
    }
}