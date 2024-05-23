using DataStructures.Extensions;
using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.BuildTreeFromPreorderAndInorder;

public class BinaryTreeBuildTreeFromPreorderAndInorderTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[] preorder, int[] inorder, TreeNode expected)
    {
        var solution = new BuildTreeFromPreorderAndInorderSolution();
        var actual = solution.Solve(preorder, inorder);

        Assert.True(expected.IsEquivalentTo(actual));
    }

    private static IEnumerable<object[]> TestData()
    {
        
        yield return new object[]
        {
            new[] {3,9,20,15,7},
            new[] {9,3,15,20,7},
            new TreeNode()
            {
                val = 3,
                left = new TreeNode()
                {
                    val = 9
                },
                right = new TreeNode()
                {
                    val = 20,
                    left = new TreeNode()
                    {
                        val = 15
                    },
                    right = new TreeNode()
                    {
                        val = 7
                    }
                }
            }
        };

        yield return new object[]
        {
            new[] { 1, 2 },
            new[] { 2, 1 },
            new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2
                }
            }
        };
        
        yield return new object[]
        {
            new[] { 1, 2 },
            new[] { 1, 2 },
            new TreeNode()
            {
                val = 1,
                right = new TreeNode()
                {
                    val = 2
                }
            }
        };
    }
}