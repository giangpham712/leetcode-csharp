namespace ConsoleApp.Problems.LeetCode._3Sum;

/*
 * Sort the array
 * Use Two Pointers method
 */
public class ThreeSumSolution2
{
    public IList<IList<int>> Solve(int[] nums)
    {
        var results = new List<IList<int>>();
        
        if (nums.Length < 3) {
            return results;
        }
        
        // Sort the array
        Array.Sort(nums);
        
        
        var i = 0;
        while (i < nums.Length - 2) {
            var iNum = nums[i];
            if (iNum > 0) {
                break;
            }
            
            var difference = 0 - nums[i];
            
            var j = i + 1;
            var k = nums.Length - 1;
            
            while (j < k) {
                if (nums[i] + nums[j] > 0)
                {
                    break;
                }
                
                if (nums[j] + nums[k] == difference) {
                    var result = new List<int>() { nums[i], nums[j], nums[k] }; 
                    results.Add(result);
                    
                    while (j < k && nums[j] == result[1])
                        j++;
                    while (j < k && nums[k] == result[2])
                        k--;
                    
                } else if (nums[j] + nums[k] < difference) {
                    j++;
                } else {
                    k--;
                }
            }

            while (i < nums.Length - 2 && nums[i] == iNum)
            {
                i++;
            }
        }
        
        return results;
    }
}