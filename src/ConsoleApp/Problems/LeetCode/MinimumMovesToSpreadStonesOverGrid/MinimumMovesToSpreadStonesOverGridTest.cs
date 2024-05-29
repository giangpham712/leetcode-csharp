namespace ConsoleApp.Problems.LeetCode.MinimumMovesToSpreadStonesOverGrid;

public class MinimumMovesToSpreadStonesOverGridTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] grid, int expected)
    {
        var solution = new MinimumMovesToSpreadStonesOverGridSolution();
        var actual = solution.Solve(grid);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[][]
            {
                [1,1,0],[1,1,1],[1,2,1]
            },
            3
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [1,3,0],[1,0,0],[1,0,3]
            },
            4
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [3,2,0],[0,1,0],[0,3,0]
            },
            7
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [0,3,0],[6,0,0],[0,0,0]
            },
            11
        };
    }
}