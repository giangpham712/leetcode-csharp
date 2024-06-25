using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.NextPermutation;

public class NextPermutationTest
{
    [Theory]
    [InlineData(new int[] {1,2,3}, new int[] {1,3,2})]
    [InlineData(new int[] {3,2,1}, new int[] {1,2,3})]
    [InlineData(new int[] {1,1,5}, new int[] {1,5,1})]
    [InlineData(new int[] {1,5,4,3,2,1,0}, new int[] {2,0,1,1,3,4,5})]
    [InlineData(new int[] {4,2,0,2,3,2,0}, new int[] {4,2,0,3,0,2,2})]
    public void TestSolve(int[] nums, int[] expected)
    {
        var solution = new NextPermutationSolution();
        solution.Solve(nums);

        nums.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}