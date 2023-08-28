namespace ConsoleApp.Problems.LeetCode;

/// <summary>
/// Given an integer array nums sorted in non-decreasing order, remove the
/// duplicates in-place such that each unique element appears only once.
/// The relative order of the elements should be kept the same. Then return
/// the number of unique elements in nums.
/// </summary>
public class RemoveDuplicates
{
    public int Solve(int[] nums)
    {
        if (nums.Length == 0 || nums.Length == 1) {
            return nums.Length;
        }
        
        var a = 0;
        var b = 0;
        
        while (b < nums.Length) {
            if (nums[a] == nums[b]) {
                b++;
            } else {
                nums[a + 1] = nums[b];
                b++;
                a++;
                        
            }
        }
        
        
        return a + 1;
    }
}