using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.CloneGraph;

public class CloneGraphTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(AdjacencyNode input, AdjacencyNode expected)
    {
        var solution = new CloneGraphSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        {
            var node1 = new AdjacencyNode(1);
            var node2 = new AdjacencyNode(2);
            var node3 = new AdjacencyNode(3);
            var node4 = new AdjacencyNode(4);
            node1.neighbors.Add(node2);
            node1.neighbors.Add(node4);
            node2.neighbors.Add(node1);
            node2.neighbors.Add(node3);
            node3.neighbors.Add(node2);
            node3.neighbors.Add(node4);
            node4.neighbors.Add(node1);
            node4.neighbors.Add(node3);

            var node1Clone = new AdjacencyNode(1);
            var node2Clone = new AdjacencyNode(2);
            var node3Clone = new AdjacencyNode(3);
            var node4Clone = new AdjacencyNode(4);
            node1Clone.neighbors.Add(node2Clone);
            node1Clone.neighbors.Add(node4Clone);
            node2Clone.neighbors.Add(node1Clone);
            node2Clone.neighbors.Add(node3Clone);
            node3Clone.neighbors.Add(node2Clone);
            node3Clone.neighbors.Add(node4Clone);
            node4Clone.neighbors.Add(node1Clone);
            node4Clone.neighbors.Add(node3Clone);

            yield return new object[]
            {
                node1,
                node1Clone
            };
        }

        {
            var node1 = new AdjacencyNode(1);
            var node1Clone = new AdjacencyNode(1);
            yield return new object[]
            {
                node1,
                node1Clone
            };
        }

        {
            yield return new object[]
            {
                null,
                null
            };
        }
    }
}