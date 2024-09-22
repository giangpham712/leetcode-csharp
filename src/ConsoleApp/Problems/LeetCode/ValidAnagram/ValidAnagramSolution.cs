namespace ConsoleApp.Problems.LeetCode.ValidAnagram;

public class ProblemSolution
{
    public bool Solve(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var freq1 = new Dictionary<char, int>();
        var freq2 = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (!freq1.ContainsKey(c))
            {
                freq1[c] = 0;
            }

            freq1[c]++;
        }
        
        foreach (var c in t)
        {
            if (!freq2.ContainsKey(c))
            {
                freq2[c] = 0;
            }

            freq2[c]++;
        }

        foreach (var c in freq1.Keys)
        {
            if (!freq2.ContainsKey(c) || freq2[c] != freq1[c])
            {
                return false;
            }
        }

        return true;
    }
}