namespace ConsoleApp.Problems.LeetCode.EncodeAndDecodeTinyURL;

public class EncodeAndDecodeTinyURLTest
{
    [Theory]
    [InlineData("https://leetcode.com/problems/design-tinyurl", "https://leetcode.com/problems/design-tinyurl")]
    public void TestSolve(string input, string expected)
    {
        var solution = new EncodeAndDecodeTinyURLSolution();
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