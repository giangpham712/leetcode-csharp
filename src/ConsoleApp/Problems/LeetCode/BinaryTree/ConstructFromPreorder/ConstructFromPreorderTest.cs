using DataStructures.Extensions;
using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.ConstructFromPreorder;

public class ConstructFromPreorderTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[] preorder, TreeNode expected)
    {
        var solution = new ConstructFromPreorderSolution();
        var actual = solution.Solve(preorder);

        Assert.True(expected.IsEquivalentTo(actual));
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[]
            {
                8,5,1,7,10,12
            },
            new TreeNode
            {
                val = 8,
                left = new TreeNode()
                {
                    val = 5,
                    left = new TreeNode()
                    {
                        val = 1
                    },
                    right = new TreeNode()
                    {
                        val = 7
                    }
                },
                right = new TreeNode()
                {
                    val = 10,
                    right = new TreeNode()
                    {
                        val = 12
                    }
                }
            }
        };

        yield return new object[]
        {
            new int[] {1,3},
            new TreeNode()
            {
                val = 1,
                right = new TreeNode()
                {
                    val = 3
                }
            }
        };
    }
}