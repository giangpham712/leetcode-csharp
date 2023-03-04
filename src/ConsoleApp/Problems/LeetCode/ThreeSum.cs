namespace ConsoleApp.Problems.LeetCode;

/// <summary>
/// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]]
/// such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0. <br/>
/// Notice that the solution set must not contain duplicate triplets.
/// </summary>
public class ThreeSum
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<IList<int>> Solve(int[] nums) {
        var results = new List<IList<int>>();
        
        if (nums.Length < 3) {
            return results;
        }
        
        Array.Sort(nums);
        
        var i = 0;
        while (i < nums.Length - 2) {
            var iNum = nums[i];
            if (iNum > 0) {
                break;
            }
            
            var difference = 0 - iNum;
            
            var j = i + 1;
            var k = nums.Length - 1;
            
            while (j < k) {
                var jNum = nums[j];
                var kNum = nums[k];
                
                if (jNum + kNum == difference) {
                    var result = new List<int>() { iNum, jNum, kNum }; 
                    results.Add(result);
                    
                    while (j < k && nums[j] == result[1])
                        j++;
                    while (j < k && nums[k] == result[2])
                        k--;
                    
                } else if (jNum + kNum < difference) {
                    j++;
                } else {
                    k--;
                }
            }
            
            while (i < nums.Length - 2 && nums[i] == iNum)
                i++;
        }
        
        return results;
    }
}