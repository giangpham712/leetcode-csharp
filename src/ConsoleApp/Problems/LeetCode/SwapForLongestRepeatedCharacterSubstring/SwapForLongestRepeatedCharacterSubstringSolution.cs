namespace ConsoleApp.Problems.LeetCode.SwapForLongestRepeatedCharacterSubstring;

public class SwapForLongestRepeatedCharacterSubstringSolution
{
    public int Solve(string text)
    {
        var frequencies = new Dictionary<char, int>();
        foreach (var c in text)
        {
            if (frequencies.ContainsKey(c))
            {
                frequencies[c] += 1;
            }
            else
            {
                frequencies[c] = 1;
            }
        }
        
        var max = 0;
        for (int i = 0; i < text.Length; i++)
        {
            var currentMax = 1;
            var currentGap = 0;
            for (var j = i + 1; j < text.Length; j++)
            {
                if (currentGap < 2)
                {
                    if (text[j] == text[i])
                    {
                        currentMax++;
                    }
                    else
                    {
                        currentGap++;
                    }
                }
                else
                {
                    break;
                }
            }

            if (frequencies[text[i]] > currentMax)
            {
                currentMax++;
            }

            max = currentMax > max ? currentMax : max;
        }
        
        return max;
    }
}