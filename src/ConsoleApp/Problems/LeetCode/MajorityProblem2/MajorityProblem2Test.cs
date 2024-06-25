using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.MajorityProblem2;

public class MajorityProblem2Test
{
    [Theory]
    [InlineData(new int[] {3,2,3}, new int[] {3})]
    [InlineData(new int[] {1}, new int[] {1})]
    [InlineData(new int[] {1,2}, new int[] {1,2})]
    [InlineData(new int[] {6,5,5}, new int[] {5})]
    [InlineData(new int[] {2,1,1,3,1,4,5,6}, new int[] {1})]
    public void TestSolve(int[] input, int[] expected)
    {
        var solution = new MajorityProblem2Solution();
        var actual = solution.Solve(input);

        actual.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}