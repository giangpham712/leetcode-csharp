namespace ConsoleApp.Problems.LeetCode.BestTimeToBuyAndSellStock3;

public class BestTimeToBuyAndSellStock3Test
{
    [Theory]
    [InlineData(new[] {3,3,5,0,0,3,1,4}, 6)]
    [InlineData(new[] {1,2,3,4,5}, 4)]
    [InlineData(new[] {7,6,4,3,1}, 0)]
    public void TestSolve(int[] prices, object expected)
    {
        var solution = new BestTimeToBuyAndSellStock3Solution();
        var actual = solution.Solve(prices);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}