namespace ConsoleApp.Problems.LeetCode.LinkedListCycle;

public class LinkedListCycleTest
{
    [Theory]
    [InlineData(default, default)]
    public void TestSolve(object input, object expected)
    {
        var solution = new LinkedListCycleSolution();
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