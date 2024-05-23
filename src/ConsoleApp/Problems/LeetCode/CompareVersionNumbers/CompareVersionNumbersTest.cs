namespace ConsoleApp.Problems.LeetCode.CompareVersionNumbers;

public class CompareVersionNumbersTest
{
    [Theory]
    [InlineData("1.2", "1.10", -1)]
    [InlineData("1.01", "1.001", 0)]
    [InlineData("1.0", "1.0.0.0", 0)]
    public void TestSolve(string version1, string version2, int expected)
    {
        var solution = new CompareVersionNumbersSolution();
        var actual = solution.Solve(version1, version2);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}