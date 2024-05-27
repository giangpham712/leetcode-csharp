namespace ConsoleApp.Problems.LeetCode.FibonacciNumber;

public class FibonacciNumberTest
{
    [Theory]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    public void TestSolve(int input, int expected)
    {
        var solution = new FibonacciNumberSolution();
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