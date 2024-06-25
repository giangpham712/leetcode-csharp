namespace ConsoleApp.Problems.LeetCode.CountEqualAndDivisiblePairsInAnArray;

public class CountEqualAndDivisiblePairsInAnArrayTest
{
    [Theory]
    [InlineData(new[] {3,1,2,2,2,1,3}, 2, 4)]
    [InlineData(new[] {1,2,3,4}, 1, 0)]
    public void TestSolve(int[] nums, int k, object expected)
    {
        var solution = new CountEqualAndDivisiblePairsInAnArraySolution();
        var actual = solution.Solve(nums, k);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new[] {3,1,2,2,2,1,3}, 2, 4)]
    [InlineData(new[] {1,2,3,4}, 1, 0)]
    public void TestSolve2(int[] nums, int k, object expected)
    {
        var solution = new CountEqualAndDivisiblePairsInAnArraySolution2();
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