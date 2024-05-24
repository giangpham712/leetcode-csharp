using System.Text;

namespace ConsoleApp.Problems.LeetCode.LargestNumber;

public class LargestNumberSolution
{
    public object Solve(int[] nums)
    {
        var zeroes = new StringBuilder();
        var nonZeroes = new List<string>();
        foreach (var num in nums)
        {
            if (num == 0) zeroes.Append(num);
            else nonZeroes.Add(num.ToString());
        }
        
        if (!nonZeroes.Any())
        {
            return "0";
        }
        
        var sorted = nonZeroes.OrderDescending(new NumComparer()).ToList();
        if (sorted[0] == "0")
        {
            return "0";
        }

        return string.Join("", sorted) + zeroes.ToString();
    }

    class NumComparer : IComparer<string>
    {
        
        public int Compare(string x, string y)
        {
            if (x == "0")
            {
                return -1;
            }
            
            return String.Compare($"{x}{y}", $"{y}{x}", StringComparison.Ordinal);
        }
    }
}