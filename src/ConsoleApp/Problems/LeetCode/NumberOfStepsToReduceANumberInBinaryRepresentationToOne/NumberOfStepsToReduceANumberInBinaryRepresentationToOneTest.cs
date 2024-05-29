namespace ConsoleApp.Problems.LeetCode.NumberOfStepsToReduceANumberInBinaryRepresentationToOne;

public class NumberOfStepsToReduceANumberInBinaryRepresentationToOneTest
{
    [Theory]
    [InlineData("1101", 6)]
    [InlineData("10", 1)]
    [InlineData("1", 0)]
    [InlineData("1111110011101010110011100100101110010100101110111010111110110010", 89)]
    public void TestSolve(string s, int expected)
    {
        var solution = new NumberOfStepsToReduceANumberInBinaryRepresentationToOneSolution();
        var actual = solution.Solve(s);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}