namespace ConsoleApp.Problems.LeetCode.SubarraySumEqualsK;

public class SubarraySumEqualsKTest
{
    [Theory]
    [InlineData(new[] {1,1,1}, 2, 2)]
    [InlineData(new[] {1,2,3}, 3, 2)]
    public void TestSolve(int[] nums, int k, int expected)
    {
        var solution = new SubarraySumEqualsKSolution();
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