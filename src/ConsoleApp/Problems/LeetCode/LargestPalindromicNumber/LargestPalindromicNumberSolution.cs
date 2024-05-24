using System.Text;

namespace ConsoleApp.Problems.LeetCode.LargestPalindromicNumber;

public class LargestPalindromicNumberSolution
{
    public string Solve(string num)
    {
        var frequencies = new Dictionary<char, int>();

        foreach (var c in num)
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

        var sorted = frequencies.Keys.OrderDescending().ToList();

        var nonZero = false;
        var left = new StringBuilder();
        foreach (var digit in sorted)
        {
            if (frequencies[digit] < 2)
            {
                continue;
            }
            
            if (digit != '0')
            {
                nonZero = true;
            }

            if (!nonZero)
            {
                continue;
            }
            
            while (frequencies[digit] >= 2)
            {
                left.Append(digit);
                frequencies[digit] -= 2;
            }
        }

        var sortedRemainingDigits = sorted.Where(x => frequencies[x] > 0).ToArray();
        var mid = sortedRemainingDigits.Any()
            ? sortedRemainingDigits[0].ToString()
            : ""; 

        var result = left.ToString();
        return (result + mid + string.Join("", result.Reverse()));
    }
}