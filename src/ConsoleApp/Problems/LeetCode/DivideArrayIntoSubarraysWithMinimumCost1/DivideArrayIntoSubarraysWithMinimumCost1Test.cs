namespace ConsoleApp.Problems.LeetCode.DivideArrayIntoSubarraysWithMinimumCost1;

public class DivideArrayIntoSubarraysWithMinimumCost1Test
{
    [Theory]
    [InlineData(new[] {1,2,3,12}, 6)]
    [InlineData(new[] {5,4,3}, 12)]
    [InlineData(new[] {10,3,1,1}, 12)]
    public void TestSolve(int[] nums, int expected)
    {
        var solution = new DivideArrayIntoSubarraysWithMinimumCost1Solution();
        var actual = solution.Solve(nums);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}