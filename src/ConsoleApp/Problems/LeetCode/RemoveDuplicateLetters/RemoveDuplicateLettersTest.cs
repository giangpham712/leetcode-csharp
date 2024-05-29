namespace ConsoleApp.Problems.LeetCode.RemoveDuplicateLetters;

public class RemoveDuplicateLettersTest
{
    [Theory]
    [InlineData("bcabc", "abc")]
    [InlineData("cbacdcbc", "acdb")]
    public void TestSolve(string input, string expected)
    {
        var solution = new RemoveDuplicateLettersSolution();
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