namespace ConsoleApp.Problems.LeetCode.MinimumNumberOfFoodBucketsToFeedTheHamsters;

public class MinimumNumberOfFoodBucketsToFeedTheHamstersTest
{
    [Theory]
    [InlineData("H..H", 2)]
    [InlineData(".H.H.", 1)]
    [InlineData(".HHH.", -1)]
    [InlineData(".HH.H.H.H..", 3)]
    public void TestSolve(string hamsters, int expected)
    {
        var solution = new MinimumNumberOfFoodBucketsToFeedTheHamstersSolution();
        var actual = solution.Solve(hamsters);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("H..H", 2)]
    [InlineData(".H.H.", 1)]
    [InlineData(".HHH.", -1)]
    [InlineData(".HH.H.H.H..", 3)]
    public void TestSolve2(string hamsters, int expected)
    {
        var solution = new MinimumNumberOfFoodBucketsToFeedTheHamstersSolution2();
        var actual = solution.Solve(hamsters);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}