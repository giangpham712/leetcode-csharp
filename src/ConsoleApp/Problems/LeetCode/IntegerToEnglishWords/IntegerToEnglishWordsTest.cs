namespace ConsoleApp.Problems.LeetCode.IntegerToEnglishWords;

public class IntegerToEnglishWordsTest
{
    [Theory]
    [InlineData(123, "One Hundred Twenty Three")]
    [InlineData(12345, "Twelve Thousand Three Hundred Forty Five")]
    [InlineData(1234567, "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven")]
    public void TestSolve(int input, string expected)
    {
        var solution = new IntegerToEnglishWordsSolution();
        var actual = solution.NumberToWords(input);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(123, "One Hundred Twenty Three")]
    [InlineData(12345, "Twelve Thousand Three Hundred Forty Five")]
    [InlineData(1234567, "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven")]
    public void TestSolve2(int input, string expected)
    {
        var solution = new IntegerToEnglishWordsSolution2();
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