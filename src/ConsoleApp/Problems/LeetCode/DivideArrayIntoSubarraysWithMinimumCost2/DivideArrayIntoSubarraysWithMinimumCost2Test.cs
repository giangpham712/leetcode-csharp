namespace ConsoleApp.Problems.LeetCode.DivideArrayIntoSubarraysWithMinimumCost2;

public class DivideArrayIntoSubarraysWithMinimumCost2Test
{
    [Theory]
    [InlineData(new[] {1,3,2,6,4,2}, 3, 3, 5)]
    [InlineData(new[] {10,1,2,2,2,1}, 4, 3, 15)]
    [InlineData(new[] {10,8,18,9}, 3, 1, 36)]
    public void TestSolve(int[] nums, int k, int dist, int expected)
    {
        var solution = new DivideArrayIntoSubarraysWithMinimumCost2Solution();
        var actual = solution.Solve(nums, k, dist);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}