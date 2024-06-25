namespace ConsoleApp.Problems.LeetCode.SortArrayByIncreasingFrequency;

public class ProblemTest
{
    [Theory]
    [InlineData(new[] {1,1,2,2,2,3}, new[] {3,1,1,2,2,2})]
    [InlineData(new[] {2,3,1,3,2}, new[] {1,3,3,2,2})]
    [InlineData(new[] {-1,1,-6,4,5,-6,1,4,1}, new[] {5,-1,4,4,-6,-6,1,1,1})]
    public void TestSolve(int[] input, int[] expected)
    {
        var solution = new ProblemSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}