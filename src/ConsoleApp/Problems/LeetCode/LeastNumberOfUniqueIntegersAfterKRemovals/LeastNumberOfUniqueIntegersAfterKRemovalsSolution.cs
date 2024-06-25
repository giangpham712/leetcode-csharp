namespace ConsoleApp.Problems.LeetCode.LeastNumberOfUniqueIntegersAfterKRemovals;

public class LeastNumberOfUniqueIntegersAfterKRemovalsSolution
{
    public int Solve(int[] arr, int k)
    {
        var frequencies = new Dictionary<int, int>();

        var maxFrequency = 0;
        foreach (var num in arr)
        {
            if (frequencies.ContainsKey(num))
            {
                frequencies[num]++;
            }
            else
            {
                frequencies[num] = 1;
            }

            maxFrequency = maxFrequency > frequencies[num] ? maxFrequency : frequencies[num];
        }

        var buckets = new int[maxFrequency + 1];

        foreach (var frequency in frequencies)
        {
            buckets[frequency.Value]++;
        }

        var result = frequencies.Count;
        for (var i = 0; i < buckets.Length; i++)
        {
            if (buckets[i] == 0)
            {
                continue;
            }

            var removals = Math.Min(k / i, buckets[i]);
            k -= removals * i;
            result -= removals;
        }
        
        return result;
    }
}