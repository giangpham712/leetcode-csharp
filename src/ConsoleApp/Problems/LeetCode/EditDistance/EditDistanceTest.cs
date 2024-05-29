namespace ConsoleApp.Problems.LeetCode.EditDistance;

public class EditDistanceTest
{
    [Theory]
    [InlineData("horse", "ros", 3)]
    [InlineData("intention", "execution", 5)]
    [InlineData("", "a", 1)]
    [InlineData("pneumonoultramicroscopicsilicovolcanoconiosis", "ultramicroscopically", 27)]
    public void TestSolve(string word1, string word2, int expected)
    {
        var solution = new EditDistanceSolution();
        var actual = solution.Solve(word1, word2);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("horse", "ros", 3)]
    [InlineData("intention", "execution", 5)]
    [InlineData("", "a", 1)]
    [InlineData("pneumonoultramicroscopicsilicovolcanoconiosis", "ultramicroscopically", 27)]
    public void TestSolve2(string word1, string word2, int expected)
    {
        var solution = new EditDistanceSolution2();
        var actual = solution.Solve(word1, word2);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}