using Xunit;

namespace ConsoleApp.Problems.LeetCode.FirstMissingPositive;

public class FindMissingPositiveTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 0 }, 3)]
    [InlineData(new int[] { 3, 4, -1, 1 }, 2)]
    [InlineData(new int[] { 7, 8, 9, 11, 12 }, 1)]
    [InlineData(new int[] { 3,3,1,4,0 }, 2)]
    [InlineData(new int[] { 1,1 }, 2)]
    public void TestSolve(int[] nums, int expected)
    {
        var solution = new FindMissingPositiveSolution();
        var actual = solution.Solve(nums);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new int[] { 1, 2, 0 }, 3)]
    [InlineData(new int[] { 3, 4, -1, 1 }, 2)]
    [InlineData(new int[] { 7, 8, 9, 11, 12 }, 1)]
    [InlineData(new int[] { 3,3,1,4,0 }, 2)]
    [InlineData(new int[] { 1,1 }, 2)]
    public void TestSolve2(int[] nums, int expected)
    {
        var solution = new FindMissingPositiveSolution2();
        var actual = solution.Solve(nums);
        
        Assert.Equal(expected, actual);
    }
}