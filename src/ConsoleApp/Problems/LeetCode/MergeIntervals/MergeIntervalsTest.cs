namespace ConsoleApp.Problems.LeetCode.MergeIntervals;

public class MergeIntervalsTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] intervals, int[][] expected)
    {
        var solution = new MergeIntervalsSolution();
        var actual = solution.Solve(intervals);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[][]
            {
                [1,3],[2,6],[8,10],[15,18]
            },
            new int[][]
            {
                [1,6],[8,10],[15,18]
            }
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [1,4],[4,5]
            },
            new int[][]
            {
                [1,5]
            }
        };
    }
}