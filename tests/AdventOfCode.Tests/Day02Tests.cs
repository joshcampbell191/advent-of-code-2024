namespace AdventOfCode.Tests;

public class Day02Tests
{
    [Fact]
    public void CountSafeReports()
    {
        // Arrange
        var reports = new int[][] {
            [7, 6, 4, 2, 1],
            [1, 2, 7, 8, 9],
            [9, 7, 6, 2, 1],
            [1, 3, 2, 4, 5],
            [8, 6, 4, 4, 1],
            [1, 3, 6, 7, 9]
        };

        var sut = new Day02();

        // Act
        var safeReports = sut.CountSafeReports(reports);

        // Assert
        Assert.Equal(2, safeReports);
    }

    [Fact]
    public void CountSafeReportsWithProblemDampener()
    {
        // Arrange
        var reports = new int[][] {
            [7, 6, 4, 2, 1],
            [1, 2, 7, 8, 9],
            [9, 7, 6, 2, 1],
            [1, 3, 2, 4, 5],
            [8, 6, 4, 4, 1],
            [1, 3, 6, 7, 9]
        };

        var sut = new Day02();

        // Act
        var safeReports = sut.CountSafeReportsWithProblemDampener(reports);

        // Assert
        Assert.Equal(4, safeReports);
    }
}