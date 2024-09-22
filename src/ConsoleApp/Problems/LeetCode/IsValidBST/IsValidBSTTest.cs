using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.IsValidBST;

public class ProblemTest
{
    [Theory]
    [InlineData(default, true)]
    public void IsValidBSTTest(TreeNode input, bool expected)
    {
        var solution = new IsValidBSTSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
}