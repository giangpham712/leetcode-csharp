namespace ConsoleApp.Problems.LeetCode.NextPermutation;

public class NextPermutationSolution
{
    public void Solve(int[] nums)
    {
        if (nums.Length == 1)
        {
            return;
        }
        
        var p1 = nums.Length - 1;
        var p2 = p1 - 1;

        while (p2 >= 0)
        {
            
            if (nums[p2] < nums[p1])
            {
                (nums[p1], nums[p2]) = (nums[p2], nums[p1]);
                p1 = p2 + 1;
                p2 = nums.Length - 1;

                while (p1 < p2)
                {
                    (nums[p1], nums[p2]) = (nums[p2], nums[p1]);
                    p1++;
                    p2--;
                }

                return;
            }
            else
            {
                p1--;
            }

            if (p2 == p1)
            {
                p2--;
                p1 = nums.Length - 1;
            }
        }

        p1 = 0;
        p2 = nums.Length - 1;
        while (p1 < p2)
        {
            (nums[p1], nums[p2]) = (nums[p2], nums[p1]);
            p1++;
            p2--;
        }
    }
}