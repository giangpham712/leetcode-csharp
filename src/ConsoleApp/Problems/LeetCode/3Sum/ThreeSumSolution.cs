namespace ConsoleApp.Problems.LeetCode._3Sum;

/*
 * 
 */
public class ThreeSumSolution
{
    public IList<IList<int>> Solve(int[] nums)
    {
        if (nums.Length < 3) {
            return new List<IList<int>>();
        }

        Array.Sort(nums);
        
        var map = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            map[nums[i]] = i;
        }

        var seen = new HashSet<string>();
        var results = new List<IList<int>>();
        
        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] > 0)
            {
                break;
            }

            if (nums[i] == nums[i - 1])
            {
                continue;
            }
            
            for (var j = i + 1; j < nums.Length - 1; j++)
            {
                if (map.TryGetValue(0 - (nums[i] + nums[j]),  out var k) && k > j && seen.Add($"{nums[i]}{nums[j]}{nums[k]}"))
                {
                    results.Add(new List<int>() { nums[i], nums[j], nums[k]});
                }
            }
        }

        return results;
    }
}