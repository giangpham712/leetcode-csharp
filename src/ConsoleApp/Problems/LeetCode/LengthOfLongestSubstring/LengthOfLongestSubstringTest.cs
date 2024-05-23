namespace ConsoleApp.Problems.LeetCode.LengthOfLongestSubstring;

public class LengthOfLongestSubstringTest
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData(" ", 1)]
    [InlineData("au", 2)]
    public void TestSolve(string input, int expected)
    {
        var solution = new LengthOfLongestSubstringSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
}