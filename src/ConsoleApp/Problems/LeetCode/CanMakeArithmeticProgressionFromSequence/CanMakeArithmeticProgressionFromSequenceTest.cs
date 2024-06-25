namespace ConsoleApp.Problems.LeetCode.CanMakeArithmeticProgressionFromSequence;

public class ProblemTest
{
    [Theory]
    [InlineData(new[] {3,5,1}, true)]
    [InlineData(new[] {1,2,4}, false)]
    [InlineData(new[] {0,0,0}, true)]
    [InlineData(new[] {-509,-19,-439,-264,-404,-369,-299,-89,-229,-54,-194,16,-544,-159,-124,-474,-334}, true)]
    public void TestSolve(int[] arr, bool expected)
    {
        var solution = new ProblemSolution();
        var actual = solution.Solve(arr);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}