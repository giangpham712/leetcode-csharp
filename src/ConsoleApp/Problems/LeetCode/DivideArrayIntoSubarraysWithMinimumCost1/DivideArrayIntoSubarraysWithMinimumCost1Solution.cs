namespace ConsoleApp.Problems.LeetCode.DivideArrayIntoSubarraysWithMinimumCost1;

public class DivideArrayIntoSubarraysWithMinimumCost1Solution
{
    public int Solve(int[] nums)
    {
        if (nums.Length == 3)
        {
            return nums[0] + nums[1] + nums[2];
        }

        var min1 = int.MaxValue;
        var min2 = int.MaxValue;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < min1)
            {
                min2 = min1;
                min1 = nums[i];
            }
            else if (nums[i] < min2)
            {
                min2 = nums[i];
            }
        }

        return nums[0] + min1 + min2;
    }
}