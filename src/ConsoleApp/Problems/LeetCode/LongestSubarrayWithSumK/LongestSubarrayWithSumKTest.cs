namespace ConsoleApp.Problems.LeetCode.LongestSubarrayWithSumK;

public class ProblemTest
{
    [Theory]
    [InlineData(new int[] {10, 5, 2, 7, 1, 9}, 15 , 4)]
    [InlineData(new int[] {-1, 2, 3}, 6 , 0)]
    [InlineData(new int[] {1, 4, 3, 3, 5, 5}, 16 , 5)]
    public void TestSolve(int[] A, int K, int expected)
    {
        var solution = new ProblemSolution();
        var actual = solution.Solve(A, K);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}