namespace ConsoleApp.Problems.LeetCode.MaximumSubarray;

public class ProblemSolution
{
    public int Solve(int[] nums)
    {
        var currentSum = 0;
        var max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = nums[i];
            }
            else
            {
                currentSum += nums[i];
            }

            max = currentSum > max ? currentSum : max;
        }
        
        return max;
    }

    public int Solve2(int[] nums)
    {
        return default;
    }
}