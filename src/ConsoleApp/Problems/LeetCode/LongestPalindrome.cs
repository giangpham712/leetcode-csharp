namespace ConsoleApp.Problems.LeetCode;

public class LongestPalindrome
{
    public string Solve(string s)
    {
        var dp = new bool[s.Length, s.Length];
        
        string longest = string.Empty;
        for (var j = 0; j < s.Length ; j++) {
            for (var i = 0; i <= j; i++) {
                var judge = s[i] == s[j];
                
                dp[i,j] = j - i > 2 ? dp[i + 1,j - 1] && judge : judge;
                
                if (dp[i,j] && j - i + 1 > longest.Length) {
                    longest = s.Substring(i, j - i + 1);
                }
            }
        }
        return longest ?? string.Empty;
    }
}