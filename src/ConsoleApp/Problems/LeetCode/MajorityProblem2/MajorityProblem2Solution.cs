namespace ConsoleApp.Problems.LeetCode.MajorityProblem2;

public class MajorityProblem2Solution
{
    public IList<int> Solve(int[] nums)
    {
        var candidate1 = -1;
        var candidate2 = -1;

        var votes1 = 0;
        var votes2 = 0;

        foreach (var num in nums)
        {
            if (candidate1 == num)
            {
                votes1++;
            }
            else if (candidate2 == num)
            {
                votes2++;
            }
            else if (votes1 == 0)
            {
                candidate1 = num;
                votes1 = 1;
            }
            else if (votes2 == 0)
            {
                candidate2 = num;
                votes2 = 1;
            }
            else
            {
                votes1--;
                votes2--;
            }
        }

        votes1 = 0;
        votes2 = 0;
        foreach (var num in nums)
        {
            if (candidate1 == num)
            {
                votes1++;
            }
            else if (candidate2 == num)
            {
                votes2++;
            }
        }

        var result = new List<int>();

        if (votes1 > nums.Length / 3)
        {
            result.Add(candidate1);
        }
        
        if (votes2 > nums.Length / 3)
        {
            result.Add(candidate2);
        }
        
        return result;
    }
}