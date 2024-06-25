namespace ConsoleApp.Problems.LeetCode.FindDuplicateNumber;

public class FindDuplicateNumberSolution
{
    public int Solve(int[] nums)
    {
        var p1 = 0;
        var p2 = 0;
        do
        {
            p1 = nums[p1];
            p2 = nums[nums[p2]];
        } while (p1 != p2);

        p1 = 0;
        
        while (p1 != p2)
        {
            p1 = nums[p1];
            p2 = nums[p2];
        } 
        
        return p1;
    }

    public int Solve2(int[] nums)
    {
        return default;
    }
}