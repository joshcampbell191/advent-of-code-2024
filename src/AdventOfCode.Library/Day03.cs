using System.Text.RegularExpressions;

namespace AdventOfCode.Library;

public class Day03
{
    public int ComputeMultiplications(string input)
    {
        var pattern = @"mul\((?<first>\d{1,3}),(?<second>\d{1,3})\)";
        var matches = Regex.Matches(input, pattern);

        var sum = 0;
        foreach (Match match in matches)
        {
            var first = int.Parse(match.Groups["first"].Value);
            var second = int.Parse(match.Groups["second"].Value);

            sum += first * second;
        }

        return sum;
    }

    public int ComputeEnabledMultiplications(string input)
    {
        var pattern = @"(?:^|do\(\)).*?(?=don't\(\)|$)";
        var matches = Regex.Matches(input, pattern, RegexOptions.Singleline);

        var sum = 0;
        foreach (Match match in matches)
        {
            sum += ComputeMultiplications(match.Value);
        }

        return sum;
    }
}