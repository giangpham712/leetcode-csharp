using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.CountGoodNodes;

public class CountGoodNodesTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(TreeNode input, object expected)
    {
        var solution = new CountGoodNodesSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new TreeNode()
            {
                val = 3,
                left = new TreeNode()
                {
                    val = 1,
                    left = new TreeNode(3)
                },
                right = new TreeNode()
                {
                    val = 4,
                    left = new TreeNode(1),
                    right = new TreeNode(5)
                }
            },
            4
        };

        yield return new object[]
        {
            new TreeNode()
            {
                val = 3,
                left = new TreeNode()
                {
                    val = 3,
                    left = new TreeNode(4),
                    right = new TreeNode(2)
                }
            },
            3
        };
    }
}