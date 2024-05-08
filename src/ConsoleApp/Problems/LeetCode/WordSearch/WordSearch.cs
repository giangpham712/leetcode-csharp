namespace ConsoleApp.Problems.LeetCode.WordSearch;

public class WordSearch
{
    public bool Solve(char[][] board, string word)
    {
        var frequencies = new Dictionary<char, int>();
        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[0].Length; j++)
            {
                if (!frequencies.ContainsKey(board[i][j]))
                {
                    frequencies[board[i][j]] = 0;
                }

                frequencies[board[i][j]] = frequencies[board[i][j]] + 1;
            }    
        }

        var requireFrequencies = word.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

        foreach (var letterFrequency in requireFrequencies)
        {
            if (!frequencies.TryGetValue(letterFrequency.Key, out int value) || value < letterFrequency.Value)
            {
                return false;
            }
        }

        if (requireFrequencies[word.First()] > requireFrequencies[word.Last()])
        {
            word = string.Join("", word.Reverse());
        }
        
        var tracked = new HashSet<string>();
        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[0].Length; j++)
            {
                var check = BackTrack(board, word, i, j, new HashSet<int>(), tracked);
                if (check)
                {
                    return true;
                }
            }    
        }

        return false;
    }

    private bool BackTrack(char[][] board, string word, int x, int y, HashSet<int> visited, HashSet<string> tracked)
    {
        if (x < 0 || x >= board.Length || y < 0 || y >= board[0].Length)
        {
            return false;
        }

        var key = x * board[0].Length + y;

        if (visited.Contains(key))
        {
            return false;
        }

        return word[0] == board[x][y] && 
               (
                   word.Length == 1 ||
                   BackTrack(board, word.Substring(1), x - 1, y, new HashSet<int>([.. visited, key]), tracked) ||
                   BackTrack(board, word.Substring(1), x + 1, y, new HashSet<int>([.. visited, key]), tracked) ||
                   BackTrack(board, word.Substring(1), x, y - 1, new HashSet<int>([.. visited, key]), tracked) ||
                   BackTrack(board, word.Substring(1), x, y + 1, new HashSet<int>([.. visited, key]), tracked)
               );
    }
}