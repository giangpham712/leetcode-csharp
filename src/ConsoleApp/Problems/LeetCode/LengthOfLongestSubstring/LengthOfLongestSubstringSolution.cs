namespace ConsoleApp.Problems.LeetCode.LengthOfLongestSubstring;

public class LengthOfLongestSubstringSolution
{
    public int Solve(string s)
    {
        if (s.Length <= 1)
        {
            return s.Length;
        }
        
        var longest = 0;
        var start = 0;

        while (start < s.Length - 1)
        {
            var length = 0;
            var seen = new Dictionary<char, int>();
            for (var i = start; i < s.Length; i++)
            {
                if (seen.ContainsKey(s[i]))
                {
                    longest = length > longest ? length : longest;
                    start = seen[s[i]] + 1;
                    break;
                }

                seen.Add(s[i], i);
                length++;
                
                if (i == s.Length - 1)
                {
                    longest = length > longest ? length : longest;
                    start = s.Length;
                }
            }
        }

        return longest;
    }
}