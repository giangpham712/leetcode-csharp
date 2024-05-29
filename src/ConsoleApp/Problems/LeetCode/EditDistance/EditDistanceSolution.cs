namespace ConsoleApp.Problems.LeetCode.EditDistance;

public class EditDistanceSolution
{
    public int Solve(string word1, string word2)
    {
        var queue = new Queue<(string, string, int)>();

        queue.Enqueue((word1, word2, 0));
        var seen = new HashSet<(string, string)>();
        
        var max = word1.Length + Math.Abs(word1.Length - word2.Length);
        
        while (queue.TryDequeue(out var item))
        {
            word1 = item.Item1;
            word2 = item.Item2;

            if (!seen.Add((word1, word2)))
            {
                continue;
            }
            
            if (item.Item3 > max)
            {
                continue;
            }

            while (word1.Length > 0 && word2.Length > 0 && word1[0] == word2[0])
            {
                word1 = word1.Substring(1);
                word2 = word2.Substring(1);
            }
            
            if (word1 == word2)
            {
                return item.Item3;
            }

            if (word2.Length > 0)
            {
                queue.Enqueue((word1, word2.Substring(1), item.Item3 + 1));
            }

            if (word2.Length > 0 && word1.Length > 0)
            {
                queue.Enqueue((word1.Substring(1), word2.Substring(1), item.Item3 + 1));
            }

            if (word1.Length > 0)
            {
                queue.Enqueue((word1.Substring(1), word2, item.Item3 + 1));
            }
        }
        
        return max;
    }
}