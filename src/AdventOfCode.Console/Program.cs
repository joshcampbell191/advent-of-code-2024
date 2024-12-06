// See https://aka.ms/new-console-template for more information
var path = @"Inputs\day02.txt";
var input = File.ReadAllLines(path);

var day = new Day02();
var reports = input.Select(x => x.Split().Select(int.Parse).ToArray());

var safeReports = day.CountSafeReportsWithProblemDampener(reports);

Console.WriteLine($"Safe Reports: {safeReports}");

