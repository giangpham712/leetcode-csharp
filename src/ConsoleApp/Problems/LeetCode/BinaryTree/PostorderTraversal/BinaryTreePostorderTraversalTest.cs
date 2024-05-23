using DataStructures.LeetCode;
using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.PostorderTraversal;

public class BinaryTreePostorderTraversalTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(TreeNode root, IList<int> expected)
    {
        var solution = new BinaryTreePostorderTraversalSolution();
        var actual = solution.Solve(root);

        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve2(TreeNode root, IList<int> expected)
    {
        var solution = new BinaryTreePostorderTraversalSolution2();
        var actual = solution.Solve(root);

        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
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
            new List<int>() { 3,2,1 }
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
        
        yield return new object[]
        {
            new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode()
                    {
                        val = 4
                    },
                    right = new TreeNode()
                    {
                        val = 5
                    }
                },
                right = new TreeNode()
                {
                    val = 3,
                },
            },
            new List<int>() { 4, 5, 2, 3, 1 }
        };
    }
}