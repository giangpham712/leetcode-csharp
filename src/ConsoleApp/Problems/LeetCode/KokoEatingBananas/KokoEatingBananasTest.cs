namespace ConsoleApp.Problems.LeetCode.KokoEatingBananas;

public class KokoEatingBananasTest
{
    [Theory]
    [InlineData(new[] {3,6,7,11}, 8, 4)]
    [InlineData(new[] {30,11,23,4,20}, 5, 30)]
    [InlineData(new[] {30,11,23,4,20}, 6, 23)]
    public void TestSolve(int[] piles, int h, int expected)
    {
        var solution = new KokoEatingBananasSolution();
        var actual = solution.Solve(piles, h);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}