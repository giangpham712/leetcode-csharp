using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.FindAllAnagramsInAString;

public class FindAllAnagramsInAStringTest
{
    [Theory]
    [InlineData("cbaebabacd", "abc", new int[] {0,6})]
    [InlineData("abab", "ab", new int[] {0,1,2})]
    public void TestSolve(string s, string p, int[] expected)
    {
        var solution = new FindAllAnagramsInAStringSolution();
        var actual = solution.Solve(s, p);

        actual.Should().BeEquivalentTo(expected.ToList(), opt => opt.WithStrictOrdering());
    }
    
    [Theory]
    [InlineData("cbaebabacd", "abc", new int[] {0,6})]
    [InlineData("abab", "ab", new int[] {0,1,2})]
    public void TestSolve2(string s, string p, int[] expected)
    {
        var solution = new FindAllAnagramsInAStringSolution();
        var actual = solution.Solve2(s, p);

        actual.Should().BeEquivalentTo(expected.ToList(), opt => opt.WithStrictOrdering());
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}