namespace ConsoleApp.Problems.LeetCode.SumOfTwoIntegers;

public class SumOfTwoIntegersTest
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    public void TestSolve(int a, int b, int expected)
    {
        var solution = new SumOfTwoIntegersSolution();
        var actual = solution.Solve(a, b);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}