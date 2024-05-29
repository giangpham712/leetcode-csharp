namespace ConsoleApp.Problems.LeetCode.CountPairsWhoseSumIsLessThanTarget;

public class CountPairsWhoseSumIsLessThanTargetTest
{
    [Theory]
    [InlineData(new[] {-1,1,2,3,1}, 2, 3)]
    [InlineData(new[] {-6,2,5,-2,-7,-1,3}, -2, 10)]
    [InlineData(new[] {-4,6,-9,-8,-9,-9}, -17, 3)]
    [InlineData(new[] {6,-1,7,4,2,3}, 8, 3)]
    public void TestSolve(IList<int> nums, int target, int expected)
    {
        var solution = new CountPairsWhoseSumIsLessThanTargetSolution();
        var actual = solution.Solve(nums, target);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}