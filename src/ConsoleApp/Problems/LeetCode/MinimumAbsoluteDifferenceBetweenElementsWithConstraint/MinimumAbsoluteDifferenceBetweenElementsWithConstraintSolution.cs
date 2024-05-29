using System.Collections.Immutable;
using System.Collections.Specialized;

namespace ConsoleApp.Problems.LeetCode.MinimumAbsoluteDifferenceBetweenElementsWithConstraint;

public class MinimumAbsoluteDifferenceBetweenElementsWithConstraintSolution
{
    public int Solve(IList<int> nums, int x)
    {
        if (x == 0) {
            return 0;
        }

        var min = int.MaxValue;
        var values = new SortedList<int, int>();
        var set = new HashSet<int>();
        for (var j = x; j < nums.Count; j++)
        {
            if (set.Add(nums[j - x]))
            {
                values.Add(nums[j - x], nums[j - x]);
            }
            
            if (j >= x)
            {
                var value = BinarySearch(values, nums[j]);
                min = Math.Min(min, value);
            }
        }

        return min;
    }

    private int BinarySearch(SortedList<int, int> list, int target)
    {
        
        var start = 0;
        var end = list.Count;
        
        while (start < end)
        {
            var mid = (start + end) / 2;

            if (list.Values[mid] == target)
            {
                return Math.Abs(target - list.Values[mid]);
            }

            if (mid == start)
            {
                if (end > list.Count - 1)
                {
                    return Math.Abs(target - list.Values[start]);
                }
                
                return Math.Min(
                    Math.Abs(target - list.Values[start]), 
                    Math.Abs(target - list.Values[end]));
            }
            
            if (list.Values[mid] > target)
            {
                end = mid;
            }
            else
            {
                start = mid;
            }
        }

        return Math.Abs(target - list.Values[start]);
    }
}