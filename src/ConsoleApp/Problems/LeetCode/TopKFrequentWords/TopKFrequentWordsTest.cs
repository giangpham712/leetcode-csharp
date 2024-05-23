using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.TopKFrequentWords;

public class TopKFrequentWordsTest
{
    [Theory]
    [InlineData(new[] {"i","love","leetcode","i","love","coding"}, 2, new[] {"i","love"})]
    [InlineData(new[] {"the","day","is","sunny","the","the","the","sunny","is","is"}, 4, new[] {"the","is","sunny","day"})]
    public void TestSolve(string[] words, int k, object expected)
    {
        var solution = new TopKFrequentWordsSolution();
        var actual = solution.Solve(words, k);

        expected.Should().BeEquivalentTo(actual, options => options.WithStrictOrdering());
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}