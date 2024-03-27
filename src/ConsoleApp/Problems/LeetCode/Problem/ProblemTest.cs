namespace ConsoleApp.Problems.LeetCode.Problem;

public class ProblemTest
{
    [Theory]
    [InlineData(default, default)]
    public void TestSolve(object input, object expected)
    {
        var solution = new ProblemSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
}