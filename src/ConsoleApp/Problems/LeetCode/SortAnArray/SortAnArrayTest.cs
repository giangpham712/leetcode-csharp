using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.SortAnArray;

public class ProblemTest
{
    [Theory]
    [InlineData(new[] {5,2,3,1}, new[] {1,2,3,5})]
    [InlineData(new[] {5,1,1,2,0,0}, new[] {0,0,1,1,2,5})]
    [InlineData(new[] {-4,0,7,4,9,-5,-1,0,-7,-1}, new[] {-7,-5,-4,-1,-1,0,0,4,7,9})]
    public void TestQuickSort(int[] input, int[] expected)
    {
        var solution = new ProblemSolution.QuickSort();
        var actual = solution.Solve(input);

        actual.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }
    
    [Theory]
    [InlineData(new[] {5,2,3,1}, new[] {1,2,3,5})]
    [InlineData(new[] {5,1,1,2,0,0}, new[] {0,0,1,1,2,5})]
    [InlineData(new[] {-4,0,7,4,9,-5,-1,0,-7,-1}, new[] {-7,-5,-4,-1,-1,0,0,4,7,9})]
    public void TestMergeSort(int[] input, int[] expected)
    {
        var solution = new ProblemSolution.MergeSort();
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