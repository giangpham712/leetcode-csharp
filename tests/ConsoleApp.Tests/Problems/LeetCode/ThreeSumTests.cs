using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems.LeetCode;

public class ThreeSumTests
{
    [Theory]
    [InlineData("-1, 0, 1, 2, -1, -4", "-1, -1, 2 | -1, 0, 1")]
    public void Solve(string nums, string expected)
    {
        var solution = new ThreeSum();
        var actual = solution.Solve(nums.Split(", ", StringSplitOptions.TrimEntries).Select(int.Parse).ToArray());
        
        
    }
}