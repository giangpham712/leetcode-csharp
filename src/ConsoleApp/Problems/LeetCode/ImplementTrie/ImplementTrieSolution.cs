namespace ConsoleApp.Problems.LeetCode.ImplementTrie;

public class ImplementTrieSolution
{
    public bool?[] Solve(string[] commands, string[][] args)
    {
        var trie = new Trie();

        var outputs = new bool?[args.Length];

        for (int i = 1; i < commands.Length; i++)
        {
            outputs[i] = ProcessCommand(trie, commands[i], args[i]);
        }
        
        return outputs;
    }

    public bool? ProcessCommand(Trie trie, string command, string[] arg)
    {
        switch (command)
        {
            case "insert":
                trie.Insert(arg[0]);
                return null;
            case "search":
                return trie.Search(arg[0]);
            case "startsWith":
                return trie.StartsWith(arg[0]);
        }

        return null;
    }
}

public class Trie
{
    private TrieNode root = new TrieNode();
    private HashSet<string> Words;
    
    public Trie()
    {
        Words = new HashSet<string>();
    }
    
    public void Insert(string word) {
        var current = root;
        foreach (var c in word)
        {
            if (current.Nexts.TryGetValue(c, out var node))
            {
                
            }
            else
            {
                node = new TrieNode()
                {
                    Character = c
                };
                current.Nexts.Add(c, node);
            }

            current = node;
        }

        current.Word = true;

        Words.Add(word);
    }
    
    public bool Search(string word)
    {
        return Words.Contains(word);
    }
    
    public bool StartsWith(string prefix)
    {
        var current = root;
        foreach (var c in prefix)
        {
            if (current.Nexts.TryGetValue(c, out var node))
            {
                current = node;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}

public class TrieNode
{
    public Dictionary<char, TrieNode> Nexts { get; }
    
    public char? Character { get; set; }
    
    public bool Word { get; set; }
    
    public TrieNode()
    {
        Nexts = new Dictionary<char, TrieNode>();
    }
}