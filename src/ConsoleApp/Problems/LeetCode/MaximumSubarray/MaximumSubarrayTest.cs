namespace ConsoleApp.Problems.LeetCode.MaximumSubarray;

public class ProblemTest
{
    [Theory]
    [InlineData(new[] {-2,1,-3,4,-1,2,1,-5,4}, 6)]
    [InlineData(new[] {1}, 1)]
    [InlineData(new[] {5,4,-1,7,8}, 23)]
    public void TestSolve(int[] input, int expected)
    {
        var solution = new ProblemSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new[] {-2,1,-3,4,-1,2,1,-5,4}, 6)]
    [InlineData(new[] {1}, 1)]
    [InlineData(new[] {5,4,-1,7,8}, 23)]
    public void TestSolve2(int[] input, int expected)
    {
        var solution = new ProblemSolution();
        var actual = solution.Solve2(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}