namespace ConsoleApp.Problems.LeetCode.MinDeletionsToMakeCharacterFrequenciesUnique;

public class MinDeletionsToMakeCharacterFrequenciesUniqueTest
{
    [Theory]
    [InlineData(default, default)]
    public void TestSolve(object input, object expected)
    {
        var solution = new MinDeletionsToMakeCharacterFrequenciesUniqueSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
}