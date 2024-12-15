namespace AdventOfCode.Library;

public class Day06
{
    public int CountDistinctPositions(IList<char>[] map)
    {
        while (GetCoordinates(map) != (-1, -1))
        {
            AdvancePosition(map);
        }

        return map.Sum(x => x.Count(y => y == 'X'));
    }

    private (int, int) GetCoordinates(IList<char>[] map)
    {
        var positions = new[] { '^', '>', 'V', '<' };

        for (var y = 0; y < map.Length; y++)
        {
            var x = positions.Max(x => map[y].IndexOf(x));

            if (x < 0)
                continue;

            return (x, y);
        }

        return (-1, -1);
    }

    private int GetDirectionX(IList<char>[] map)
    {
        var (x, y) = GetCoordinates(map);
        var position = map[y][x];

        return position switch
        {
            '>' => 1,
            '<' => -1,
            _ => 0
        };
    }

    private int GetDirectionY(IList<char>[] map)
    {
        var (x, y) = GetCoordinates(map);
        var position = map[y][x];

        return position switch
        {
            'V' => 1,
            '^' => -1,
            _ => 0
        };
    }

    private void AdvancePosition(IList<char>[] map)
    {
        var (x, y) = GetCoordinates(map);

        var directionX = GetDirectionX(map);
        var directionY = GetDirectionY(map);
        var (nextX, nextY) = (x + directionX, y + directionY);

        var position = map[y][x];

        map[y][x] = 'X';

        if (nextX < 0 || nextY < 0 || nextY >= map.Length || nextX >= map[nextY].Count)
            return;

        if (map[nextY][nextX] == '#')
        {
            map[y][x] = position switch
            {
                '>' => 'V',
                'V' => '<',
                '<' => '^',
                '^' => '>',
                _ => position
            };
            return;
        }

        map[nextY][nextX] = position;
    }
}