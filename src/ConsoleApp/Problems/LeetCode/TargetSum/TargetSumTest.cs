namespace ConsoleApp.Problems.LeetCode.TargetSum;

public class TargetSumTest
{
    [Theory]
    [InlineData(new[] {1,1,1,1,1}, 3, 5)]
    [InlineData(new[] {1}, 1, 1)]
    [InlineData(new[] {0,0,0,0,0,0,0,0,1}, 1, 256)]
    public void TestSolve(int[] nums, int target, int expected)
    {
        var solution = new TargetSumSolution();
        var actual = solution.Solve(nums, target);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}