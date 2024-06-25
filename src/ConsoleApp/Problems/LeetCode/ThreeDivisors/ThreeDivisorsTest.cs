namespace ConsoleApp.Problems.LeetCode.ThreeDivisors;

public class ProblemTest
{
    [Theory]
    [InlineData(2, false)]
    [InlineData(4, true)]
    public void TestSolve(int input, bool expected)
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