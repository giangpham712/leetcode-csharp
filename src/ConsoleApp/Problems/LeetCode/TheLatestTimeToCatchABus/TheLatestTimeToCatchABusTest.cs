namespace ConsoleApp.Problems.LeetCode.TheLatestTimeToCatchABus;

public class TheLatestTimeToCatchABusTest
{
    [Theory]
    [InlineData(new[] {10,20}, new[] {2,17,18,19}, 2, 16)]
    [InlineData(new[] {20,30,10}, new[] {19,13,26,4,25,11,21}, 2, 20)]
    [InlineData(new[] {3}, new[] {2}, 2, 3)]
    public void TestSolve(int[] buses, int[] passengers, int capacity, int expected)
    {
        var solution = new TheLatestTimeToCatchABusSolution();
        var actual = solution.Solve(buses, passengers, capacity);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}