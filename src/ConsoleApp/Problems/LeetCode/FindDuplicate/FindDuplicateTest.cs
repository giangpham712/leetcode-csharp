namespace ConsoleApp.Problems.LeetCode.FindDuplicate;

public class FindDuplicateTest
{
    [Theory]
    [InlineData(new [] { 1,3,4,2,2 }, 2)]
    [InlineData(new [] { 3,1,3,4,2 }, 3)]
    [InlineData(new [] { 3,3,3,3,3 }, 3)]
    public void TestSolve(int[] nums, int expected)
    {
        var solution = new FindDuplicateSolution();
        var actual = solution.Solve(nums);

        Assert.Equal(expected, actual);
    }
}