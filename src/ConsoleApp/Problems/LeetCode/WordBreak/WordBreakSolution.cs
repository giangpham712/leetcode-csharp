namespace ConsoleApp.Problems.LeetCode.WordBreak;

public class WordBreakSolution
{
    public bool Solve(string s, IList<string> wordDict)
    {
        var requiredLetters = new HashSet<char>(s);

        foreach (var word in wordDict)
        {
            foreach (var c in word)
            {
                requiredLetters.Remove(c);
            }
        }

        if (requiredLetters.Count > 0)
        {
            return false;
        }
        
        wordDict = wordDict.OrderByDescending(x => x.Length).ToList();
        return BackTrack(s, wordDict);
    }

    private bool BackTrack(string remain, IList<string> wordDict)
    {
        foreach (var word in wordDict)
        {
            if (remain == word)
            {
                return true;
            }

            if (remain.StartsWith(word) && BackTrack(remain.Substring(word.Length), wordDict))
            {
                return true;
            }
        }

        return false;
    }

    public bool Solve2(string s, IList<string> wordDict)
    {
        return false;
    }
}