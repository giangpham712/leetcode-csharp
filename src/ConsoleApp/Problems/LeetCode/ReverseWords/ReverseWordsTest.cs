namespace ConsoleApp.Problems.LeetCode.ReverseWords;

public class ReverseWordsTest
{
    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void TestSolve(string input, string expected)
    {
        var solution = new ReverseWordsSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void TestSolve2(string input, string expected)
    {
        var solution = new ReverseWordsSolution2();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
}