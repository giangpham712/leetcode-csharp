namespace ConsoleApp.Problems.LeetCode.CountingBits;

public class CountingBitsTest
{
    [Theory]
    [InlineData(2, new[] {0,1,1})]
    [InlineData(5, new[] {0,1,1,2,1,2})]
    public void TestSolve(int input, int[] expected)
    {
        var solution = new CountingBitsSolution();
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