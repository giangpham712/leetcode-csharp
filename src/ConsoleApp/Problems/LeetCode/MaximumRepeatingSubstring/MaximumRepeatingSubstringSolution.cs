namespace ConsoleApp.Problems.LeetCode.MaximumRepeatingSubstring;

public class MaximumRepeatingSubstringSolution
{
    public int Solve(string sequence, string word)
    {
        var max = 0;

        for (var i = 0; i < sequence.Length; i++)
        {
            var current = 0;

            var j = i;
            while (j + word.Length <= sequence.Length && sequence.Substring(j, word.Length) == word)
            {
                current++;
                j += word.Length;
            }

            max = current > max ? current : max;
        }
        
        return max;
    }
}