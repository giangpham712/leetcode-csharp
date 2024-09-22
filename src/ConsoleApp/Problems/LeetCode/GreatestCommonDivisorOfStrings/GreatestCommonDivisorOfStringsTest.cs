namespace ConsoleApp.Problems.LeetCode.GreatestCommonDivisorOfStrings;

public class ProblemTest
{
    [Theory]
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData("ABABAB", "ABAB", "AB")]
    [InlineData("LEET", "CODE", "")]
    public void TestSolve(string str1, string str2, string expected)
    {
        var solution = new ProblemSolution();
        var actual = solution.Solve(str1, str2);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}