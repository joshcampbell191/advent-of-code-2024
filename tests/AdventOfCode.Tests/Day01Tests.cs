namespace AdventOfCode.Tests;

public class Day01Tests
{
    [Fact]
    public void CalculateTotalDistance()
    {
        // Arrange
        var left = new List<int> { 3, 4, 2, 1, 3, 3 };
        var right = new List<int> { 4, 3, 5, 3, 9, 3 };

        var sut = new Day01();

        // Act
        var distance = sut.CalculateTotalDistance(left, right);

        // Assert
        Assert.Equal(11, distance);
    }

    [Theory]
    [InlineData(new[] { 3, 4, 2, 1, 3, 3 }, new[] { 4, 3, 5, 3, 9, 3 }, 31)]
    public void CalculateSimilarityScore(IEnumerable<int> left, IEnumerable<int> right, int expected)
    {
        // Arrange
        var sut = new Day01();

        // Act
        var similarity = sut.CalculateSimilarityScore(left, right);

        // Assert
        Assert.Equal(31, similarity);
    }
}