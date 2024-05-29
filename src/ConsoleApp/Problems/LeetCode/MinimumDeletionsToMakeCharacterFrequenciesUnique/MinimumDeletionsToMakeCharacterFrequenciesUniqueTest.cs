namespace ConsoleApp.Problems.LeetCode.MinimumDeletionsToMakeCharacterFrequenciesUnique;

public class MinimumDeletionsToMakeCharacterFrequenciesUniqueTest
{
    [Theory]
    [InlineData("aab", 0)]
    [InlineData("aaabbbcc", 2)]
    [InlineData("ceabaacb", 2)]
    [InlineData("bbcebab", 2)]
    public void TestSolve(string input, int expected)
    {
        var solution = new MinimumDeletionsToMakeCharacterFrequenciesUniqueSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}