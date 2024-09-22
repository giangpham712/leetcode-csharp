namespace DataStructures.LeetCode;

public class AdjacencyNode
{
    public int val;
    public IList<AdjacencyNode> neighbors;

    public AdjacencyNode() {
        val = 0;
        neighbors = new List<AdjacencyNode>();
    }

    public AdjacencyNode(int _val) {
        val = _val;
        neighbors = new List<AdjacencyNode>();
    }

    public AdjacencyNode(int _val, List<AdjacencyNode> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}