namespace ConsoleApp.Problems.LeetCode.IntersectionOfMultipleArrays;

public class ProblemSolution
{
    public IList<int> Solve(int[][] nums)
    {
        var bucket = new int[1000 + 1];

        for (var i = 0; i < nums.Length; i++) {
            for (var j = 0; j < nums[i].Length; j++) {
                bucket[nums[i][j]]++;
            }
        }

        var result = new List<int>();
        for (var i = 0; i < bucket.Length; i++) {
            if (bucket[i] == nums.Length) {
                result.Add(i);
            }
        }

        return result;
    }
}