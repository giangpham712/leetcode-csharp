namespace ConsoleApp.Problems.LeetCode.LargestPalindromicNumber;

public class LargestPalindromicNumberTest
{
    [Theory]
    [InlineData("444947137", "7449447")]
    [InlineData("00009", "9")]
    public void TestSolve(string input, string expected)
    {
        var solution = new LargestPalindromicNumberSolution();
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