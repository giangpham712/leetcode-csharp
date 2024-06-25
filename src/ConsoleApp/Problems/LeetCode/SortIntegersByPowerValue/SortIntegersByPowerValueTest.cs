namespace ConsoleApp.Problems.LeetCode.SortIntegersByPowerValue;

public class SortIntegersByPowerValueTest
{
    [Theory]
    [InlineData(12, 15, 2, 13)]
    [InlineData(7, 11, 4, 7)]
    public void TestSolve(int lo, int hi, int k, int expected)
    {
        var solution = new SortIntegersByPowerValueSolution();
        var actual = solution.Solve(lo, hi, k);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}