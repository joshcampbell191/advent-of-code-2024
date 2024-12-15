// See https://aka.ms/new-console-template for more information
var path = @"Inputs\day06.txt";

var lines = File.ReadAllLines(path);
var input = lines.Select(x => x.ToList()).ToArray();

var day = new Day06();
var count = day.CountDistinctPositions(input);

Console.WriteLine($"Count Distinct Positions: {count}");
