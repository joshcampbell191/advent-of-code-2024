namespace AdventOfCode.Library;

public class Day01
{
    public int CalculateDistance(string[] input)
    {
        (var left, var right) = ParseInput(input);

        left.Sort();
        right.Sort();

        var distance = 0;
        for(var i = 0; i < left.Count; i++)
        {
            distance += Math.Abs(left[i] - right[i]);
        }

        return distance;
    }

    private (List<int>, List<int>) ParseInput(string[] input)
    {
        var left = new List<int>();
        var right = new List<int>();

        foreach(var line in input)
        {
            var locationIds = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            left.Add(locationIds[0]);
            right.Add(locationIds[1]);
        }

        return new(left, right);
    }
}
