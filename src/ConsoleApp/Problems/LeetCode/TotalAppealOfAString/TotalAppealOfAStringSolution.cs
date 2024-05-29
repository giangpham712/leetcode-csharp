namespace ConsoleApp.Problems.LeetCode.TotalAppealOfAString;

public class TotalAppealOfAStringSolution
{
    public long Solve(string s)
    {
        var lastPos = new int[26];
        for (var i = 0; i < lastPos.Length; i++)
        {
            lastPos[i] = -1;
        }

        var totalAppeal = 0;
        var currentAppeal = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var letterIndex = char.ToUpper('a') - 65;
            lastPos[letterIndex] = i;
            
            
        }
        
        return totalAppeal;
    }
}