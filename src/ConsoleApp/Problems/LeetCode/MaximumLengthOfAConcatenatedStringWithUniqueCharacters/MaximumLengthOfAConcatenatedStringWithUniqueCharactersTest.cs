namespace ConsoleApp.Problems.LeetCode.MaximumLengthOfAConcatenatedStringWithUniqueCharacters;

public class MaximumLengthOfAConcatenatedStringWithUniqueCharactersTest
{
    [Theory]
    [InlineData(new[] {"un","iq","ue"}, 4)]
    [InlineData(new[] {"cha","r","act","ers"}, 6)]
    public void TestSolve(IList<string> arr, int expected)
    {
        var solution = new MaximumLengthOfAConcatenatedStringWithUniqueCharactersSolution();
        var actual = solution.Solve(arr);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}