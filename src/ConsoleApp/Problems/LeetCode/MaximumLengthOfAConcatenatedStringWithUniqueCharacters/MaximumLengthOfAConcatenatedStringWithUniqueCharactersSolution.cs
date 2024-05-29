namespace ConsoleApp.Problems.LeetCode.MaximumLengthOfAConcatenatedStringWithUniqueCharacters;

public class MaximumLengthOfAConcatenatedStringWithUniqueCharactersSolution
{
    public int Solve(IList<string> arr)
    {
        return BackTrack(arr.ToList(), new HashSet<char>());
    }

    private int BackTrack(List<string> arr, HashSet<char> current)
    {
        var max = 0;
        for (var i = 0; i < arr.Count; i++)
        {
            var set = new HashSet<char>(current);
            foreach (var c in arr[i])
            {
                set.Add(c);
            }

            if (set.Count != current.Count + arr[i].Length)
            {
                continue;
            }
            
            max = Math.Max(max, arr[i].Length + BackTrack(arr[(i + 1)..], set));
        }

        return max;
    }
}