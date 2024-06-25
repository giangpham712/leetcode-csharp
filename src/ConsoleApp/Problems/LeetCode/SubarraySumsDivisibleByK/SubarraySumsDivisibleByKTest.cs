namespace ConsoleApp.Problems.LeetCode.SubarraySumsDivisibleByK;

public class SubarraySumsDivisibleByKTest
{
    [Theory]
    [InlineData(new[] {4,5,0,-2,-3,1}, 5, 7)]
    [InlineData(new[] {5}, 9, 0)]
    public void TestSolve(int[] nums, int k, int expected)
    {
        var solution = new SubarraySumsDivisibleByKSolution();
        var actual = solution.Solve(nums, k);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new[] {4,5,0,-2,-3,1}, 5, 7)]
    [InlineData(new[] {5}, 9, 0)]
    [InlineData(new[] {-1,2,9}, 2, 2)]
    public void TestSolve2(int[] nums, int k, int expected)
    {
        var solution = new SubarraySumsDivisibleByKSolution();
        var actual = solution.Solve2(nums, k);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}