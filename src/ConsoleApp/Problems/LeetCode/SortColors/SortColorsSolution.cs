namespace ConsoleApp.Problems.LeetCode.SortColors;

public class SortColorsSolution
{
    public void Solve(int[] nums)
    {
        var i = 0;
        var left = 0;
        var right = nums.Length - 1;
        
        while (i <= right) {
            if (nums[i] == 0) {
                nums[i] = nums[left];
                nums[left] = 0;
                left++;
            }        
            
            if (nums[i] == 2) {
                nums[i] = nums[right];
                nums[right] = 2;
                i--;
                right--;
            }
            i++;
        }
    }

    public void Solve2(int[] nums)
    {
        var frequencies = new int[3];

        foreach (var num in nums)
        {
            frequencies[num]++;
        }

        var index = 0;
        for (var i = 0; i < frequencies.Length; i++)
        {
            for (var j = 0; j < frequencies[i]; j++)
            {
                nums[index] = i;
                index++;
            }
        }
    }
}