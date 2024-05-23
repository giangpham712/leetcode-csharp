namespace ConsoleApp.Problems.LeetCode.LengthOfLongestSubstring;

public class LengthOfLongestSubstringSolution2
{
    public int Solve(string s)
    {
        var longest = 0;
        
        var currentLength = 0;
        var map = new Dictionary<char, int>();
        var currentStartIndex = 0;
        
        for (var i = 0; i < s.Length; i++) {
            if (map.TryGetValue(s[i], out var index)) {
                currentStartIndex = currentStartIndex > index ? currentStartIndex : index;
                map[s[i]] = i;
                currentLength = i - currentStartIndex;
            } else {
                map.Add(s[i], i);
                currentLength++;
            }
            
            longest = Math.Max(currentLength, longest);
        }
        
        return longest;
    }
}