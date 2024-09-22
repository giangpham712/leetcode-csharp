namespace ConsoleApp.Problems.LeetCode.WordBreak;

public class WordBreakTest
{
    [Theory]
    [InlineData("leetcode", new string[] { "leet","code" }, true)]
    [InlineData("applepenapple", new string[] { "apple","pen" }, true)]
    [InlineData("catsandog", new string[] { "apple","pen" }, false)]
    [InlineData("cars", new string[] { "car","ca","rs" }, true)]
    [InlineData("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", new string[] { "a","aa","aaa","aaaa","aaaaa","aaaaaa","aaaaaaa","aaaaaaaa","aaaaaaaaa","aaaaaaaaaa" }, false)]
    public void TestSolve(string s, IList<string> wordDict, bool expected)
    {
        var solution = new WordBreakSolution();
        var actual = solution.Solve(s, wordDict);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("leetcode", new string[] { "leet","code" }, true)]
    [InlineData("applepenapple", new string[] { "apple","pen" }, true)]
    [InlineData("catsandog", new string[] { "apple","pen" }, false)]
    [InlineData("cars", new string[] { "car","ca","rs" }, true)]
    [InlineData("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", new string[] { "a","aa","aaa","aaaa","aaaaa","aaaaaa","aaaaaaa","aaaaaaaa","aaaaaaaaa","aaaaaaaaaa" }, false)]
    public void TestSolve2(string s, IList<string> wordDict, bool expected)
    {
        var solution = new WordBreakSolution();
        var actual = solution.Solve2(s, wordDict);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}