namespace ConsoleApp.Problems.LeetCode.MultiplyStrings;

public class MultiplyStringsTest
{
    [Theory]
    [InlineData("2", "3", "6")]
    [InlineData("123", "456", "56088")]
    public void TestSolve(string num1, string num2, string expected)
    {
        var solution = new MultiplyStringsSolution();
        var actual = solution.Solve(num1, num2);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}