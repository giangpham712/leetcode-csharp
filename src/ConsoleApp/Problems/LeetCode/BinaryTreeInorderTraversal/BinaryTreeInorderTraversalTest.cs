using DataStructures.LeetCode;
using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.BinaryTreeInorderTraversal;

public class BinaryTreeInorderTraversalTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(TreeNode root, IList<int> expected)
    {
        var solution = new BinaryTreeInorderTraversalSolution();
        var actual = solution.Solve(root);

        actual.Should().BeEquivalentTo(expected);
    }
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve2(TreeNode root, IList<int> expected)
    {
        var solution = new BinaryTreeInorderTraversalSolution2();
        var actual = solution.Solve(root);

        actual.Should().BeEquivalentTo(expected);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new TreeNode()
            {
                val = 1,
                left = null,
                right = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode()
                    {
                        val = 3
                    }
                }
            },
            new List<int>() { 1,3,2 }
        };

        yield return new object[]
        {
            null,
            new List<int>() { }
        };
        
        yield return new object[]
        {
            new TreeNode()
            {
                val = 1
            },
            new List<int>() { 1 }
        };
    }
}