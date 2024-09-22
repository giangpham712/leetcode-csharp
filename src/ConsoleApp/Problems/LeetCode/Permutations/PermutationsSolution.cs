namespace ConsoleApp.Problems.LeetCode.Permutations;

public class PermutationsSolution
{
    public IList<IList<int>> Solve(int[] nums)
    {
        var results = new List<IList<int>>();
        
        Backtrack([], new HashSet<int>(nums), results, nums.Length);
        
        return results;
    }

    private void Backtrack(int[] current, HashSet<int> nums, List<IList<int>> results, int expectedSize)
    {
        foreach (var num in nums)
        {
            var newArray = new int[current.Length + 1];
            Array.Copy(current, newArray, current.Length);
            newArray[current.Length] = num;

            if (newArray.Length == expectedSize)
            {
                results.Add(newArray);
                continue;
            }

            var newNums = new HashSet<int>(nums);
            newNums.Remove(num);
            Backtrack(newArray, newNums, results, expectedSize);
        }
    }
}