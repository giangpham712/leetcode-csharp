namespace ConsoleApp.Problems.LeetCode.MinimumNumberOfOperationsToMakeXAndYEqual;

public class MinimumNumberOfOperationsToMakeXAndYEqualTest
{
    [Theory]
    [InlineData(26, 1, 3)]
    [InlineData(54, 2, 4)]
    [InlineData(25, 30, 5)]
    [InlineData(4, 1, 2)]
    [InlineData(2, 1, 1)]
    [InlineData(18, 1, 5)]
    [InlineData(100, 15, 6)]
    public void TestSolve(int x, int y, int expected)
    {
        var solution = new MinimumNumberOfOperationsToMakeXAndYEqualSolution();
        var actual = solution.Solve(x, y);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(26, 1, 3)]
    [InlineData(54, 2, 4)]
    [InlineData(25, 30, 5)]
    [InlineData(4, 1, 2)]
    [InlineData(2, 1, 1)]
    [InlineData(18, 1, 5)]
    [InlineData(100, 15, 6)]
    public void TestSolve2(int x, int y, int expected)
    {
        var solution = new MinimumNumberOfOperationsToMakeXAndYEqualSolution2();
        var actual = solution.Solve(x, y);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}