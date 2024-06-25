using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.SortColors;

public class SortColorsTest
{
    [Theory]
    [InlineData(new[] {2,0,2,1,1,0}, new[] {0,0,1,1,2,2})]
    [InlineData(new[] {2,0,1}, new[] {0,1,2})]
    public void TestSolve(int[] input, int[] expected)
    {
        var solution = new SortColorsSolution();
        solution.Solve(input);

        input.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }
    
    [Theory]
    [InlineData(new[] {2,0,2,1,1,0}, new[] {0,0,1,1,2,2})]
    [InlineData(new[] {2,0,1}, new[] {0,1,2})]
    [InlineData(new[] {1}, new[] {1})]
    public void TestSolve2(int[] input, int[] expected)
    {
        var solution = new SortColorsSolution();
        solution.Solve2(input);

        input.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }

    
}

