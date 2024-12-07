// See https://aka.ms/new-console-template for more information
var path = @"Inputs\day03.txt";
var input = File.ReadAllText(path);

var day = new Day03();
var sum = day.ComputeEnabledMultiplications(input);

Console.WriteLine($"Sum Enabled Multiplications: {sum}");

