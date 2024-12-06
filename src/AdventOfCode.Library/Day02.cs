namespace AdventOfCode.Library;

public class Day02
{
    public int CountSafeReports(IEnumerable<int[]> reports)
    {
        return reports.Count(IsReportSafe);
    }

    public int CountSafeReportsWithProblemDampener(IEnumerable<int[]> reports)
    {
        return reports.Count(IsReportSafeWithProblemDampener);
    }

    private bool IsReportSafe(int[] report)
    {
        if (report.Length == 1)
            return true;

        var increasing = report[1] > report[0];
        for (int i = 0, j = 1; j < report.Length; i++, j++)
        {
            var current = report[i];
            var next = report[j];

            if (!IsLevelSafe(current, next, increasing))
                return false;
        }

        return true;
    }

    private bool IsLevelSafe(int current, int next, bool increasing)
    {
        if (increasing && next < current)
            return false;

        if (!increasing && next > current)
            return false;

        if (Math.Abs(current - next) is < 1 or > 3)
            return false;

        return true;
    }

    private bool IsReportSafeWithProblemDampener(int[] report)
    {
        if (IsReportSafe(report))
            return true;

        var copy = new int[report.Length - 1];
        for (var i = 0; i < report.Length; i++)
        {
            Array.Copy(report, 0, copy, 0, i);
            Array.Copy(report, i + 1, copy, i, report.Length - i - 1);

            if (IsReportSafe(copy))
                return true;
        }

        return false;
    }
}