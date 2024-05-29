using System.Text;
using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.SerializeAndDeserialize;

public class BinaryTreeSerializeAndDeserializeSolution
{
    public TreeNode Solve(TreeNode root)
    {
        var ser = new PreorderCodec();
        var deser = new PreorderCodec();
        return deser.deserialize(ser.serialize(root));
    }
}

public class PreorderCodec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        var stringBuilder = new StringBuilder();
        preorderSerialize(root, stringBuilder);
        return stringBuilder.ToString();
    }

    private void preorderSerialize(TreeNode node, StringBuilder stringBuilder)
    {
        if (node == null)
        {
            stringBuilder.Append('|');
            return;
        }
        
        stringBuilder.Append(node.val);
        stringBuilder.Append('|');
        preorderSerialize(node.left, stringBuilder);
        preorderSerialize(node.right, stringBuilder);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        var nodes = new Queue<string>(data.Split("|"));

        var root = preorderDeserialize(nodes);        
        
        return root;
    }

    private TreeNode preorderDeserialize(Queue<string> nodes)
    {
        if (nodes.TryDequeue(out var nodeValue) && nodeValue != "")
        {
            var node = new TreeNode(int.Parse(nodeValue));
            node.left = preorderDeserialize(nodes);
            node.right = preorderDeserialize(nodes);
            return node;
        }

        return null;
    }
}

public class LevelorderCodec
{
    public string serialize(TreeNode root)
    {
        return default;
    }

    public TreeNode deserialize(string data)
    {
        return default;
    }
}