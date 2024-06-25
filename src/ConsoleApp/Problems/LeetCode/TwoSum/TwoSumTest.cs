using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.TwoSum;

public class TwoSumTest
{
    [Theory]
    [InlineData(new[] {2,7,11,15}, 9, new[] {0,1})]
    [InlineData(new[] {3,2,4}, 6, new[] {1,2})]
    [InlineData(new[] {3,3}, 6, new[] {0,1})]
    [InlineData(new[] {0,4,3,0}, 0, new[] {0,3})]
    public void TestSolve(int[] input, int sum, int[] expected)
    {
        var solution = new TwoSumSolution();
        var actual = solution.Solve(input, sum);

        actual.Should().BeEquivalentTo(expected);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}