// See https://aka.ms/new-console-template for more information
var path = @"Inputs\day04.txt";

var lines = File.ReadAllLines(path);
var input = lines.Select(x => x.ToArray()).ToArray();

var day = new Day04();
var count = day.CountCrossXmas(input);

Console.WriteLine($"Count Cross: {count}");

