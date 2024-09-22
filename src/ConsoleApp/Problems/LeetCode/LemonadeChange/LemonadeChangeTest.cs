namespace ConsoleApp.Problems.LeetCode.LemonadeChange;

public class LemonadeChangeTest
{
    [Theory]
    [InlineData(new int[] {5,5,5,10,20}, true)]
    [InlineData(new int[] {5,5,10,10,20}, false)]
    [InlineData(new int[] {5,5,5,5,20,20,5,5,20,5}, false)]
    public void TestSolve(int[] input, bool expected)
    {
        var solution = new LemonadeChangeSolution();
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