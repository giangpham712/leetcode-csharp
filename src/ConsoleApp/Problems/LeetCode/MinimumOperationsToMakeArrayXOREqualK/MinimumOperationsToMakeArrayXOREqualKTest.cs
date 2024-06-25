namespace ConsoleApp.Problems.LeetCode.MinimumOperationsToMakeArrayXOREqualK;

public class MinimumOperationsToMakeArrayXOREqualKTest
{
    [Theory]
    [InlineData(new[] {2,1,3,4}, 1, 2)]
    [InlineData(new[] {2,0,2,0}, 0, 0)]
    public void TestSolve(int[] nums, int k, int expected)
    {
        var solution = new MinimumOperationsToMakeArrayXOREqualKSolution();
        var actual = solution.Solve(nums, k);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}