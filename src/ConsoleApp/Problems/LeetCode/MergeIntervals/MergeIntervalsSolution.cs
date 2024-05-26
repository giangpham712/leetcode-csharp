namespace ConsoleApp.Problems.LeetCode.MergeIntervals;

public class MergeIntervalsSolution
{
    public int[][] Solve(int[][] intervals)
    {
        var results = new List<int[]>();
        Array.Sort(intervals, new IntervalComparer());

        var current = intervals[0];
        for (var index = 1; index < intervals.Length; index++)
        {
            var interval = intervals[index];
            if (interval[0] <= current[1])
            {
                current[1] = Math.Max(current[1], interval[1]);
            }
            else
            {
                results.Add(current);
                current = interval;
            }
        }

        results.Add(current);
        
        return results.ToArray();
    }

    class IntervalComparer : IComparer<int[]>
    {
        public int Compare(int[]? x, int[]? y)
        {
            return x[0].CompareTo(y[0]);
        }
    }
}