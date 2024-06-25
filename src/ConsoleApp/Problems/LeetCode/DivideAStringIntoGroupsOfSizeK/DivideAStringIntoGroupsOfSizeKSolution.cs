using System.Text;

namespace ConsoleApp.Problems.LeetCode.DivideAStringIntoGroupsOfSizeK;

public class DivideAStringIntoGroupsOfSizeKSolution
{
    public string[] Solve(string s, int k, char fill)
    {
        var result = new List<string>();

        for (var index = 0; index < s.Length; index += k)
        {
            result.Add(s.Substring(index, Math.Min(k, s.Length - index)));
        }

        while (result[result.Count - 1].Length < k)
        {
            result[result.Count - 1] += fill;
        }


        return result.ToArray();
    }
}