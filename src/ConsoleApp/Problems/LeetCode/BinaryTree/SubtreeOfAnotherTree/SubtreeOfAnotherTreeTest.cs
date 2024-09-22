using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.SubtreeOfAnotherTree;

public class SubtreeOfAnotherTreeTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(TreeNode root, TreeNode subRoot, bool expected)
    {
        var solution = new SubtreeOfAnotherTreeSolution();
        var actual = solution.Solve(root, subRoot);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new TreeNode(3)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(2)
                },
                right = new TreeNode(5)
            },
            new TreeNode(4)
            {
                left = new TreeNode(1),
                right = new TreeNode(2),
            },
            true
        };
        
        yield return new object[]
        {
            new TreeNode(3)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(2)
                    {
                        left = new TreeNode(0)
                    }
                },
                right = new TreeNode(5)
            },
            new TreeNode(4)
            {
                left = new TreeNode(1),
                right = new TreeNode(2),
            },
            false
        };
    }
}