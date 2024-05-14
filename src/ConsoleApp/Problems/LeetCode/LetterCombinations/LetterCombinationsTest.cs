using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.LetterCombinations;

public class LetterCombinationsTest
{
    [Theory]
    [InlineData("23", new[] {"ad","ae","af","bd","be","bf","cd","ce","cf"})]
    [InlineData("", new string[] {})]
    [InlineData("2", new[] {"a","b","c"})]
    public void TestSolve(string input, IList<string> expected)
    {
        var solution = new LetterCombinationsSolution();
        var actual = solution.Solve(input);

        actual.Count.Should().Be(expected.Count);
        foreach (var combination in expected)
        {
            actual.Should().Contain(combination);
        }
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}