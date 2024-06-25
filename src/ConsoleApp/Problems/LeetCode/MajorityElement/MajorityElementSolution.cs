namespace ConsoleApp.Problems.LeetCode.MajorityElement;

public class MajorityElementSolution
{
    public int Solve(int[] nums)
    {
        var votes = 0;
        var candidate = -1;
        foreach (var num in nums)
        {
            if (votes == 0)
            {
                candidate = num;
                votes = 1;
            }
            else
            {
                if (num == candidate)
                {
                    votes++;
                }
                else
                {
                    votes--;
                }
            }
        }
        
        return candidate;
    }
}