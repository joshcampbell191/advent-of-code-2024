namespace AdventOfCode.Library;

public class Day04
{
    private const int UNCHANGED = 0;
    private const int LEFT = -1;
    private const int RIGHT = 1;
    private const int UP = -1;
    private const int DOWN = 1;

    public int CountXmas(char[][] input)
    {
        var height = input.Length;
        var width = input[0].Length;

        var keyword = "XMAS";

        var count = 0;
        for (var i = 0; i < height; i++)
            for (var j = 0; j < width; j++)
            {
                count += SearchKeyword(input, i, j, UP, UNCHANGED, keyword);
                count += SearchKeyword(input, i, j, DOWN, UNCHANGED, keyword);
                count += SearchKeyword(input, i, j, UNCHANGED, LEFT, keyword);
                count += SearchKeyword(input, i, j, UNCHANGED, RIGHT, keyword);
                count += SearchKeyword(input, i, j, UP, LEFT, keyword);
                count += SearchKeyword(input, i, j, UP, RIGHT, keyword);
                count += SearchKeyword(input, i, j, DOWN, LEFT, keyword);
                count += SearchKeyword(input, i, j, DOWN, RIGHT, keyword);
            }

        return count;
    }

    public int CountCrossXmas(char[][] input)
    {
        var height = input.Length;
        var width = input[0].Length;

        var keyword = "MAS";

        var count = 0;
        for (var i = 0; i < height; i++)
            for (var j = 0; j < width; j++)
            {
                var found = 0;

                found += SearchKeyword(input, i + DOWN, j + RIGHT, UP, LEFT, keyword);
                found += SearchKeyword(input, i + UP, j + RIGHT, DOWN, LEFT, keyword);
                found += SearchKeyword(input, i + DOWN, j + LEFT, UP, RIGHT, keyword);
                found += SearchKeyword(input, i + UP, j + LEFT, DOWN, RIGHT, keyword);

                if (found == 2)
                    count++;
            }

        return count;
    }

    private int SearchKeyword(char[][] input, int row, int column, int rowDirection, int columnDirection, string keyword)
    {
        var height = input.Length;
        var width = input[0].Length;

        foreach (var key in keyword)
        {
            if (row < 0 || row >= width)
                return 0;

            if (column < 0 || column >= height)
                return 0;

            if (input[row][column] != key)
                return 0;

            row += rowDirection;
            column += columnDirection;
        }

        return 1;
    }
}