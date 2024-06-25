namespace ConsoleApp.Problems.LeetCode.CountEqualAndDivisiblePairsInAnArray;

public class CountEqualAndDivisiblePairsInAnArraySolution
{
    public int Solve(int[] nums, int k)
    {
        var total = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((i * j % k == 0) && nums[i] == nums[j])
                {
                    total++;
                }
            }
        }

        return total;
    }
}