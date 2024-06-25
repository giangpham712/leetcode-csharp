namespace ConsoleApp.Problems.LeetCode.RemoveComments;

public class RemoveCommentsTest
{
    [Theory]
    [InlineData(new[] {"/*Test program */", "int main()", "{ ", "  // variable declaration ", "int a, b, c;", "/* This is a test", "   multiline  ", "   comment for ", "   testing */", "a = b + c;", "}"}, new[] {"int main()","{ ","  ","int a, b, c;","a = b + c;","}"})]
    [InlineData(new[] {"a/*comment", "line", "more_comment*/b"}, new[] {"ab"})]
    public void TestSolve(string[] input, IList<string> expected)
    {
        var solution = new RemoveCommentsSolution();
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