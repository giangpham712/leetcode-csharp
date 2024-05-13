namespace ConsoleApp.Problems.LeetCode.MyAtoi;

public class MyAtoiTest
{
    [Theory]
    [InlineData("42", 42)]
    [InlineData(" -042", -42)]
    [InlineData("1337c0d3", 1337)]
    [InlineData("0-1", 0)]
    [InlineData("words and 987", 0)]
    public void TestSolve(string input, int expected)
    {
        var solution = new MyAtoiSolution();
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