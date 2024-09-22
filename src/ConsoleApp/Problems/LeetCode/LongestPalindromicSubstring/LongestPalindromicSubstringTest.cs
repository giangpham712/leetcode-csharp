namespace ConsoleApp.Problems.LeetCode.LongestPalindromicSubstring;

public class LongestPalindromicSubstringTest
{
    [Theory]
    [InlineData("babad", "bab")]
    [InlineData("cbbd", "bb")]
    public void TestSolve(string input, string expected)
    {
        var solution = new LongestPalindromicSubstringSolution();
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