namespace AdventOfCode.Library;

public class Day01
{
    public int CalculateTotalDistance(List<int> left, List<int> right)
    {
        left.Sort();
        right.Sort();

        return left.Zip(right, CalculateDistance).Sum();
    }

    public int CalculateSimilarityScore(IEnumerable<int> left, IEnumerable<int> right)
    {
        return left.Select(x => CalculateSimilarity(x, right)).Sum();
    }

    private int CalculateDistance(int source, int destination)
    {
        return Math.Abs(source - destination);
    }

    private int CalculateSimilarity(int locationId, IEnumerable<int> locationIds)
    {
        return locationId * locationIds.Count(x => x == locationId);
    }
}
