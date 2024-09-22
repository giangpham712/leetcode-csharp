namespace ConsoleApp.Problems.LeetCode.LongestConsecutiveSequence;

public class ProblemSolution
{
    public int Solve(int[] nums)
    {
        var set = new HashSet<int>(nums);

        var longest = 0;
        var seen = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!seen.Add(num))
            {
                continue;
            }

            var current = 1;

            var prev = num - 1;
            while (set.Contains(prev))
            {
                seen.Add(prev);
                current++;
                prev = prev - 1;
            }
            
            var next = num + 1;
            while (set.Contains(next))
            {
                seen.Add(next);
                current++;
                next = next + 1;
            }

            longest = Math.Max(current, longest);
        }

        return longest;
    }
}