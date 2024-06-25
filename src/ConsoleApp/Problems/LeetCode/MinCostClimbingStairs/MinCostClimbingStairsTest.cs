namespace ConsoleApp.Problems.LeetCode.MinCostClimbingStairs;

public class MinCostClimbingStairsTest
{
    [Theory]
    [InlineData(new[] {10,15,20}, 15)]
    [InlineData(new[] {1,100,1,1,1,100,1,1,100,1}, 6)]
    public void TestSolve(int[] cost, int expected)
    {
        var solution = new MinCostClimbingStairsSolution();
        var actual = solution.Solve(cost);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}