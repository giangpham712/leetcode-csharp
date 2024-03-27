namespace ConsoleApp.Problems.LeetCode.Problem;

public class Test
{
    [Theory]
    [InlineData(default, default)]
    public void TestSolve(object input, object expected)
    {
        var solution = new Solution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
}